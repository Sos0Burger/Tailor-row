
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double initialX, endX, epsilon;
        do
        {
            Console.WriteLine("Введите начальное значение X");
            initialX = Convert.ToDouble(Console.ReadLine());
        } while (initialX <= 1 / 2);

        do {
            Console.WriteLine("Введите конечное значение X");
            endX = Convert.ToDouble(Console.ReadLine());
        }while(endX <= 1 / 2);
        do
        {
            Console.WriteLine("Введите точность");
            epsilon = Convert.ToDouble(Console.ReadLine());
        }while(epsilon>=1||epsilon<=0);
        tailorRow(initialX, endX, epsilon);
    }

    private static void tailorRow(double initialX, double endX, double epsilon)
    { 
        double sum = 0;
        double n = 0;
        double an = (initialX - 1) / (initialX + 1);
        Console.WriteLine($"Значение X: {an}\tЗначение функции: {sum}\tКоличество просуммированных аргументов: {n}");
        while (an <= endX)
        { 
            sum += an;
            n++;
            an = (Math.Pow(an - 1, n + 1))
                / ((n + 1) * Math.Pow(an + 1, n + 1));
            Console.WriteLine($"Значение X: {an}\tЗначение функции: {sum}\tКоличество просуммированных аргументов: {n}");

            if (Math.Abs(an) <= epsilon) break;
        }
        Console.WriteLine(sum);

    } 
}