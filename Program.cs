using System;

namespace ArreglosEjemplo2023_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 1, 2, 3, 20, 5, 10 };
            int [] A=IngresarArreglo();
            //int[] B = new int[A.Length];}
            //Array.Copy(A,B,A.Length);
            int[] B = A;


            Array.Sort(A);
            Array.Reverse(A);

            Program miPrograma = new Program();
            miPrograma.ImprimeArreglo(A);
            miPrograma.ImprimeArreglo(B);
            ImprimeCadenaArreglo();



            Console.ReadLine();


        }



        internal static void ImprimeCadenaArreglo()
        {
            
            Console.WriteLine("\nIngresa una cadena");
            string cadena= Console.ReadLine();

            for(int i=0; i < cadena.Length; i++)
            {
                Console.Write("\t{0}",cadena[i]);
            }

            Console.WriteLine();
        }

        internal void ImprimeArreglo(int [] A  )
        {
            Console.WriteLine("Imprimiendo Arreglo: ");
           /* for(int i=0; i < A.Length; i++ )
            {
                Console.Write(" {0} ", A[i]);
            }*/

            foreach(int elemento in A   )
            {
                Console.Write(" {0} ", elemento);
            }
            
        }
        internal static int [] IngresarArreglo()
        {
            Console.WriteLine("Ingresa el tamaño del arreglo");
            int N =int.Parse( Console.ReadLine());
            int[] A = new int[N];
            for( int i=0; i < N; i++  )
            {
                Console.WriteLine("Ingresa el elemento A[{0}]", i);
                A[i] = int.Parse(Console.ReadLine());
            }           
            return A;

        }

    }
}
