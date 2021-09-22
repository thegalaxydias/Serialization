using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;


namespace Serialization
{
    [Serializable]
    class Program
    {
       
        static void Main(string[] args)
        {
            string filename = "task.json";
            string path = Path.GetFullPath(filename);
           

            string jsonfile = File.ReadAllText(path);


            Filejson json = JsonConvert.DeserializeObject<Filejson>(jsonfile);

           
             Console.WriteLine($"ProductId: {json.ProductId} \nProductId: {json.Description} \nPrice: {json.Price}");



        }
    }

    public class Filejson
    {
        public string ProductId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
       

      

    }

   
}
