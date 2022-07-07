using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace training.net
{  
    
    public class Employee
    {
        public int Id = 1;
        public String name = "John Smith";
        public string subject = "Physics";

    }

    public class WeatherForecast
    {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string Summary { get; set; }
    }

internal class Serializationdemo
    {    
       
        
        public void XmlSerialize()
        { Employee bs = new Employee();
            var xs = new XmlSerializer(typeof(Employee));
            TextWriter txtWriter = new StreamWriter(@"C:\Users\pradongre\Documents\.net training\serialization.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close();
        }

        public void XmlDeSerialize()
        {
            Employee bs= new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            StreamReader reader = new StreamReader(@"C:\Users\pradongre\Documents\.net training\serialization.xml");
            bs = (Employee)xs.Deserialize(reader);
            Console.WriteLine("Employee Details");
            Console.WriteLine("Id:" + bs.Id);
            Console.WriteLine("Name:" + bs.name);
            Console.WriteLine("Subject:"+bs.subject);
        }
        
        public void JsonSerialize()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "hot"

            };
            
           //hot to serialize to json
           string jsonString =JsonSerializer.Serialize(weatherForecast);
            //how to deserialize to json
            var obj = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
            Console.WriteLine(obj.Date);
            Console.WriteLine(obj.TemperatureCelsius);
            Console.WriteLine(obj.Summary);

        }

    }
}
