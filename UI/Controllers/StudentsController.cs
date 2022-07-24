using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL.DataContext;
using Domain.Entities;

using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using UI.Models;
using BLL.Services;
using BLL.Contracts;
using DAL.ViewModels;
using BLL.Utilities;

namespace UI.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {

        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: Students
        public IActionResult Index()
        {
            string paged = (HttpContext.Request.Query["paged"].ToString());
            var scheme = HttpContext.Request.Scheme.ToString() + "://";
            var site = HttpContext.Request.Host.Value;
            var uri = HttpContext.Request.Path.Value;
            ViewBag.CurrentUrl = scheme + site + uri;
            ViewBag.Paged = (!String.IsNullOrEmpty(paged)) ? Int32.Parse(paged) : 1;
            var list = _studentService.GetAll();

            int cnt_students = list.Count();
            ViewBag.StudentsNums = cnt_students;
            int per_page = 3;
            int links_num = ((cnt_students / per_page)) + 1;
            int page_num = ViewBag.Paged;
            int last_page_num = links_num;
            int per_page2 = (((page_num - 1) * per_page + per_page - 1) > cnt_students - 1) ? (cnt_students - 1) : (per_page);
            ViewBag.links_num = links_num;
            ViewBag.last_page_num = last_page_num;

            var students_slice = list.Skip((page_num - 1) * per_page).Take(per_page);
            ViewBag.StudentSlice = students_slice;

            return View(ViewBag.StudentSlice);
        }



        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentCreateViewModel studentVM)
        {

            if (CodeMeliExist(studentVM.CodeMeli))
            {
                ModelState.AddModelError("CodeMeli", "کد ملی تکراری است !");
            }
            if (studentVM.PictureFile == null)
            {
                TempData["error_img"] = "تصویر دانش آموز خالی است !";
                return View(studentVM);
            }
            if (FileManager.ValidateProfilePicture(studentVM.PictureFile) == "SIZE")
            {
                TempData["error_img"] = "حجم تصویر بالای 3 مگابایت است !";
                return View(studentVM);
            }
            if (FileManager.ValidateProfilePicture(studentVM.PictureFile) == "FORMAT")
            {
                TempData["error_img"] = "پسوند فایل صحیح نیست !";
                return View(studentVM);
            }


            if (ModelState.IsValid)
            {
                _studentService.Store(studentVM);
                return RedirectToAction(nameof(Index));
            }
            return View(studentVM);
        }

        // GET: Students/Edit/5
        public IActionResult Edit(long id)
        {


            var student = _studentService.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StudentEditViewModel studentVM)
        {

            var lastpathimg = DirectoryManager.GetStudentImage(studentVM.LastPicPath);
            ViewBag.LastStudent = _studentService.GetById(studentVM.IdStudent);



            if (CodeMeliExist(studentVM.CodeMeli, studentVM.LastCodeMeli))
            {
                ModelState.AddModelError("CodeMeli", "کد ملی تکراری است !");
            }
            var PictureFile = studentVM.PictureFile;
            if (PictureFile != null && FileManager.ValidateProfilePicture(PictureFile) == "SIZE")
            {
                TempData["error_img"] = "حجم تصویر بالای 3 مگابایت است !";
                return View(ViewBag.LastStudent);
            }
            if (PictureFile != null && FileManager.ValidateProfilePicture(PictureFile) == "FORMAT")
            {
                TempData["error_img"] = "پسوند فایل صحیح نیست !";
                return View(ViewBag.LastStudent);
            }




            if (ModelState.IsValid)
            {
                _studentService.Update(studentVM);
                return RedirectToAction(nameof(Index));
            }
            return View(ViewBag.LastStudent);
        }

        private bool CodeMeliExist(string codemeli, string lastCodemeli = null)
        {
            return _studentService.CodeMeliExist(codemeli, lastCodemeli);
        }
        // GET: Students/Delete/5
        public IActionResult Delete(long id)
        {


            var student = _studentService.GetById(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            var student = _studentService.GetById(id);
            _studentService.DeleteById(id);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
