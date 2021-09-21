using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "task.json";
            string path = Path.GetFullPath(filename);
            Console.WriteLine(path);

            

            
            // File json = JsonCovert.DeserializedIbject<File>(path);

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                File file =  JsonSerializer.Deserialize<File>(stream);
                Console.WriteLine(file.param1, file.param2, file.param3);
            }

        }
    }

    public class File
    {
        public string param1 { get; set; }
        public string param2 { get; set; }
        public double param3 { get; set; }
       

      

    }

   
}
