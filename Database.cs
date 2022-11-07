using src;
namespace database
{
  public class Database
  {
    private List<ToDo> toDoList = new List<ToDo>();

    public void AddToDo(ToDo toDo)
    {
      toDoList.Add(toDo);
    }

    public void ShowToDoList()
    {
      Console.WriteLine($"Name\tDescription\tItems");
      Console.WriteLine("-------------------------------");
      foreach (ToDo toDo in toDoList)
      {
        int count = toDo.Items.Count;
        Console.WriteLine($"{toDo.Name}\t{toDo.Description}\t{count}");
      }
    }

    public void RemoveToDoByName(string name)
    {
      for (int i = 0; i < toDoList.Count; i++)
      {
        if (toDoList[i].Name == name)
        {
          toDoList.RemoveAt(i);
        }
      }
    }

    public ToDo? FindToDoByName(string name)
    {
      foreach (ToDo toDo in toDoList)
      {
        if (toDo.Name == name)
        {
          return toDo;
        }
      }
      return null;
    }
  }
}