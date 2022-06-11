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
    public class Serialization
    {
       
        public void Serializedata()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"D:\dotnet\Serialization\Serialization-Deserialization\SerialzationAndDeserialization\Example.txt", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt = new DateTime(2015,12,31);
            orderForm.OrderDate = dt;
            ser.Serialize(fileStream, orderForm);
        }
    }
   
    public class OrderForm
    {


        public DateTime OrderDate;
    }
}
