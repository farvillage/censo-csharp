namespace Leveling {

    class Person {
        double height;
        enum Sex{
         M,
         F
        }


        static void Main(string[] args) {

            List<Person> person = new List<Person>();

            Sex inputSex= Sex.M | Sex.F;
                Console.WriteLine(inputSex);

            for (int i = 0; i < 15; i++) {
                Console.Write("Input your height: ");
                double height = Double.Parse(Console.ReadLine());
                Console.Write("Input your sex (M or F): ");
                string sex = String.Parse(Console.ReadLine());
                person.Add(height, sex);

                string[] person = {"height", "sex"};
                foreach (Person i in person) {
                    Console.WriteLine(i);
                }
            
            if (person.sex == "M") {
                for (Person = )
                }
            }
        }
    }
}