using Microsoft.AspNetCore.Http;
using RentACar.Core.Utilities.Helpers.FileHelper.Abstract;
using RentACar.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.Utilities.Helpers.FileHelper
{
    public class FileProcesses : IFileProcess
    {
        public virtual async Task UploadAsync(string folderName, IFormFile file)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), $"{folderName}/" + fileName);
            using var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
        }

        public void Delete(string path)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/{path}");
            if (File.Exists(filePath))
            {
                File.Delete(path);
            }
        }
    }
}
