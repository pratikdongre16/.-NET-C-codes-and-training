using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace training.net
{    // EXCEPTION HANDLING- to catch run time errors

    // GARBAGE COLLECTION: In .NET, Objects will be removed automatically from
    //                     memory 
    // Object.Dispose(): releases 

    internal class GenericsDemo
    {   
        public void ShowReport <T>(T value)
        {
            Console.WriteLine(value);
        }
        //public void ShowGenderReport(string gender)
        //{
        //    Console.WriteLine(gender);

        //}
        //public void ShowAgeReport(int age)
        //{
        //    Console.WriteLine(age);

        //}
        //public void ShowSalaryReport(double salary)
        //{
        //    Console.WriteLine(salary);

        //}


        public static void Data()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);



            //STACK: LIFO
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push("Raj");
            stack.Push(5000);

            Console.WriteLine(stack.Pop());

            //QUEUE:FIFO
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue("Raj");
            queue.Enqueue(5000);
            
        }

        public static void Generic()
        {

            try
            {
                //business logic code or source code
            }
            catch(Exception ex)
            {
                //log exception
            }
            Dictionary<int, string> student = new Dictionary<int, string>();
            student[101] = "PASSED";
            student[102] = "FAILED";
            student[103] = "PASSED";
            student[104] = "PASSED";
            student[105] = "FAILED"; 

            foreach(var item in student)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);

                //How to get value by passing key?
                Console.WriteLine(student[item.Key]);

            }

            Hashtable hastable= new Hashtable();
            hastable[101] = "passsed";
            hastable[102] = "failed";
            Hashtable[103] = "passed";


        }

    }
}
