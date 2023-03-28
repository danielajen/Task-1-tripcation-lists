using System;
using System.IO;
using System.Collections.Generic;

namespace Task_1_lists
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int adults = 0;
            int students = 0;
            // files read
            StreamReader file = new StreamReader("trip1.txt");
            StreamReader file1 = new StreamReader("trip2.txt");
            StreamReader file2 = new StreamReader("trip3.txt");
            List<string> Data = new List<string>();

            if (file )
            string input = file.ReadLine();
            while (input != null)
            {
                int age = int.Parse(input);
                if (age >= 19)
                {
                    adults++;
                }
                else
                {
                    students++;
                }
                input = file.ReadLine();
            }
            Console.WriteLine("welcome to Daniel's tripcation! ");
            // ratio from adults to students
            double ratio = (double)adults / students;

            if ((double)adults /10 == 0.1)
            {
                Console.WriteLine("can go on trip ");
            }
            else
            {
                Console.WriteLine("cannot go on trip");
            }
            // Outputs 
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                output.WriteLine("number of adults: " + adults);
                output.WriteLine("number of students: " + students);
                if (adults == 0.1)
                {
                    output.WriteLine("can go on trip " + ratio);
                }
                else
                {
                    output.WriteLine(" sorry cannot go on trip, ratio is wack! too many youngins! " + ratio);
                }
            }
            file.Close();
            file1.Close();
            file2.Close();
        }
        }
    }

