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
    public class Deserialization
    {
        public void Deserialize()
        {
            string JsonData = @"
{
'Name':'mohan',
'Desc':'Welcome the program'
}";
            BlogSite bsObj = JsonConvert.DeserializeObject<BlogSite>(JsonData);
            Console.WriteLine(bsObj);
        }
    }
    [DataContract]
    public class BlogSite
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Desc { get; set; }
    }
}