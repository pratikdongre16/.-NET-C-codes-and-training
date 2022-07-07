using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training.net
{
    internal class ArrayDemo
    {
        public void GetTotoalTickets()
        {
            //What is jagged array? Easy to customize
            string[][] counter = new string[3][];
            counter[0] = new string[3];
            counter[1] = new string[2];
            counter[3]= new string[4];

            //counter[0][0] = "P1";
            //counter[0][1] = "P1";
            //counter[0][2] = "P1";

            //counter[1][0] = "P4";
            //counter[1][1] = "P5";

            //counter[2][0] = "P6";
            //counter[2][1] = "P7";
            //counter[2][2] = "P8";
           // counter[0] =["P1","P2","P3"];

            for (int i = 0; i < counter.Length; i++)
            {
                for (int j = 0; j < counter[i].Length; j++)
                {
                    counter[i][j] = Console.ReadLine();
                }
            }


        }



    }
}
