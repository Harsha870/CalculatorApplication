using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo choice;
           double pnum=1;
           
            float answer;
            

            Console.WriteLine("\t\t\tCalculator Application\n");
            while (true)
            {
                Console.Write("Please enter the first integer: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                

                Console.Write("Please enter an operand ('+','-','/', '*','%' for Modulus,'p' for Percentage,'s' for Square Root,'w' for power): ");
                operand = Console.ReadLine();
                

                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            
                if (operand=="+")
                    {
                     answer=num1+num2;
                     Console.Write(answer);
                    }
                if (operand=="-")
                    {
                     answer=num1-num2;
                     Console.Write(answer);
                    }
                if (operand=="*")
                    {
                     answer=num1*num2;
                     Console.Write(answer);
                    }
                if (operand=="/")
                    {
                     answer=num1/num2;
                     Console.Write(answer);
                    }
                if (operand=="%")
                    {
                     answer=num1%num2;
                     Console.Write("\n"+answer);
                   
                    }
                if (operand=="w")
                    {
                if (num2 > 0)
            {
                for (int i = num2; i > 0; i--)
                    pnum = pnum * num1;
            }
            else if (num2 < 0)
            {
                for (int i = num2; i < 0; i++)
                    pnum = pnum / num1;
            }
                  Console.WriteLine("{0} Raised to the Power of {1} is {2}", num1, num2, pnum);
                    }
                
                if (operand == "p")
                {
                    answer = ((num1 / 100) * num2);
                    Console.Write("\n"+answer);

                 }  
                if (operand=="s")
                    {
                   double ans = Math.Sqrt(num1);
                    Console.Write(ans);
                    }

                Console.WriteLine("\n\n Do You Want To Continue? Press (Y/N)");
                choice = Console.ReadKey();
                
                Console.Clear();
                }
            }

            

           
        }
    }
    

