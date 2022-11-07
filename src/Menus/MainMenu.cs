using controllers;
using database;

namespace src.menus
{
    public class MainMenu
    {
        public static void ShowMainMenu(Database db)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the ToDo App!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create a new ToDo");
            Console.WriteLine("2. Show all ToDos");
            Console.WriteLine("3. Remove a ToDo");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter the number of your choice:");
            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    ToDo toDo = Controller.CreateToDo();
                    toDo.AddItem(Controller.CreateItem());
                    Controller.AddToDoToList(db, toDo);
                    break;
                case "2":
                    Controller.ShowToDoList(db);
                    break;
                case "3":
                    Controller.RemoveToDoFromList(db);
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowMainMenu(db);
                    break;
            }
        }
    }
}