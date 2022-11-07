using System;

namespace ToDoSpace
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

    public List<ToDo> GetToDos()
    {
      return toDos;
    }

    public List<ToDo> GetToDo(string name)
    {
      return toDos.FindAll(x => x.Name == name);
    }

    public bool ExistToDo(string name)
    {
      return toDos.Exists(x => x.Name == name);
    }
  }
}