using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace P3_Bookr.Commons
{
    class FileReader
    {
        public string ReadFileAsString(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
