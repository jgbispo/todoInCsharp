namespace Screens
{
  public static class Utils
  {
    public static void Pause()
    {
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }

    public static void Clear()
    {
      Console.Clear();
    }
  }
}