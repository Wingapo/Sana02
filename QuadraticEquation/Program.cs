internal class Program {
    private static void Main(string[] args) {
        int a, b, c;

        Console.WriteLine("Enter values for quadratic equation coefficients:");
        while (true) {
            try {
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("c = ");
                c = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch {
                Console.WriteLine("Invalid input data");
            }
        }

        if (a == 0) {
            if (b == 0) {
                if (c == 0)
                    Console.WriteLine("Equation has infinite number of solutions");
                else
                    Console.WriteLine("Equation has no solutions");
            } else
                Console.WriteLine("x = {0}", (double)-c / b);
        } else {
            int D = b * b - 4 * a * c;
            Console.WriteLine("D = " + D);

            if (D < 0)
                Console.WriteLine("Equation has no solutions");
            else if (D == 0)
                Console.WriteLine("x = {0}", -Math.Sign(b) * Math.Sqrt(c / a));
            else {
                Console.WriteLine("x1 = {0}", (-b + Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("x2 = {0}", (-b - Math.Sqrt(D)) / (2 * a));
            }
        }
    }
}