using SEDC.CLass11.SerializationDeserialization.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CLass11.SerializationDeserialization.Servicies
{
    public class JsonSerializerService
    {
        public string SerializeStudent(Students student)
        {
            string json = "{";
            json += $"\"FirstName\" : \"{student.FirstName}\",";
            json += $"\"LastName\" : \"{student.LastName}\",";
            json += $"\"Age\" : \"{student.Age}\",";
            json += $"\"Pets\" : [";

            for (int i = 0; i < student.Pets.Length; i++)
            {
                if(i<student.Pets.Length - 1)
                {
                    json += $"\"{student.Pets[i]}\", ";
                }
                else
                {
                    json += $"\"{student.Pets[i]}\"]";
                }
            }
            json += "}";
            return json;
        }
        public Students DeserializeStudent(string json)
        {
            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            string[] singleProperties = content
                .Substring(0, content.IndexOf("Pets") - 1)
                .Split(',');

            string petsArrayProperties = content.Substring(content.IndexOf("Pets"));

            Dictionary<string, string> singlePropsDictionary = new Dictionary<string, string>();

            foreach (string property in singleProperties)
            {
                string[] pair = property.Split(":");
                singlePropsDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            string[] petsPropPair = petsArrayProperties.Split(':');

            //Tuples
            (string, string[]) petsArrayTuple;

            petsArrayTuple.Item1 = petsPropPair[0];
            petsArrayTuple.Item2 = petsPropPair[1]
                .Substring(petsPropPair[1].IndexOf("[") + 1, petsPropPair[1].IndexOf("]") - 2)
                .Split(',');

            Students student = new Students();
            student.FirstName = singlePropsDictionary["FirstName"];
            student.LastName = singlePropsDictionary["LastName"];
            student.Age = int.Parse(singlePropsDictionary["Age"]);
            student.Pets = petsArrayTuple.Item2;

            return student;

        }
    }
}
