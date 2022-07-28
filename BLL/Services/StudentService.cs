using BLL.Contracts;
using BLL.Utilities;
using DAL.DataContext;
using DAL.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly DbHamedtt _context;
        public StudentService(DbHamedtt context)
        {
            _context = context;
        }
        public bool Store(StudentCreateViewModel studentVM)
        {
            string imgpath = FileManager.SaveFileAndReturnName(studentVM.PictureFile, DirectoryManager.StudentImage);
            Student student = new Student
            {
                FirstName = studentVM.FirstName,
                LastName = studentVM.LastName,
                CodeMeli = studentVM.CodeMeli,
            };
            student.ImgPath = imgpath;
            var BirthDate = studentVM.BirthDate;
            int birthYear = Int32.Parse(BirthDate.Year.ToString());
            int birthMonth = Int32.Parse(BirthDate.Month.ToString());
            int birthDay = Int32.Parse(BirthDate.Day.ToString());
            var BirthMiladi = DatePersian.ToMiladi(birthYear, birthMonth, birthDay);
            student.BirthDate = BirthMiladi;
            _context.Add(student);
            _context.SaveChanges();
            return true;
        }
        public void uploadPic_API(string codeMeli, IFormFile PictureFile)
        {
            var student = GetByCodeMeli(codeMeli);
            if (student != null)
            {
                var lastPic = student.ImgPath;
                if (lastPic != null)
                {
                    FileManager.RemoveFile(lastPic, DirectoryManager.StudentImage);
                }
                string imgpath = FileManager.SaveFileAndReturnName(PictureFile, DirectoryManager.StudentImage);
                student.ImgPath = imgpath;
                _context.Update(student);
                _context.SaveChanges();
            }
        }
        public bool Store_API(StudentCreateViewModel_API studentVM)
        {

            Student student = new Student
            {
                FirstName = studentVM.FirstName,
                LastName = studentVM.LastName,
                CodeMeli = studentVM.CodeMeli,
            };

            //var BirthDate = studentVM.BirthDate;
            //int birthYear = Int32.Parse(BirthDate.Year.ToString());
            //int birthMonth = Int32.Parse(BirthDate.Month.ToString());
            //int birthDay = Int32.Parse(BirthDate.Day.ToString());
            //var BirthMiladi = DatePersian.ToMiladi(birthYear, birthMonth, birthDay);
            student.BirthDate = studentVM.BirthDate;
            _context.Add(student);
            _context.SaveChanges();
            return true;
        }
        public bool DeleteById(long ID)
        {
            var student = _context.Students.Find(ID);
            var lastPic = student.ImgPath;
            if (lastPic != null)
            {
                FileManager.RemoveFile(lastPic, DirectoryManager.StudentImage);
            }
            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
        }

        public bool Update(StudentEditViewModel studentVM)
        {
            var lastpathimg = DirectoryManager.GetStudentImage(studentVM.LastPicPath);
            var PictureFile = studentVM.PictureFile;
            Student student = _context.Students.Find(studentVM.IdStudent);
            student.FirstName = studentVM.FirstName;
            student.LastName = studentVM.LastName;
            student.CodeMeli = studentVM.CodeMeli;
            if (PictureFile != null)
            {
                if (studentVM.LastPicPath != null)
                {
                    FileManager.RemoveFile(studentVM.LastPicPath, DirectoryManager.StudentImage);
                }
                string imgpath = FileManager.SaveFileAndReturnName(PictureFile, DirectoryManager.StudentImage);
                student.ImgPath = imgpath;
            }
            else
            {
                student.ImgPath = studentVM.LastPicPath;
            }
            var BirthDatePers = studentVM.BirthDatePers;
            int birthYear = Int32.Parse(BirthDatePers.Year.ToString());
            int birthMonth = Int32.Parse(BirthDatePers.Month.ToString());
            int birthDay = Int32.Parse(BirthDatePers.Day.ToString());
            var BirthMiladi = DatePersian.ToMiladi(birthYear, birthMonth, birthDay);
            student.BirthDate = BirthMiladi;
            _context.Update(student);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Student> GetAll()
        {
            var list = _context.Students.OrderByDescending(s => s.ID).ToList();
            return list;
        }


        public Student GetByCodeMeli(string codemeli)
        {
            var student = _context.Students.Where(s => s.CodeMeli == codemeli).FirstOrDefault();
            return student;
        }
        public bool CodeMeliExist(string codemeli, string lastCodemeli = null)
        {
            var studentL = GetByCodeMeli(codemeli);
            //var studentL = _context.Students.Where(d => d.CodeMeli == codemeli).AsNoTracking().ToList();
            if (lastCodemeli == null)
            {
                if (studentL != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (studentL != null && lastCodemeli != codemeli)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }

        public Student GetById(long ID)
        {

            var student = _context.Students.Where(s => s.ID == ID).FirstOrDefault();
            return student;
        }
        public bool StudentExists(long ID)
        {

            var student = _context.Students.Where(s => s.ID == ID).FirstOrDefault();
            return (student != null);
        }


    }
}
