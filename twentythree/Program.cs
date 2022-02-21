using static System.Console;

namespace twentythree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
      Mark: Write("Enter the n: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0) throw new Exception("Error of innput data!");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                goto Mark;
            }

            FactAsync(n);

            Console.ReadKey();
        }

        static void Fact(int n)
        {
            int f = 1;
            for (int i = 1; i < n+1; i++)
            {
                f *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine($"(Factorial) n! = {f}");
        }

        static async void FactAsync(int n)
        {
            await Task.Run(() => Fact(n));
        }

    }
}