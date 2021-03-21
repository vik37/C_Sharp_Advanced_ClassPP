using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SEDC.CLass11.SerializationDeserialization.Entities
{
    public class Students
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty]
        public int Age { get; set; }
        [JsonProperty]
        public string[] Pets { get; set; }

        internal void OnSerializeMethod(StreamingContext context)
        {
            FirstName = FirstName.ToLower();
            LastName = LastName.ToLower();
        }
    }
}
