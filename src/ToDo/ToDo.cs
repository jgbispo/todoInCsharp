namespace ToDo
{
  class ToDoList
  {
    // Properties
    private string? name;
    private string? description;
    private List<Item> items;

    // Constructor
    public ToDoList(string name, string description)
    {
      this.name = name;
      this.description = description;
      items = new List<Item>();
    }

    // Methods
    public void AddItem(Item item)
    {
      items.Add(item);
    }

    public void RemoveItem(Item item)
    {
      items.Remove(item);
    }
    
    public void CompleteItem(Item item)
    {
      item.IsComplete = true;
    }

  }
}