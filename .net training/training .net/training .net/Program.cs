using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a;
            //int b;
            //int c;
            //Console.WriteLine("ENTER VALUE A:");

            // a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ENTER VALUE B");
            // b = Convert.ToInt32(Console.ReadLine());
            //c = a + b;
            //How to print/display output?
            //Console.Write("OUTPUT:");
            //Console.Write(c);
            //Console.WriteLine(c);
            // Console.Read(); // how to read keyboard input?

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);


            //}
            //Event eventObj= new Event();  // HOW TO CREATE OBJECT
            //eventObj.CreateEvent();
            //eventObj.SelectEvents();
            //Console.Read();
            //Movie movieObj= new Movie();
            //movieObj.CreateMovie();


            //movieObj.SelectMovie();

            //Serializationdemo serializationdemo = new Serializationdemo();
            //serializationdemo.XmlDeSerialize();

            //Serializationdemo serializationdemo = new Serializationdemo();
            //serializationdemo.JsonSerialize();

            //GenericsDemo ob = new GenericsDemo();
            //ob.ShowSalaryReport(50000);
            //ob.ShowGenderReport("male");
            //ob.ShowAgeReport(21);

            //ob.ShowReport<int>(10);
            //ob.ShowReport<string>("STUDENT");
            //ob.ShowReport<double>(500);
            //ob.ShowReport<bool>(true);

            serialization_handson hob = new serialization_handson();
            //  hob.XmlSerializeHO();
            //  hob.XmlDeSerializeHO();

            hob.JsonSerializeHO();

            Console.Read();
        }
    }
}
