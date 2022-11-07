namespace src
{
  class ToDo
  {
    // properties
    private List<Item> toDo;
    private string name;
    private string description;

    // constructor
    public ToDo(string name, string description)
    {
      this.name = name;
      this.description = description;
      this.toDo = new List<Item>();
    }

    // Methods
     public void AddItem(Item item)
    {
      toDo.Add(item);
    }

    public void RemoveItemByName(string name)
    {
      for (int i = 0; i < toDo.Count; i++)
      {
        if (toDo[i].Name == name)
        {
          toDo.RemoveAt(i);
        }
      }
    }

    public void FindItemByName(string name)
    {
      foreach (Item item in toDo)
      {
        if (item.Name == name)
        {
          item.ShowItem();
        }
      }
    }

    public void ShowToDo()
    {
      Table table = new Table(toDo.Count);
      for (int i = 0; i < toDo.Count; i++)
      {
        table.AddItem(toDo, i);
      }
      table.ShowTable();
    }

    // Getters and Setters
    public List<Item> Items
    {
      get { return this.toDo; }
    }

    public string Name
    {
      get { return this.name; }
      set { this.name = value; }
    }

    public string Description
    {
      get { return this.description; }
      set { this.description = value; }
    }

  }
}