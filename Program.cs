using ToDoSpace;
using Screens;
namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a new Controller
      Controller c = new Controller();

      // Create a new ToDo
      ToDo t = CreateToDo.CreateToDoScreen(c);

      // Add the ToDo to the Controller
      c.AddToDo(t);

      // Create a new Item
      Item i = CreateItem.CreateItemScreen(t);

      // Add the Item to the ToDo
      t.AddItem(i);
    }
  }
}