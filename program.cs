using System

namespace Censo 
{
  class Program
  {
    static void Main(string args[])
    {
      for(int i = 0; i < 15; i++)
      {
        Console.WriteLine("Input your sex (M or F): ");
        string.inputSex = Console.ReadLine();
        
        Console.WriteLine("Input your height (cm): ");
        string inputHeight = Console.ReadLine();

        string height = int.Parse(inputHeight);
      }

      if()
    }
  }

  class Person
  {
    int maxHeight;
    int minHeight;
    int averageHeight;
    int women;
    int men;

    public Person(int maxHeight, int minHeight, int averageHeight, int women, int men);
    {
    this.maxHeight = maxHeight;
    this.minHeight = minHeight;
    this.averageHeight = averageHeight;
    this.women = women;
    this.men = men;
    }
  }
}
