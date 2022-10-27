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
                        name = i.Trim();
                        count++;
                    }
                    else if (count == 1){
                        eventName = i.Trim();
                        count++;
                    }
                    else if(count < 6){
                        double.TryParse(i.Trim(), out double tempScore);
                        score += tempScore;
                        count++;
                    }
                    else
                    {
                        double.TryParse(i.Trim(), out double tempScore);
                        score += tempScore;
                        listEvent.Add(new EventScore(name, eventName, Math.Round(score,2)));
                        name = "";
                        eventName = "";
                        score = 0;
                        count = 0;
                    }
                }
            }
            else
                Console.WriteLine("error, File not found");
            int choice = 0;
            while (choice != 4)
            {
                Console.Clear();
                Console.WriteLine("Here is the HangMan Lite menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Print the scores");
                Console.WriteLine("2 - Print the highest score");
                Console.WriteLine("3 - Print the lowest score");
                Console.WriteLine("4 - Quit");
                Int32.TryParse(Console.ReadLine(), out choice);

                if (choice == 1){
                    foreach (EventScore i in listEvent)
                    {
                        Console.WriteLine("\n" + i);
                    }
                    Console.WriteLine("\nPress enter to return to the main menu");
                    Console.ReadLine();
                }
                else if (choice == 2){
                    double highest = 0;
                    int position = 0;
                    for (int i = 0; i < listEvent.Count; i++)
                    {
                        if (listEvent[i].GetTotalScore > highest){
                            highest = listEvent[i].GetTotalScore;
                            position = i;
                        }
                    }
                    Console.WriteLine(listEvent[position]);
                    Console.WriteLine("Press enter to return to the main menu");
                    Console.ReadLine();
                }
                else if (choice == 3){
                    double lowest = 100;
                    int position = 0;
                    for (int i = 0; i < listEvent.Count; i++)
                    {
                        if (listEvent[i].GetTotalScore < lowest){
                            lowest = listEvent[i].GetTotalScore;
                            position = i;
                        }
                    }
                    Console.WriteLine(listEvent[position]);
                    Console.WriteLine("Press enter to return to the main menu");
                    Console.ReadLine();
                }
                else if (choice == 4)
                    Console.WriteLine("Goodbye");
                else{
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}