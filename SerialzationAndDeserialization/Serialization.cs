using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerialzationAndDeserialization
{
    public class Serialization
    {
       
        public void Serializedata()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name ="Mohan",
                Desc = "welcome the program"
            };
            string JsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(JsonData);
        }
    }
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Desc { get; set; }
    }
}
