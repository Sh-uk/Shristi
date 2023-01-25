using System;
using System.Text;
using System.Threading.Tasks;
namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            Console.Write("Enter First Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Symbol (/,+,-,*): ");
            string symbol = Console.ReadLine(); switch (symbol)
            {
                case "+":
                    res = n1 + n2;
                    Console.WriteLine("Addition: " + res);
                    break;
                case "-":
                    res = n1 - n2;
                    Console.WriteLine("Subtraction: " + res);
                    break;
                case "*":
                    res = n1 * n2;
                    Console.WriteLine("Multiplication: " + res);
                    break;
                case "/":
                    res = n1 / n2;
                    Console.WriteLine("Division: " + res);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            Console.ReadLine();
        }
    }
}