using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_p_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.WriteLine("enter the percentage ");
            marks = int.Parse(Console.ReadLine());
            if(marks>=90)
            {
                Console.WriteLine("Garde A");
            }
            else if(marks>=80)
            {
                Console.WriteLine("Grade B");
            }
            else if(marks>=70)
            {
                Console.WriteLine("Grade C");
            }
            else if(marks>=60)
            { 
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
            Console.ReadKey();
        }
    }
}
