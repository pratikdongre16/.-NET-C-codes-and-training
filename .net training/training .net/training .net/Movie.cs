using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  //File Handling

namespace training.net
{
    internal class Movie
    {
        public void CreateMovie()
        {
            //how to create file?
            FileStream fileStreamObj = new FileStream(@"C:\Users\pradongre\Documents\.net training\movie.txt",FileMode.Create,FileAccess.Write);
        
            // how to write file?
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            //streamWriter.WriteLine("MovieId:123");
            //streamWriter.WriteLine("MovieName:RRR");
            //streamWriter.WriteLine("MovieDesc:Action");
            //streamWriter.WriteLine("MovieLanguage:Telgu");
            Console.WriteLine("ENTER MOVIE ID");
            streamWriter.WriteLine(Console.ReadLine()); 
            Console.WriteLine("ENTER MOVIE NAME");
            streamWriter.WriteLine(Console.ReadLine());
            Console.WriteLine("ENTER MOVIE DESCRIPTION");
            streamWriter.WriteLine(Console.ReadLine());
            Console.WriteLine("ENTER MOVIE LANGUAGE");
            streamWriter.WriteLine(Console.ReadLine());

            streamWriter.Close();  //CLose writing operation
            fileStreamObj.Close(); // Close file operation
            Console.WriteLine("FILE OPERATION");


        }

        public void SelectMovie()
        {
            FileStream fileStream = new FileStream(@"C:\Users\pradongre\Documents\.net training\movie.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
            //Console.WriteLine(streamReaderObj.ReadLine());
            //Console.WriteLine(streamReaderObj.ReadLine());
            //Console.WriteLine(streamReaderObj.ReadLine());
            //Console.WriteLine(streamReaderObj.ReadLine());

            //how to declare array?
            // fixed array and dynamic array/

           // string[] myValues = new string[5];
            while (streamReaderObj.Peek() > 0)
            {
               string line= streamReaderObj.ReadLine();
               string[] myStr = line.Split(':');
                Console.WriteLine(myStr[1]);
            }
            
            
            
            
            fileStream.Close();


        }
    }
}
