    using System;
    namespace AreaTriangulo
    {
        internal class Program
        { 
            static void Main(string[] args)
            {
                double area = 0;
                double alturaTriangulo = 0;
                double baseTriangulo = 0;
                string entrada = "";
                Console.WriteLine("Digite a base");
                entrada = Console.ReadLine();
                baseTriangulo = Convert.ToDouble(entrada);

                Console.WriteLine("Digite a altura!");
                entrada = Console.ReadLine();
                alturaTriangulo = Convert.ToDouble(entrada);

                area = (baseTriangulo * alturaTriangulo) / 2;
                Console.WriteLine($"A área do triângulo é {area}");
                Console.ReadKey();
           

       



            }
        }
    }