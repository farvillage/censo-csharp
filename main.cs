using System;

 public class Program
 {
   public static void Main(string[] args)
   {
    
    for(int i = 0; i < 3; i++)
    {
      string femaleCounter;
      string inputSex;
      Console.WriteLine("Input your sex (M or F): ");
      string inputSex = Console.ReadLine();
      inputSex = femaleCounter;
      count1++;
        
      Console.WriteLine("Input your height (cm): "); 
      string inputHeight = Console.ReadLine();

      int input = int.Parse(inputHeight);
      
      Person person = new Person(inputSex, inputHeight);
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

      Console.WriteLine("The average height is" + person.height); //altura média
      Console.WriteLine("The quantity of women is " + ); //quantas mulheres
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
