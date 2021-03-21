using SEDC.CLass11.SerializationDeserialization.Entities;
using SEDC.CLass11.SerializationDeserialization.Servicies;
using System;
using System.IO;
using Newtonsoft.Json;

namespace SEDC.CLass11.SerializationDeserialization
{
    class Program
    {
        private static string directoryPath = Directory.GetCurrentDirectory();
        private static string filePath = Path.Combine(directoryPath, "testJson.json");
        private static JsonSerializerService serializer;
        private static ReadWriteService readerWriter;
        
        static void Main(string[] args)
        {
            serializer = new JsonSerializerService();
            readerWriter = new ReadWriteService();

            Students bob = new Students()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 37,
                Pets = new string[] { "Dog1", "Dog2", "Dog3", "Cat1" }
            };

            string jsonString = serializer.SerializeStudent(bob);
            readerWriter.WriteFile(filePath, jsonString);

            string jsonFormFile = readerWriter.ReadFile(filePath);
            Students student = serializer.DeserializeStudent(jsonFormFile);

            string newtonsoftJasonString = JsonConvert.SerializeObject(student);
            Students newtonsoftStudent = JsonConvert.DeserializeObject<Students>(jsonFormFile);
            
            Console.ReadLine();
        }
    }
}
