using System;
using System.Linq;

namespace HW01_3._3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your seniority and monthly income");
            var str = Console.ReadLine();
            if (str != null)
            {
                if (str.Split(' ').Count() == 2)
                {
                    string[] ss = str.Split(' ');
                    var persentege = new[,] { { 5, 0.1 }, { 10, 0.15 }, { 15, 0.25 },{20, 0.35}, {25, 0.45}, { double.MaxValue, 0.5 } };
                    double years = Convert.ToDouble(ss[0]);
                    double income = Convert.ToDouble(ss[1]);

                    int i = 0;

                    while (persentege[i, 0] <= years )
                    {
                        i++;
                    }
                    var result = income * persentege[i, 1];
                    Console.WriteLine("Your bouns is {0}", result);

                    /*     Console.WriteLine("Ваш бонус за {0} лет выслуги будет {1}", years, income * 0.1);
                     else if (years >= 5 && years < 10)
                         Console.WriteLine("Ваш бонус за {0} лет выслуги будет {1}", years, income * 0.15);
                     else if (years >= 10 && years < 15)
                         Console.WriteLine("Ваш бонус за {0} лет выслуги будет {1}", years, income * 0.25);
                     else if (years >= 15 && years < 20)
                         Console.WriteLine("Ваш бонус за {0} лет выслуги будет {1}", years, income * 0.35);
                     else if (years >= 20 && years < 25)
                         Console.WriteLine("Ваш бонус за {0} лет выслуги будет {1}", years, income * 0.45);
                     else if (years >= 25)
                         Console.WriteLine("Ваш бонус за {0} лет выслуги будет {1}", years, income * 0.50);*/
                }
                else Console.WriteLine("You entered incorrect data");
            }
            else
                Console.WriteLine("You entered incorrect data");

            Console.ReadKey();
        }
    }
}
