namespace src
{
  class Item
  {
    // properties
    private string? name;
    private string? description;
    private bool isComplete;


    // constructor
    public Item(string name, string description)
    {
      this.name = name;
      this.description = description;
      this.isComplete = false;
    }

    // Methods
    public void ShowItem()
    {
      Console.WriteLine($"Name: {this.name}");
      Console.WriteLine($"Description: {this.description}");
      Console.WriteLine($"Is Complete: {this.isComplete}");
    }

    // Getters and Setters
    public string? Name
    {
      get { return this.name; }
      set { this.name = value; }
    }

    public string? Description
    {
      get { return this.description; }
      set { this.description = value; }
    }

    public bool IsComplete
    {
      get { return this.isComplete; }
      set { this.isComplete = value; }
    }

  }
}