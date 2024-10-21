﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 2. Modificar el arreglo para incluir números duplicados y
analizar cómo se comporta la búsqueda.

 */

/*
 
2. Modificar el arreglo para incluir números negativos y
observar cómo afecta la búsqueda.
 
 */
namespace ConsoleApp1
{
     class Busqueda
     {

        private int[] vector;

        public void Cargar() {

            Console.WriteLine("Busqueda binaria");
            Console.WriteLine("Ingrese 10 elementos");

            vector = new int[10];

            for (int f = 0; f < vector.Length; f++)
            {
                Console.WriteLine("Ingrese el elemento " + (f + 1) + ": ");
                vector[f] = int.Parse(Console.ReadLine());
            }

        }

        public void OrdenarBurbuja()
        {

            int n = vector.Length;
            for (int i = 0; i < n - 1 ; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {

                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;
                    }
                }
            }
        }

        public void busqueda(int num)
        {

            int l = 0, h = 9;
            int m = 0;
            bool found = false;

            while (l <= h && found == false)
            {

                m = (l + h) / 2;
                if (vector[m] == num)
                    found = true;
                if (vector[m] > num)
                    h = m - 1;
                else
                    l = m + 1;
            }
            if (found == false)
            {
                Console.Write($"\nEl elemento {num} no esta en el arreglo");
            }
            else {
                Console.Write($"\nEl elemento {num} esta en la posicion: {m + 1}");

            }
        }

        public void Imprimir()
        {

            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + " ");
            }
        }



        static void Main(string[] args)
        {

            Busqueda pv = new Busqueda();

            pv.Cargar();
            pv.OrdenarBurbuja();
            pv.Imprimir();
            Console.Write("\n\nIngresa elemento a buscar: ");
            int num = int.Parse(Console.ReadLine());
            pv.busqueda(num);
            Console.ReadKey();
    
            
            
        }
     }
}
