using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;

namespace training.net
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    internal class serialization_handson
    {
        public void XmlSerializeHO()
        {
            Person bs = new Person();

            Console.WriteLine("ENTER NAME");
            bs.Name = Console.ReadLine();
            Console.WriteLine("ENTER AGE");
            bs.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER CITY:");
            bs.City = Console.ReadLine();

            var xs = new XmlSerializer(typeof(Person));
            TextWriter txtWriter = new StreamWriter(@"C:\Users\pradongre\Documents\.net training\person_xml.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close();
        }

        public void XmlDeSerializeHO()
        {
            Person bs = new Person();
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            StreamReader reader = new StreamReader(@"C:\Users\pradongre\Documents\.net training\person_xml.xml");
            bs = (Person)xs.Deserialize(reader);
            Console.WriteLine("Person Details");

            Console.WriteLine("Name:" + bs.Name);
            Console.WriteLine("AGE:" + bs.Age);
            Console.WriteLine("CITY:" + bs.City);
        }

        public void JsonSerializeHO()
        {
            Person bs = new Person();

            Console.WriteLine("ENTER NAME");
            bs.Name = Console.ReadLine();
            Console.WriteLine("ENTER AGE");
            bs.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER CITY:");
            bs.City = Console.ReadLine();



            
            //TextWriter txtWriter = new StreamWriter(@"C:\Users\pradongre\Documents\.net training\person_json.json");
            string jsonString = JsonSerializer.Serialize(bs);

            Console.WriteLine(jsonString);

            var obj = JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);
            Console.WriteLine(obj.City);

        }
        
    }

}




