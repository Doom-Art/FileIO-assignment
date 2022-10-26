using System.Text;

namespace FileIO_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EventScore> listEvent= new List<EventScore>();
            int count = 0;
            if (File.Exists(@"results.txt")){
                string name = "";
                string eventName = "";
                double score = 0;
                foreach (string i in File.ReadLines(@"results.txt", Encoding.UTF8))
                {
                    if (count == 0){
                        name = i;
                        count++;
                    }
                    else if (count == 1){
                        eventName = i;
                        count++;
                    }
                    else{
                        while (double.TryParse(i, out double tempScore))
                        {
                            score += tempScore;
                        }
                        listEvent.Add(new EventScore(name, eventName, score));
                        name = "";
                        eventName = "";
                        score = 0;
                        count = 0;
                    }
                }
                foreach( EventScore i in listEvent)
                {
                    Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("error, File not found");
        }
    }
}