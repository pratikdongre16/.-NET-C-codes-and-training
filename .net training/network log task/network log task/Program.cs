using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace network_log_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            networklog ob1 = new networklog();
            ob1.showlog();
            Console.Read();
        }
    }
}
