using ToDoSpace;

namespace Screens
{
  class ShowToDo
  {
    public static void ShowToDos(Controller c)
    {
      // Show all the ToDos
      Console.WriteLine("ToDos:");
      foreach (ToDo t in c.GetToDos())
      {
        Console.WriteLine(t.Name);
      }
      Utils.Pause();

    }
  }
}