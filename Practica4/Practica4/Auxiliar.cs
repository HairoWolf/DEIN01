using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    class Auxiliar
    {
        #region Campos de clase
        private bool bucle = true;
        #endregion

        /**
         * Constructor de clase
         */
        public Auxiliar()
        {

        }


        /**
         * Metodo que recibe un texto para imprimir por consola y devuelve una cadena de texto
         */
        public string leerCadena(string mensaje)
        {
            string text = "";
            while (bucle)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(mensaje);
                    text = Console.ReadLine();
                    if (text.Equals(""))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("La cadena esta vacia");
                    }
                    else
                    {
                        bucle = false;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce una cadena de texto válida");
                }
            }
            bucle = true;
            Console.Clear();
            return text;
        }

        /**
         * Metodo que recibe un texto para imprimir por consola y devuelve un entero
         */
        public int leerEnteroPositivo(string mensaje)
        {
            int num = 0;
            while (bucle)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("El numero tiene que ser mayor a 0");
                    }
                    else
                    {
                        bucle = false;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce un entero válido");
                }
            }
            bucle = true;
            Console.Clear();
            return num;
        }
    }
}
