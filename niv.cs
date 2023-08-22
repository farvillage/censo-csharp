using System;

namespace Leveling {
    enum Sex {
        M,
        F
    }

    public class Person {
        double height;
        double maxHeight;
        double minHeight;
        double averageHeight;
        int women;
        int men;
    }

    class Program {
        static void Main(string[] args) {
            List<Person> personList = new List<Person>();

            Sex inputSex = Sex.M | Sex.F;
            Console.WriteLine(inputSex);

            for (int i = 0; i < 15; i++) {
                Console.Write("Input your height: ");
                double height = Double.Parse(Console.ReadLine());
                Console.Write("Input your sex (M or F): ");
                string sex = Console.ReadLine();

                personList.Add(new Person { height = height });

              if (minHeight >= height) {
                Console.WriteLine("");
              }
              
              if (maxHeight > height) {
                Console.WriteLine("Cursilho");
              }  

              if (Sex.ToLower("F")) {
                women++;
              }

              if (Sex.ToLower("M")) {
                men++;
                averageHeight += height;
                averageHeight = averageHeight / men;
              }
            }

          Console.ReadLine("This is the current amount of" + women);
          Console.ReadLine("The maximum height was" + maxHeight);
          Console.ReadLine("The mininum height was" + minHeight);
          Console.ReadLine("The average height was" + averageHeight);
    }
}
