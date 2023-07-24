using System;

namespace TPFinal_Avero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta 
            // cuando se ingresa un cero. A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado 
            // es primo o no y que devuelva true o false según corresponda.
            
            int n, indice = 0, mayorPar = 0, cantImpar = 0, menorPrim = 0;
            int[] numeros = new int[20];

            Console.WriteLine("Ingresa un número: (presiona 0 para cortar)");
            n = int.Parse(Console.ReadLine());

            while (n != 0 && indice < 20)
            {   
                if (primo(n) && menorPrim == 0)
                {
                    menorPrim = n;
                } else if (primo(n) && n < menorPrim)
                {
                    menorPrim = n;
                }

                if (par(n) == 2 && n > mayorPar)
                {
                    mayorPar = n;
                } else if(par(n) == 1){
                    cantImpar++;
                }

                numeros[indice] = n;
                Console.WriteLine("Ingresa otro número: (presiona 0 para cortar)");
                n = int.Parse(Console.ReadLine());
                indice++;
            }
            
            Console.WriteLine("El mayor de los pares es el: " + mayorPar);
            Console.WriteLine("La cantidad de números impares es de: " + cantImpar);
            Console.Write("El menor de los números primos es el: " + menorPrim );
        }

        static bool primo(int n)
        {
            int cont = 0;
            for (int x = 1; x <= n; x++)
            {   
                if ( n % x == 0){
                    cont++;
                } 
            }
            if (cont ==2)
                return true;
            else
                return false;
        }

        static int par(int n)
        {
            if (n % 2 == 0)
            {
                return 2;
            } else
            {
                return 1;
            }
        }
       
    }
}
