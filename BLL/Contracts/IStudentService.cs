using DAL.ViewModels;
using Domain.Entities;
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

        bool Update(StudentEditViewModel studentVM);
        public bool CodeMeliExist(string codemeli, string lastCodemeli = null);
    }
}
