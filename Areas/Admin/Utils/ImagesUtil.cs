using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Admin.Utils
{
    public class ImagesUtil
    {
        public static async Task<string> CreateImageFile(IFormFile file)
        {
            var fileName = Path.GetRandomFileName() + Path.GetExtension(file.FileName);
            var fileDirectory = "wwwroot/images";

            if (!Directory.Exists(fileDirectory))
            {
                Directory.CreateDirectory(fileDirectory);
            }

            var filePath = fileDirectory + "/" + fileName;

            // Copy file to path...
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return fileName;
        }
    }
}
