internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 5;
        Console.WriteLine(num1 + num2);
        Console.WriteLine(num1 - num2);
        Console.WriteLine(num1 * num2);
        Console.WriteLine(num1 / num2);
        Console.WriteLine(num1 % num2);

        int num = 5;
        Console.WriteLine(num * num);

        int num3 = 10;
        int num4 = 20;
        Console.WriteLine((num3 + num4) / 2);

        int num5 = 10;
        int num6 = 20;
        int num7 = 30;
        Console.WriteLine((num5 + num6 + num7) / 3);

        double celsius = 20;
        Console.WriteLine("Fahrenheit: " + (celsius * 9 / 5 + 32));

        double length = 10;
        double width = 5;
        Console.WriteLine("Area of a rectangle is: " + length * width);

        double radius = 5;
        const double PI = 3.14159;
        Console.WriteLine("Volume: " + 4 / 3 * PI * Math.Pow(radius, 3));

        int number = 5;
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("The factorial of 5 is: " + factorial);

        double principal = 1000;
        double rate = 0.05;
        int time = 5;
        double compound_interest = principal * Math.Pow(1 + rate, time);
        Console.WriteLine("Compound interest is: " + compound_interest);

        double a = 1;
        double b = 5;
        double c = 6;
        double delta = b * b - 4 * a * c;

        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine($"The result of x1 and x2 is: x1 = {x1} and x2 = {x2}");

        int n = 8;
        Console.WriteLine("Here is Fibonacci sequences: ");
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine($"F{i} = {Fibonacci(i)}");
        }

        Console.WriteLine("The nth Term is: ");
        int termNumber = 5;
        int firstTerm = 3;
        int commonDifference = 2;
        int nthTerm = firstTerm + (termNumber - 1) * commonDifference;
        Console.WriteLine(nthTerm); 

        int number1 = 10;
        int number2 = 5;
        Console.WriteLine(number1 > number2);

        Console.WriteLine("Enter the number you want: ");
        int thisNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(thisNumber <= 100);

        Console.WriteLine("Please enter the number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(inputNumber % 2 == 0 && inputNumber > 10);

        inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(inputNumber % 3 == 0 || inputNumber % 5 == 0);

        inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Before using shorthand assignment: ");
        Console.WriteLine(inputNumber);
        inputNumber += 5;
        Console.WriteLine("After using shorthand assignment: ");
        Console.WriteLine(inputNumber);

        int number3 = 27;
        Console.WriteLine(number3 %= 7);
    }

    public static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
