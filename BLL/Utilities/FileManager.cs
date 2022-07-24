using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Utilities
{
    public class FileManager
    {
        public static void RemoveFile(string fileName, string savePath)
        {
            if (fileName == null)
                throw new Exception("File Is Null");
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), savePath.Replace("/", "\\"));
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            var fullPath = Path.Combine(folderPath, fileName);

            //var filePath = Path.Combine(Directory.GetCurrentDirectory(), path, fileName);
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
              


        }
        public static string SaveFileAndReturnName(IFormFile file, string savePath)
        {
            if (file == null)
                throw new Exception("File Is Null");

            var fileName = $"{Guid.NewGuid()}{file.FileName}";

            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), savePath.Replace("/", "\\"));
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            var fullPath = Path.Combine(folderPath, fileName);

            using var stram = new FileStream(fullPath, FileMode.Create);
            file.CopyTo(stram);
            return fileName;
        }

        public static string ValidateProfilePicture(IFormFile file)
        {
            var size = file.Length / (1024 * 1024);
            string[] words = file.FileName.Split('.');
            string[] ValidExtImg = { "jpg", "jpeg", "png" };
            var ext = words[1];
            if (size > 3)
            {
                return "SIZE";
            }
            int pos = Array.IndexOf(ValidExtImg, ext);
            if (pos <= -1)
            {
                return "FORMAT";
            }

            return "NO_ERROR";

        }
    }
}
