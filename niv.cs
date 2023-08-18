namespace Nivelamento {

    class Pessoa {
        double altura;
        bool H = true;


        static void Main(string[] args) {

            List<Pessoa> pessoa = new List<string>();

            for (int i = 0; i < 15; i++) {
                Console.Write("Informe sua altura: ");
                double altura = Double.Parse(Console.ReadLine());
                Console.Write("Informe seu gênero (H ou M): ");
                string genero = String.Parse(Console.ReadLine());
                pessoa.Add(altura, genero);

                string[] pessoa = {"altura", "genero"};
                foreach (Pessoa i in pessoa) {
                    Console.WriteLine(i);
                }
            
            if (pessoa.genero == "H") {
                for (Pessoa = )
                }
            }
        }
    }
}