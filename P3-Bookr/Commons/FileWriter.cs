using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P3_Bookr.Commons
{
    class FileWriter
    {
        public void WriteStringToFile(string path, string stringToWrite)
        {
            File.WriteAllText(path, stringToWrite);
        }
    }
}
