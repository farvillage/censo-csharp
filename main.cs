using System;

 public class Program
 {
   public static void Main(string[] args)
   {
    for(int i = 0; i < 3; i++)
    {
      Console.WriteLine("Input your sex (M or F): ");
      string inputSex = Console.ReadLine();
        
      Console.WriteLine("Input your height (cm): "); 
      string inputHeight = Console.ReadLine();

      int input = int.Parse(inputHeight);
      
      Person person = new Person(inputSex, input);
      int maxHeight = 0;
      int minHeight = 0;
      
      if(inputSex.ToLower().StartsWith("f"))
      {
        if(person.height > maxHeight)
        {
          maxHeight = person.height;
        }
        if(person.height < minHeight)
        {
          minHeight = person.height;
        }
        if(person.sex == "f")
        {
          int count =+ 1;
        }

      Console.WriteLine(" "); //altura média
      Console.WriteLine(" "); //quantas mulheres
      }
    }
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
