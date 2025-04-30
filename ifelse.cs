using System;

namespace Csharp
{

    public class Ifelse
    {

        public static void Exe()
        {

            int Temp;

            Console.WriteLine("digite a Temperatura: ");

            Temp = int.Parse(Console.ReadLine());

            if (Temp < 10)
            {

                Console.WriteLine("Muito Frio");

            }
            else if (Temp >= 10 && Temp <= 25)
            {

                Console.WriteLine("Temperatura ambiente");

            }
            else
            {

                Console.WriteLine("Muito Quente");
            }

            //teste

            //Console.WriteLine(Temp);

        }


    }


}