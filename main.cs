using System;
using System.ComponentModel.DataAnnotations;

public class Program
{
  public static void Main(string[] args)
  {
    int addHeight = 0;
    double averageHeight = 0;
    int countM = 0;
    int countF = 0;
    int maxHeight = 0;
    int minHeight = 300;

    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine("Input your sex (M or F): ");
      string inputSex = Console.ReadLine();

      Console.WriteLine("Input your height (cm): ");
      string inputHeight = Console.ReadLine();

      int input = int.Parse(inputHeight);

      Person person = new Person(inputSex, input);

      if (person.height > maxHeight)
      {
        maxHeight = person.height;
      }
      if (person.height < minHeight)
      {
        minHeight = person.height;
      }

      if (person.sex == "m")
      {
        countM =+ 1;
        addHeight = person.height + addHeight;
      }

      if (person.sex == "f")
      {
        countF =+ 1;
      }
    }
    averageHeight = addHeight / countM;

    Console.WriteLine("The quantity of men is " + countM);
    Console.WriteLine($"The min and max men's height is {minHeight} {maxHeight}");
    Console.WriteLine("The quantity of women is " + countF);
    Console.WriteLine("The average of men's height is " + averageHeight);
  }
}

public class Person
{
  public String sex;
  public int height;

  public Person(String sex, int height)
  {
    this.sex = sex;
    this.height = height;
  }
}