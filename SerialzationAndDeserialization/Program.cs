using System;
using SerialzationAndDeserialization;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome To address book");
        Console.WriteLine("1.Add contact Details\n2.Edit Contact Details");
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
