using src;
using database;

namespace controllers
{
  class Controller
  {
    public static Item CreateItem()
    {
      Console.Clear();
      Console.WriteLine("Enter the name of the item:");
      string name = Console.ReadLine()!;
      Console.WriteLine("Enter the description of the item:");
      string description = Console.ReadLine()!;
      Item item = new Item(name, description);
      return item;
    }

    public static ToDo CreateToDo()
    {
      Console.Clear();
      Console.WriteLine("Enter the name of the ToDo:");
      string name = Console.ReadLine()!;
      Console.WriteLine("Enter the description of the ToDo:");
      string description = Console.ReadLine()!;
      ToDo toDo = new ToDo(name, description);
      return toDo;
    }

    public static void ShowToDoList(Database database)
    {
      database.ShowToDoList();
    }

    public static void AddToDoToList(Database database, ToDo toDo)
    {
      database.AddToDo(toDo);
    }

    public static void RemoveToDoFromList(Database database)
    {
      Console.WriteLine("Enter the name of the ToDo you want to remove:");
      string name = Console.ReadLine()!;
      database.RemoveToDoByName(name);
    }

  }
}