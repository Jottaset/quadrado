using System;

namespace Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
           Quadrado quadrado = new Quadrado();

            Console.WriteLine("Digite um valor para para o lado 1: ");
            //quadrado.defineValorLado1 (Int32.Parse(Console.ReadLine()));

            /*Console.WriteLine("Digite um valor para para o lado 2: ");
            quadrado.defineValorLado2 (Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Digite um valor para para o lado 3: ");
            quadrado.defineValorLado3 (Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Digite um valor para para o lado 4: ");
            quadrado.defineValorLado4 (Int32.Parse(Console.ReadLine()));*/

            string texto;
            int valor = Int32.Parse(Console.ReadLine());

            if (valor >= 5){
                quadrado.defineValorLado1(valor);
                texto = "Deu certo e o valor definido foi: " + quadrado.getValor1();
            }
            else{
                texto = "Nao deu certo e o valor foi: " + quadrado.getValor1();
            }

            Console.WriteLine(texto);

        }
    }
}
