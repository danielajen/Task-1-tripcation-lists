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
            string filename = "trip1.txt";
           
            List<string> Data = new List<string>();
            // ask which trip and place filename paramters to answer
            Console.WriteLine("which trip would you like to choose from?, Pick a num from 1-3");
            int answer=0;
            



            while (answer > 3 || answer < 1)
            {
                bool proper = int.TryParse(Console.ReadLine(), out answer);
            while( proper == false )
            {
                Console.WriteLine("enter only numbers!");
                proper = int.TryParse(Console.ReadLine(), out answer);
            }
                if ( answer > 3)
                {
                    proper = false;
                    Console.WriteLine("Sory, they're only 3 options, only from 1-3");
                }
            }   
                if (answer == 1) filename = "trip1.txt";
                if (answer == 2) filename = "trip2.txt";
                if (answer == 3) filename = "trip3.txt";
            
            
           
                 
           

            StreamReader file = new StreamReader(filename);
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
            file.Close();
            Console.WriteLine("welcome to Daniel's tripcation!, let's see if you have a good ratio to book a trip ");
            // ratio from adults to students
            double ratio = (double)adults / students;
            // ratio has to be 0.1
            if (ratio == 0.1)
            {
                Console.WriteLine("can go on trip ");
            }
            // not 0.1, cannot go
            else
            {
                Console.WriteLine("cannot go on trip");
            }
            // Outputs 
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                output.WriteLine("number of adults: " + adults);
                output.WriteLine("number of students: " + students);
                if (ratio == 0.1)
                {
                    output.WriteLine("can go on trip " + ratio);
                }
                else
                {
                    output.WriteLine(" sorry cannot go on trip, ratio is wack! too many youngins! " + ratio);
                }
            }
            
            
        }
        }
    }

