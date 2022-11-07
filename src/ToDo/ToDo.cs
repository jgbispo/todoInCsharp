namespace ToDoSpace
{
  class ToDo
  {
    // Properties
    private string? name;
    private string? description;
    private List<Item> items;

    // Constructor
    public ToDo(string name, string description)
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

    public bool ExistItem(string name)
    {
      return items.Exists(x => x.Name == name);
    }

    public List<Item> GetItems()
    {
      return items;
    }

    // Getters and Setters
    public string? Name { get; set; }
    public string? Description { get; set; }

  }
}