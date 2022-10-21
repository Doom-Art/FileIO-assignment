using System.Text;

namespace FileIO_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            int count = 0;
            if (File.Exists(@"test.txt"))
            {
                foreach (string line in File.ReadLines(@"test.txt", Encoding.UTF8))
                {
                    words.Add(line.ToUpper());
                }
                words.Add("HELLO HUMAN    ");
                foreach (string i in words)
                {
                    count ++;
                    Console.WriteLine(i);
                    foreach (char c in i.Trim())
                    {
                        if (c == ' ')
                            count++;
                    }
                }
                Console.WriteLine($"The list has {count} words");
            }
            else
                Console.WriteLine("error");
            StreamWriter writer = new StreamWriter("capitals.txt");
            foreach (string i in words)
                writer.WriteLine(i);
            writer.Close();
        }
    }
}