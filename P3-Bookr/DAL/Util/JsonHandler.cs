using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using P3_Bookr.Commons;
using System.IO;

namespace P3_Bookr.DAL
{
    class JsonHandler
    {
        string path = Directory.GetCurrentDirectory() + "\\";
        public T ReadJsonObjectFromFile<T>(string fileName)
        {
            FileReader fileReader = new FileReader();
            return JsonConvert.DeserializeObject<T>(fileReader.ReadFileAsString(path + fileName));
        }

        public void WriteJsonObjectToFile<T>(string fileName, T objectToWrite)
        {
            FileWriter fileWriter = new FileWriter();
            var type = objectToWrite.GetType();
            fileWriter.WriteStringToFile(path + fileName, JsonConvert.SerializeObject(objectToWrite));
        }
    }
}
