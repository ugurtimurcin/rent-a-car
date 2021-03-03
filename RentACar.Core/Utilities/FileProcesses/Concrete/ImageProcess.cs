using Microsoft.AspNetCore.Http;
using RentACar.Core.Utilities.FileProcesses.Abstract;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.Utilities.FileProcesses.Concrete
{
    public class ImageProcess : IImageProcess
    {
        public void Delete(string path)
        {
            var file = new FileInfo(path);
            if (file.Exists)
            {
                file.Delete();
            }
        }

        public async Task UploadAsync(string fileName, IFormFile file)
        {
            var newFileName = fileName + Path.GetExtension(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CarImages/" + newFileName);

            using var stream = new FileStream(path, FileMode.Create);

            await file.CopyToAsync(stream);
        }
    }
}
