
using task.Services.IServices;

namespace task.Services
{
    public class CalculatorService : ICalculatorService
    {

        public void Calculator()
        {
            Console.WriteLine("1-calculator metodu islesin");
            Console.WriteLine("0-calculator sonlansin");
            int Deyer = int.Parse(Console.ReadLine());

            while (Deyer != 0)
            {
                if(Deyer == 1)
                {
                    Console.WriteLine("Num1 daxil edin:");
                    int Num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Num2 daxil edin:");
                    int Num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Symbol(+,-,*,/) daxil edin:");
                    string symbol = Console.ReadLine();
                    int result = 0;

                    switch (symbol)
                    {
                        case "+":
                            result = Num1 + Num2;
                            Console.WriteLine("Addition:" + result);
                            break;
                        case "-":
                            result = Num1 - Num2;
                            Console.WriteLine("Subtraction:" + result);
                            break;
                        case "*":
                            result = Num1 * Num2;
                            Console.WriteLine("Multiplication:" + result);
                            break;
                        case "/":
                            result = Num1 / Num2;
                            Console.WriteLine("Division:" + result);
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            //burda sehv symbol daxil etdikde evvele qayidir
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("1 veya 0 daxil edin!");
                }
                Console.WriteLine("1-calculator metodu islesin");
                Console.WriteLine("0-calculator sonlansin");
                Deyer = int.Parse(Console.ReadLine());
            }
        }
    }
}
