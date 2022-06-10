using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerialzationAndDeserialization
{
    public class Serialization
    {
        const string path = @"D:\dotnet\Serialization\Serialization-Deserialization\SerialzationAndDeserialization\Example.txt";
        public void Serializedata()
        {
            Demo data = new Demo();
            FileStream stream = new FileStream(path, FileMode.Create);
            BinaryFormatter bn = new BinaryFormatter();

            bn.Serialize(stream, data);
            stream.Close();
            Console.WriteLine("Convert object to binary");
            string text = File.ReadAllText(path);
            Console.WriteLine(text);

        }
    }
    [Serializable]
    public class Demo
    {
        public string AppName { get; set; } ="Binary Serialize";
        public int AppId { get; set; } = 1001;
    }
}
