using Microsoft.AspNetCore.Http;
using RentACar.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.Utilities.FileProcesses.Abstract
{
    public interface IImageProcess
    {
        Task UploadAsync(string fileName, IFormFile file);
        void Delete(string path);
    }
}
