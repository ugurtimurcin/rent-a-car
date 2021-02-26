using Microsoft.AspNetCore.Http;
using RentACar.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.Utilities.Helpers.FileHelper.Abstract
{
    public interface IFileProcess
    {
        Task UploadAsync(string folderName, IFormFile file);
        void Delete(string path);
    }
}
