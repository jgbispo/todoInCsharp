using System;

namespace ToDo
{
  class Controller
  {
    // Properties
    private List<ToDo> toDos;

    // Constructor
    public Controller()
    {
      toDos = new List<ToDo>();
    }

    // Methods
    public void AddToDo(ToDo toDo)
    {
      toDos.Add(toDo);
    }

    public void RemoveToDo(ToDo toDo)
    {
      toDos.Remove(toDo);
    }

    public void CompleteItem(ToDo toDo, Item item)
    {
      toDo.CompleteItem(item);
    }

    public ToDo? GetToDo(string name)
    {
      foreach (ToDo toDo in toDos)
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