
using System;

namespace Csharp
{
    public class Matematica
    {
        public static void Teste()
        {
            // Console.WriteLine("Digite um Numero");
            // int num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Digite o Segundo Numero");
            // int num2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Digite o Terceiro Numero");
            // int num3 = int.Parse(Console.ReadLine());

            int num1 = LerNumero("Digite um Numero");
            int num2 = LerNumero("Digite o Segundo Numero");
            int num3 = LerNumero("Digite o Terceiro Numero");

            int soma = num1 + num2 + num3;

            Console.WriteLine("a soma dos 3 numeros é: " + soma);

        }

        private static int LerNumero(String mensagem)
        {

            int numero;
            while (true)
            {

                Console.WriteLine(mensagem);
                if (int.TryParse(Console.ReadLine(), out numero))
                    return numero;

                Console.WriteLine("Valor Inválido, Tente Novamente");




            }



        }
    }

}