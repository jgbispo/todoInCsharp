namespace ToDo
{
  class Item
  {
    // Properties
    private string? name;
    private string? description;
    private bool _isComplete;

    // Constructor
    public Item(string name, string description)
    {
      this.name = name;
      this.description = description;
      _isComplete = false;
    }

    // Getters and Setters
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsComplete { get; set; }
  }
}