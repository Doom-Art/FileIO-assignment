using System.Text;

namespace FileIO_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            foreach (string line in File.ReadLines(@"test.txt", Encoding.UTF8))
            {
                words.Add(line.ToUpper());
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}