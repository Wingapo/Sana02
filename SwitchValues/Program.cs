using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string output = "";
        int digit = 0;

        Console.WriteLine("Введіть цифру: ");
        while (true)
        {
            try
            {
                Console.Write(">> ");
                digit = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Неправильні вхідні дані");
            }
        }
        switch (digit)
        {
            case 1: output = "Один"; break;
            case 2: output = "Два"; break;
            case 3: output = "Три"; break;
            case 4: output = "Чотири"; break;
            case 5: output = "П'ять"; break;
            case 6: output = "Шість"; break;
            case 7: output = "Сім"; break;
            case 8: output = "Вісім"; break;
            case 9: output = "Дев'ять"; break;
            case 0: output = "Нуль"; break;
            default: output = "Число не належить діапазону [0, 9]"; break;
        }
        Console.WriteLine(output);
    }
}