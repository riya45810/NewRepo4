namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: "); 
            
            string name = Console.ReadLine(); // comment
            string rev = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                rev += name[i];//comment
            }

            Console.WriteLine($"Reverse string is {rev}");



        }
    }
}