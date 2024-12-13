using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Player1");

            Console.WriteLine("Welcome to Eternal Quest!");
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create new Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                        Console.Write("Choose goal type: ");
                        int goalType = int.Parse(Console.ReadLine());
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal description: ");
                        string desc = Console.ReadLine();
                        Console.Write("Enter points: ");
                        int points = int.Parse(Console.ReadLine());

                        if (goalType == 1)
                            user.AddGoal(new SimpleGoal(name, desc, points));
                        else if (goalType == 2)
                            user.AddGoal(new EternalGoal(name, desc, points));
                        else if (goalType == 3)
                        {
                            Console.Write("Enter target count: ");
                            int target = int.Parse(Console.ReadLine());
                            Console.Write("Enter bonus points: ");
                            int bonus = int.Parse(Console.ReadLine());
                            user.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                        }
                        break;

                    case 2:
                        Console.Write("Enter goal name to record: ");
                        string goalName = Console.ReadLine();
                        user.ShowGoals();
                        break;

                    case 3:
                        user.ShowGoals();
                        break;

                    case 4:
                        Console.Write("Enter filename to save: ");
                        string saveFile = Console.ReadLine();
                        user.SaveToFile(saveFile);
                        break;

                    case 5:
                        Console.Write("Enter filename to load: ");
                        string loadFile = Console.ReadLine();
                        user.LoadFromFile(loadFile);
                        break;

                    case 6:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
