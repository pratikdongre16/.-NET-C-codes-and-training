using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// return type methods- int, string, float, decimal, objects
// no return type methods- void, 
namespace training.net
{
    public class Event
    {
        public int EventId;
        public void CreateEvent()
        {
            Console.WriteLine("EVENT CANCELLED");
        }

        public void SelectEvents()
        {
            Console.WriteLine("EVENTS SELECTED!");
        }
    }
}
