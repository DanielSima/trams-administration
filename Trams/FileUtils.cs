using Newtonsoft.Json;
using System;
using System.IO;

namespace TramDepot
{
    class FileUtils
    {
        public static void Serialize<T>(T objectToSerialize, string path = "../../data.json")
        {
            try
            {
                using (StreamWriter file = File.CreateText(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    file.WriteLine(JsonConvert.SerializeObject(objectToSerialize, Formatting.Indented));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static T Deserialize<T>(string path = "../../data.json")
        {
            try
            {
                using (StreamReader file = File.OpenText(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (T)serializer.Deserialize(file, typeof(T));
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                return default(T); //null, 0, '\0', ...
            }
        }
    }
}
