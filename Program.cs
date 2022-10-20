using System.Text;

namespace FileIO_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string line in File.ReadLines(@"results.txt", Encoding.UTF8))
            {
                Console.WriteLine(line);
            }
        }
    }
}