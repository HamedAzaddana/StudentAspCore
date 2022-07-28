using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL.DataContext;
using Domain.Entities;
using BLL.Contracts;
using System.Net;
using DAL.ViewModels;
using BLL.Utilities;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: api/Students
        [HttpGet]
        //public IActionResult GetCustomer()
        public IActionResult GetStudents()
        {
            var result = new ObjectResult(_studentService.GetAll())
            {
                StatusCode = (int)HttpStatusCode.OK
            };
            return result;
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public IActionResult GetStudent([FromRoute] long id)
        {
            if (_studentService.StudentExists(id))
            {

                var customer = _studentService.GetById(id);
                return Ok(customer);
            }
            else
            {
                return NotFound();
            }
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutStudent([FromRoute] long id, [FromBody] StudentEditViewModel studentVM)
        {
            var lastpathimg = DirectoryManager.GetStudentImage(studentVM.LastPicPath);
            if (CodeMeliExist(studentVM.CodeMeli, studentVM.LastCodeMeli))
            {
                ModelState.AddModelError("CodeMeli", "کد ملی تکراری است !");
            }
            var PictureFile = studentVM.PictureFile;
            if (PictureFile != null && FileManager.ValidateProfilePicture(PictureFile) == "SIZE")
            {
                ModelState.AddModelError("PictureFile", "حجم تصویر بالای 3 مگابایت است !");
            }
            if (PictureFile != null && FileManager.ValidateProfilePicture(PictureFile) == "FORMAT")
            {
                ModelState.AddModelError("PictureFile", "پسوند فایل صحیح نیست !");
            }
            if (ModelState.IsValid)
            {
                _studentService.Update(studentVM);
                return Ok(studentVM);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // POST: api/Students
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostStudent([FromBody] StudentCreateViewModel_API studentVM)
        {

            if (CodeMeliExist(studentVM.CodeMeli))
            {
                ModelState.AddModelError("CodeMeli", "کد ملی تکراری است !");
            }


            if (ModelState.IsValid)
            {
                _studentService.Store_API(studentVM);
                return Ok(studentVM);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        // POST: api/Students/upload/{codemeli}
        [HttpPost("upload/{codeMeli}")]
        public IActionResult UploadPic(string codeMeli, IFormFile PictureFile)
        {
            if (PictureFile == null)
            {
                ModelState.AddModelError("PictureFile", "تصویری آپلود نشده است !");
            }
            if (PictureFile != null && FileManager.ValidateProfilePicture(PictureFile) == "SIZE")
            {
                ModelState.AddModelError("PictureFile", "حجم تصویر بالای 3 مگابایت است !");
            }
            if (PictureFile != null && FileManager.ValidateProfilePicture(PictureFile) == "FORMAT")
            {
                ModelState.AddModelError("PictureFile", "پسوند فایل صحیح نیست !");
            }
            if (ModelState.IsValid)
            {
                _studentService.uploadPic_API(codeMeli, PictureFile);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(long id)
        {

            if (!_studentService.StudentExists(id))
            {
                return NotFound();
            }

            _studentService.DeleteById(id);
            return Ok();
        }


        private bool CodeMeliExist(string codemeli, string lastCodemeli = null)
        {
            return _studentService.CodeMeliExist(codemeli, lastCodemeli);
        }
    }
}
