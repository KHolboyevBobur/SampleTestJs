using Microsoft.Extensions.FileProviders;
using System.IO;
using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;

namespace SampleTestJs.JsonFile
{
    public class FileJsonWriter
    {
        private IWebHostEnvironment env;
        public FileJsonWriter(IWebHostEnvironment env)
        {
            this.env = env;
        }

        public void WriteToFile(string data)
        {
            string fileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "data.json";
            string filePath = Path.Combine(env.ContentRootPath, fileName);

            using (StreamWriter file = File.CreateText(filePath))
            {
                file.Write(data);
            }
        }
    }
}
