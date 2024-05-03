namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
            Console.WriteLine("enter first number");
           string strNum1 = Console.ReadLine();

            double num1;
            if (double.TryParse(strNum1, out num1))
            {
                Console.WriteLine("enter operation");
                string operation = Console.ReadLine();

                Console.WriteLine("enter second number");
                string strNum2 = Console.ReadLine();

                double num2;
                if (double.TryParse(strNum2, out num2))
                {
                  //  Console.Write("result is : ");

                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine($"result is :  {num1 + num2}");
                            break;

                        case "-":
                            Console.WriteLine($"result is :  {num1 - num2}");
                            break;

                        case "*":
                            Console.WriteLine($"result is :  {num1 * num2}");
                            break;

                        case "/":
                            Console.WriteLine($"result is :   {num1 / num2}");
                            break;

                        default:
                           // Console.Clear();
                            Console.WriteLine($"there is no operand called {operation}");
                            break;

                    }
                }

                else
                {
                    Console.WriteLine("invalid data, you have to enter number");
                }

            }
            else
            {
                Console.WriteLine("invalid data, you have to enter number");
            }

        }
    }
}
