namespace ConsoleApp1
{
    internal class Program
    {
        static void log(string text)
        {
            Console.WriteLine(text);
        }

        static void operation1(string operation, int firstNum, int secondNum)
        {
            if (operation == "+")
            {
                int sum = secondNum + firstNum;
                Console.WriteLine("Sum:" + sum);
            }

            else if (operation == "*")
            {
                int multiplication = secondNum * firstNum;
                Console.WriteLine("multiplication:" + multiplication);
            }
            else if (operation == "-")
            {
                int subtraction = firstNum - secondNum;
                Console.WriteLine("subtraction:" + subtraction);
            }
            else if (operation == "/")
            {
                int division = firstNum / secondNum;
                Console.WriteLine("division:" + division);
            }

        }
        
        static void Main(string[] args)
        {
            log("Please enter two numbers with space:");
            string[] numbers = Console.ReadLine().Split(' ');
             int firstNum = Convert.ToInt32(numbers[0]), secondNum = Convert.ToInt32(numbers[1]);
            log("Choose an operation:(+,-,*,/)");
            string operation = Console.ReadLine();
            operation1(operation, firstNum, secondNum);
            
        }
    }
}
