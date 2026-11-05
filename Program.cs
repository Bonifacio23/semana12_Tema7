using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana12_Tema7
{
    internal class Program
    {
        static public void numeros_natu()
        {
            Console.Write("Ingrese numero de N: ");
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int c = 1; c <= N; c++)
            {
                S += c;

            }
            Console.WriteLine("la suma es: " + S);

        }
        static public int suma_NN_con_recursividad(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N + suma_NN_con_recursividad(N - 1);
        }
        static public int suma_NN_numeros_pares(int N)
        {
            if (N == 1)
            {
                return 2;
            }
            return 2 * N + suma_NN_numeros_pares(N - 1);
        }
        static public long suma_factorial(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N * suma_factorial(N - 1);
        }
        static public long exponente(int a,int b)
        {
            if (b == 0)
            {
                return 1;
            }
            return a * exponente(a,b - 1);
        }
        static public void numeros_natu_con_recursividad(int N) 
        {
            Console.WriteLine(N);
            if (N == 0)
            {
                return;
            }
            numeros_natu_con_recursividad(N - 1);
            
        }
        static public int suma_arreglos(int[] numero, int indice)
        {
            if (indice >= numero.Length)
            {
                return 0;
            }
            return numero[indice] + suma_arreglos(numero, indice+1);
        }
            static void Main(string[] args)
        {
            int op = 0;
            bool valor = true;
            while (valor) 
            {
                Console.Clear();
                string titulo = "MENU DE OPCIONES";
                int posicion = (Console.WindowWidth - titulo.Length)/2;

                Console.SetCursorPosition(posicion, Console.CursorTop);
                Console.WriteLine("*******************");

                Console.SetCursorPosition(posicion, Console.CursorTop);
                Console.WriteLine(titulo);

                Console.SetCursorPosition(posicion, Console.CursorTop);
                Console.WriteLine("*******************");

                Console.WriteLine("1. Suma de N numeros naturales");
                Console.WriteLine("2. Suma de N numeros naturales con recursividad");
                Console.WriteLine("3. Suma de N numeros pares");
                Console.WriteLine("4. Suma de factorial");
                Console.WriteLine("5. Exponente");
                Console.WriteLine("6. Numeros naturales con recursividad");
                Console.WriteLine("7. Arreglos");
                Console.WriteLine("8. Salir");
                Console.Write("Ingrese una opcion: ");
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("!!!ERRORR!!!!"); continue;
                }
                switch (op) 
                {
                    case 1:
                        numeros_natu();break;
                    case 2:
                        Console.WriteLine("Ingresa numero N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("Suma de 5 elementos:" + suma_NN_con_recursividad(N)); break;
                    case 3:
                        Console.WriteLine("Ingresa numero N: ");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("suma de numeros pares:" + suma_NN_numeros_pares(N1));break;
                    case 4:
                        Console.WriteLine("Ingresa numero factorial: ");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("suma de factorial:" + suma_factorial(N2));break;
                    case 5:
                        Console.WriteLine("Ingresa base: ");
                        int N3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa exponente: ");
                        int N4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("exponente:" + exponente(N3, N4));break;
                    case 6:
                        Console.WriteLine("Ingresa numero para la cuenta regresiva: ");
                        int N5 = int.Parse(Console.ReadLine());
                        numeros_natu_con_recursividad(N5);break;
                    case 7:
                        Console.WriteLine("ingrese el numero de elementos del arreglo: ");
                        int n = int.Parse(Console.ReadLine());
                        int[] numeros = new int[n];
                        Console.WriteLine("ingrese los elementos del arreglo: ");
                        for (int i = 0; i < n; i++)
                        {
                            numeros[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"la suma del arreglo es: {suma_arreglos(numeros,0)}");
                        break;
                    case 8:
                        Console.WriteLine("Saliendo...");
                        valor = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida"); break;

                }
                Console.ReadKey();
            }

            

        }
    }
}
    
