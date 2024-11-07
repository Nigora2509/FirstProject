namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sonni kiriting :");
            var number = Convert.ToInt32(Console.ReadLine());
            var thousand = number / 1000;
            var hundred = number % 1000 / 100;
            var tens = number % 1000 % 100 / 10;
            var ones = number % 10;
            var result = thousand + hundred + tens + ones;
            Console.WriteLine(result);
        }
    }
}
