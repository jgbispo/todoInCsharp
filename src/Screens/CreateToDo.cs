using System;
using ToDoSpace;

namespace Screens
{
  class CreateToDo
  {
    public static ToDo CreateToDoScreen(Controller c)
    {
      // Create ToDo object 
      string? name;
      bool isNameOk = false;
      do
      {
        Console.WriteLine("Enter the name of the ToDo:");
        name = Console.ReadLine();
        isNameOk = VerifyExistToDo(name!, c);
      } while (!isNameOk);
      Console.WriteLine("Enter the description of the ToDo:");
      string? description = Console.ReadLine();

      // Create a new ToDo
      ToDo toDo = new ToDo(name!, description!);
      // return toDo;
      return toDo;
    }

    private static bool VerifyExistToDo(string name, Controller c)
    {
      // Verify if the ToDo exists
      if (c.ExistToDo(name))
      {
        Console.WriteLine("The ToDo already exists");
        Utils.Pause();
        return false;
      }
      return true;
    }
  }
}