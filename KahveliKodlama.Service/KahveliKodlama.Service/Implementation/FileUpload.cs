using KahveliKodlama.Service.Contract;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation
{
    public class FileUpload : IFileUpload
    {
        private readonly string[] extension = new string[] { "image/jpg", "image/png", "image/jpeg" };


        public static IWebHostEnvironment _environment;

        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public static IFormFile files { get; set; }


        public async Task<bool> Complate(IFormFile file)
        {
            foreach (var item in extension)
            {
                if (file.ContentType.ToString() == item)
                {
                    string path = _environment.ContentRootPath + "\\Images\\";


                    PathControl();

                    using (FileStream stream = File.Create(path + file.FileName))
                    {
                        await file.CopyToAsync(stream);
                        await stream.FlushAsync();
                        return true;
                    }
                }
            }

            return false;
        }



        private void PathControl()
        {
            string path = _environment.ContentRootPath + "\\Images\\";


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

        }
    }
}
