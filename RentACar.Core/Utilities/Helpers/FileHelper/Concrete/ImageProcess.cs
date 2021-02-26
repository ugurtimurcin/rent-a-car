using Microsoft.AspNetCore.Http;
using RentACar.Core.Utilities.Helpers.FileHelper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.Utilities.Helpers.FileHelper.Concrete
{
    public class ImageProcess : FileProcesses, IImageProcess
    {
        private readonly string imageFolder = "wwwroot/CarImages";
        public override Task UploadAsync(string folderName, IFormFile file)
        {
            folderName = imageFolder;
            return base.UploadAsync(folderName, file);
        }
    }
}
