using ToDoSpace;

namespace Screens
{
  class CreateItem
  {
    public static Item CreateItemScreen(ToDo t)
    {
      // Create Item object 
      Console.WriteLine("Enter the name of the Item:");
      string? name = Console.ReadLine();
      Console.WriteLine("Enter the description of the Item:");
      string? description = Console.ReadLine();

      // Create a new Item
      Item item = new Item(name!, description!);
      // return item;
      return item;
    }

    public bool VerifyItemExist(string name, ToDo t)
    {
      // Verify if the Item exists
      if (t.ExistItem(name))
      {
        Console.WriteLine("The Item already exists");
        Utils.Pause();
        return false;
      }
      return true;
    }
  }
}