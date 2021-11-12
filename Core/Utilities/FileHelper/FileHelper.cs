using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {

        public static string Add(IFormFile file, string directory, string path) // path: Location to add
        {
            string extension = Path.GetExtension(file.FileName).ToUpper();
            string newFileName = Guid.NewGuid().ToString("N") + extension;

            if (!Directory.Exists(directory + path))
            {
                Directory.CreateDirectory(directory + path);
            }

            using (FileStream fileStream = File.Create(directory + path + newFileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }

            return (path + newFileName).Replace("\\", "/");
        }

        public static string Update(IFormFile file, string directory, string path, string oldImagePath, string defaultPath) // path: Location to add
        {
            if (File.Exists(directory + oldImagePath.Replace("/", "\\"))
                && Path.GetFileName(oldImagePath) != Path.GetFileName(defaultPath))
            {
                Delete(oldImagePath, directory);
            }
            return Add(file, directory, path);
        }

        public static void Delete(string directory, string imagePath)
        {
            File.Delete(directory + imagePath.Replace("/", "\\"));
        }
    }
}
