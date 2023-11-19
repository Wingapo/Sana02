internal class Program
{
    private static void Main(string[] args)
    {
        int[] points;

        Console.WriteLine("Enter student's points:");
        while (true)
        {
            try
            {
                Console.Write(">> ");
                points = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input data");
            }
        }
        Console.WriteLine("Student is {0}admitted to the exam", (points.Average() >= 50) ? "" : "not ");
    }
}