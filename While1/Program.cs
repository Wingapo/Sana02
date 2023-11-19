internal class Program
{
    private static void Main(string[] args)
    {
        int index;

        Console.WriteLine("Enter index of progression element:");
        while (true)
        {
            try
            {
                Console.Write(">> ");
                index = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input data");
            }
        }

        Console.WriteLine("Sum of progression 1 elements: {0:F3}", func1(index));
        Console.WriteLine("Sum of progression 2 elements: {0:F3}", func2(index));
        Console.WriteLine("Sum of progression 3 elements: {0}", func3(index));
    }

    private static double func1(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(-1, i) / (2 * i + 1);
        }
        return sum;
    }

    private static double func2(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1 + 1 / Math.Pow(i, 2);
        }
        return sum;
    }

    private static int func3(int n)
    {
        int sum = 0;
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += fact *= i;
        }
        return sum;
    }
}