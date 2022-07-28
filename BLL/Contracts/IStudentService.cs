using DAL.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IStudentService
    {
        IEnumerable<Student>GetAll();
        Student GetById(long ID);
        Student GetByCodeMeli(string codemeli);
        bool Store(StudentCreateViewModel studentVM);
        bool DeleteById(long ID);
        bool StudentExists(long ID);
        bool Update(StudentEditViewModel studentVM);
        public bool CodeMeliExist(string codemeli, string lastCodemeli = null);
        bool Store_API(StudentCreateViewModel_API studentVM);
        public void uploadPic_API(string codeMeli, IFormFile PictureFile);
    }
}
