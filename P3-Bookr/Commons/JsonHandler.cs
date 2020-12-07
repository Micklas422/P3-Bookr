using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace P3_Bookr.Commons
{
    class JsonHandler
    {
        public T ReadJsonObjectFromFile<T>(string path, T returnVal)
        {
            FileReader fileReader = new FileReader();
            var type = returnVal.GetType();
            return (T)JsonConvert.DeserializeObject(fileReader.ReadFileAsString(path), type);
        }

        public void WriteJsonObjectToFile<T>(string path, T objectToWrite)
        {
            FileWriter fileWriter = new FileWriter();
            var type = objectToWrite.GetType();
            fileWriter.WriteStringToFile(path, JsonConvert.SerializeObject(objectToWrite));
        }
    }
}
