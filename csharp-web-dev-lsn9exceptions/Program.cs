using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if(y == 0)
            {
                throw new ArgumentOutOfRangeException("Can't divide by 0");
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            if(fileName == null || fileName == "")
            {
                throw new ArgumentNullException("There is a student that has no file.");
            }
            else if (fileName.EndsWith(".cs"))
            {
                return 1;
            }

   
                return 0;
            
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            Console.WriteLine("Enter num 1: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter num 2: ");
            double y = double.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Divide(x, y));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            students.Add("Jed", null);


            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine(student.Key + " gets " + CheckFileExtension(student.Value) + " points");
                }
                catch (ArgumentNullException)
                {

                    Console.WriteLine(student.Key + " has invalid fileName");

                }

            }


        }

    }
}
