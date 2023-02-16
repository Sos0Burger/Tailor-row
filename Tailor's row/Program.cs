
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        double x;
        int n;
        do
        {
            Console.WriteLine("Введите X");
            x = Convert.ToDouble(Console.ReadLine());
        } while (x <= 1 / 2);
        Console.WriteLine("Введите количество повторений");
        n = Convert.ToInt32(Console.ReadLine());
        tailorRow(x,n);
    }

    private static void tailorRow(double x, int n)
    { 
        double sum = 0;
        double an = (x - 1) / (x + 1);
        Console.WriteLine($"Значение X: {x}\tЗначение функции: {an}\tКоличество просуммированных аргументов: {0}");
        for (int i = 1; i < n;i++){ 
            an = (Math.Pow(x - 1, n + 1))
                / ((n + 1) * Math.Pow(x + 1, n + 1));
            sum += an;
            Console.WriteLine($"Значение X: {x}\tЗначение функции: {an}\tКоличество просуммированных аргументов: {i}");
        }
    } 
}