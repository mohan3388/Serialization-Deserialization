using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerialzationAndDeserialization
{
    public class Deserialization
    {
        public void Deserialize()
        {
            string jsonData = @"{
'Name':'Mohan',
'Desc':'Welcome program'
}";
      Blog bsObj = JsonConvert.DeserializeObject<Blog>(jsonData);
            Console.WriteLine(bsObj.Name);
        }  
    }
    [DataContract]
    public class Blog
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Desc { get; set; }
    }
}