using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Utilities
{
    public class DirectoryManager
    {
        public const string StudentImage = "wwwroot/IMGS/students";
        public const string StudentImageUI = "../";
        public static string GetStudentImage(string imageName) => $"{StudentImage.Replace("wwwroot", "")}/{imageName}";
     
    }
}
