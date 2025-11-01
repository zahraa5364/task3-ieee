using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_ieee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            float[] grades= new float[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter name of student " + (i + 1) + ":");
                names[i] = Console.ReadLine();
                Console.WriteLine("Enter grade of student " + (i + 1) + ":");
                grades[i] = float.Parse(Console.ReadLine());

            }

            float averageGrade = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                averageGrade += grades[i];
            }
            averageGrade /= grades.Length;
            Console.WriteLine("Average Grade: " + averageGrade);

            Console.WriteLine("Students with grade above average:");
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > averageGrade)
                {
                    Console.WriteLine(names[i] + " with grade " + grades[i]);
                }
            }
        }
    }
}
