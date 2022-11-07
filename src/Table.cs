namespace src
{
  class Table
  {
    // Matriz de strings
    private string[,] table;

    // Constructor
    public Table(int rows)
    {
      table = new string[rows, 3];
    }
    // Methods
    public void ShowTable(Item item)
    {
      Console.WriteLine("Name\tDescription\tIs Complete");
      for (int i = 0; i < table.GetLength(0); i++)
      {
        for (int j = 0; j < table.GetLength(1); j++)
        {
          Console.Write($"{table[i, j]}");
        }
        Console.WriteLine();
      }
    }

    public void AddItem(List<Item> toDo, int row)
    {
      table[row, 0] = toDo[row].Name! + "\t";
      table[row, 1] = toDo[row].Description! + "\t";
      table[row, 2] = toDo[row].IsComplete.ToString();
    }
  }
}