using src;
namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Item> toDo = new List<Item>();

      Item i = new Item("name", "description");
      toDo.Add(i);

      i = new Item("name2", "description2");
      toDo.Add(i);

      i = new Item("name3", "description3");
      toDo.Add(i);
      Table t = new Table(toDo.Count);

      Console.WriteLine("List of Items #1:");
      for (int j = 0; j < toDo.Count; j++)
      {
        t.AddItem(toDo, j);
      }
      t.ShowTable(i);

      Console.ReadKey();
      Console.Clear();

      toDo[0].IsComplete = true;

      Console.WriteLine("List of Items #2:");
      for (int j = 0; j < toDo.Count; j++)
      {
        t.AddItem(toDo, j);
      }
      t.ShowTable(i);

    }
  }
}