namespace TesteEasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Easy Test!");
            Console.WriteLine("Resultado "+Solution.DetectCapitalUse("USA"));
            Console.WriteLine("Resultado "+Solution.DetectCapitalUse("ResultadO"));
            Console.WriteLine("Resultado "+Solution.DetectCapitalUse("Rafael"));
            Console.ReadKey(true);
        }
    }
}