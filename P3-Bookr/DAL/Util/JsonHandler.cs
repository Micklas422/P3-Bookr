using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using P3_Bookr.Commons;

namespace P3_Bookr.DAL
{
    class JsonHandler
    {
        public T ReadJsonObjectFromFile<T>(string path)
        {
            FileReader fileReader = new FileReader();
            return JsonConvert.DeserializeObject<T>(fileReader.ReadFileAsString(path));
        }

        public void WriteJsonObjectToFile<T>(string path, T objectToWrite)
        {
            FileWriter fileWriter = new FileWriter();
            var type = objectToWrite.GetType();
            fileWriter.WriteStringToFile(path, JsonConvert.SerializeObject(objectToWrite));
        }
    }
}
