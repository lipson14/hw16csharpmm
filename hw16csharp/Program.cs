namespace hw16csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            Dictionary<string, int> studentScores = new Dictionary<string, int>();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine("1 - add student");
                Console.WriteLine("2 - search student");
                Console.WriteLine("3 - update the score");
                Console.WriteLine("4 - show all students");
                Console.WriteLine("0 - log out");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    
                    Console.WriteLine("Nmae:");
                    string name = Console.ReadLine();

                    if (studentScores.ContainsKey(name))
                    {
                        Console.WriteLine("name is taken");
                    }
                    else
                    {
                        Console.WriteLine("score:");

                        if (int.TryParse(Console.ReadLine(), out int score))
                        {
                            students.Add(name);
                            studentScores.Add(name, score);
                        }
                        else
                        {
                            Console.WriteLine("score must be a number");
                        }
                    }
                }
                else if (choice == "2")
                {
                 
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();

                    if (studentScores.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} - {studentScores[name]}");
                    }
                    else
                    {
                        Console.WriteLine("Student could not be seen");
                    }
                }
                else if (choice == "3")
                {
                  
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();

                    if (studentScores.ContainsKey(name))
                    {
                        Console.WriteLine("new score:");

                        if (int.TryParse(Console.ReadLine(), out int newScore))
                        {
                            studentScores[name] = newScore;
                        }
                        else
                        {
                            Console.WriteLine("score must be a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("student could not be seen");
                    }
                }
                else if (choice == "4")
                {
                   
                    foreach (var item in students)
                    {
                        Console.WriteLine($"{item} - {studentScores[item]}");
                    }
                }
                else if (choice == "0")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
