using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace network_log_task
{
    internal class networklog
    {
        public void showlog()
        {
            FileStream logfile = new FileStream(@"C:\Users\pradongre\Documents\.net training\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(logfile);

            string line1 = streamReaderObj.ReadLine();
            string[] headstr1 = line1.Split(':');

            Console.Write(headstr1[0]+"\t");

            string line2 = streamReaderObj.ReadLine();
            string[] headstr2 = line2.Split(':');
          
            Console.Write(headstr2[0]+"\t\t");

            string line3 = streamReaderObj.ReadLine();
            string[] headstr3 = line3.Split(':');
            Console.Write(headstr3[0]+"\t\t");

            string line4 = streamReaderObj.ReadLine();
            string[] headstr4 = line4.Split(':');
            Console.Write(headstr4[0]+"\t\t");

            string line5 = streamReaderObj.ReadLine();
            string[] headstr5 = line5.Split(':');
            Console.Write(headstr5[0]+"\t\t");

            string line6 = streamReaderObj.ReadLine();
            string[] headstr6 = line6.Split(':');
            Console.Write(headstr6[0] + " \t");

            string line7 = streamReaderObj.ReadLine();
            string[] headstr7 = line7.Split(':');
            Console.WriteLine(headstr7);
            


            while ( streamReaderObj.Peek()>0)
            {
                string line = streamReaderObj.ReadLine();
                if (line.StartsWith("Id:"))
                {
                    string[] a = line.Split(':');
                    Console.Write(a[1] + "\t");
                }

                else if (line.StartsWith("Source:"))
                {
                    string[] a = line.Split(':');
                    Console.Write(a[1] + "\t");
                }

                else if (line.StartsWith("Destination:"))
                {
                    string[] a = line.Split(':');
                    Console.Write(a[1] + "\t");
                }

                else if (line.StartsWith("Date:"))
                {
                    string[] a = line.Split(':');
                    Console.Write(a[1] +":"+ a[2]+":" + a[3] + "\t");
                }
                else if (line.StartsWith("Status:"))
                {
                    string[] a = line.Split(':');
                    Console.Write(a[1] + "\t\t");
                }

                else if (line.StartsWith("Network:"))
                {
                    string[] a = line.Split(':');
                    Console.WriteLine(a[1] + "\t");
                }
            }
            logfile.Close();

            







        }
    }
}