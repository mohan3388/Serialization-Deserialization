using System;
using SerialzationAndDeserialization;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome To the Program");
        Console.WriteLine("1.Serialization in xml\n2.Deserialization in xml");
        Serialization serializeDeserialize = new Serialization();

        bool check = true;
        while (check)
        {
            Console.WriteLine("Enter Above option");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    
                    serializeDeserialize.Serializedata();
                    break;
                case 2:

                    Deserialization deserialization = new Deserialization();
                    deserialization.Deserialize();
                    break; ;
            }
        }
    }
}
