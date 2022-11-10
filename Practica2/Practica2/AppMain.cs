using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 2.
* NOMBRE y APELLIDOS...: Javier Tienda González
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Definición de Clases. Uso de Métodos.
* FECHA de ENTREGA.....: 27 de octubre de 2022
*/

namespace Practica2
{
    class AppMain
    {
        public static void Main(String[] args)
        {
            informacionEmpleado();
        }

        /**
         * Metodo para ingresar los datos de un empleado y crear su objeto
         */
        public static void informacionEmpleado()
        {
            int categoria = 0;
            string nif = "";
            string nombre = "";
            int numHijos = 0;
            int numTrienios = 0;
            DateTime fechaNomina = DateTime.Now;
            int numHorasExtra = 0;
            bool bucle = true; //Boolean para iterar sobre bucles donde la variable se introduzca un valor no válido

            Console.WriteLine("Introduce los datos del empleado");

            #region Insercion valor Categoria
            while (bucle)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    Console.WriteLine("Introduce la categoria (1, 2, 3):");
                    categoria = Convert.ToInt32(Console.ReadLine());
                    if(categoria < 1 || categoria > 3)
                    {
                        throw new Exception();
                    }
                    Console.WriteLine("---------------------------");
                    bucle = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce una categoria válida");
                }
            }
            #endregion
            bucle = true; //Reset de variable para poder realizar el resto de bucles

            #region Insercion valor NIF
            while (bucle)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    Console.WriteLine("Introduce el NIF (con letra):");
                    nif = Console.ReadLine();

                    // Separacion string NIF en numeros y la letra
                    int nifNumbers = Convert.ToInt32(nif.Substring(0, nif.Length - 1));
                    string nifLeter = (nif.Substring(nif.Length - 1, 1)).ToUpper();

                    nif = nifNumbers + nifLeter;

                    //Formato del NIF
                    Regex rgx = new Regex(@"\d{8}[A-Z]");

                    #region Comprobacion formato NIF
                    if (rgx.IsMatch(nif) && nif.Length == 9)
                    {
                        #region Comprobacion letra NIF
                        if (!nifLeter.Equals(nifLetter(nifNumbers)))
                        {
                            throw new Exception();
                        }
                        #endregion
                    }
                    else
                    {
                        throw new Exception();
                    }
                    #endregion
                    Console.WriteLine("---------------------------");
                    bucle = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce un NIF válido");
                }
            }
            #endregion
            bucle = true; //Reset de variable para poder realizar el resto de bucles

            #region Insercion valor Nombre
            while (bucle)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    Console.WriteLine("Introduce el nombre:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("---------------------------");
                    bucle = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce un nombre válido");
                }
            }
            #endregion
            bucle = true; //Reset de variable para poder realizar el resto de bucles

            #region Insercion valor Numero de Hijos
            while (bucle)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    Console.WriteLine("Introduce el numero de hijos:");
                    numHijos = Convert.ToInt32(Console.ReadLine());
                    if (numHijos < 0 || numHijos > 200)
                    {
                        throw new Exception();
                    }
                    Console.WriteLine("---------------------------");
                    bucle = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce un numero de hijos válido");
                }
            }
            #endregion
            bucle = true; //Reset de variable para poder realizar el resto de bucles

            #region Insercion valor Numero de Trienios
            while (bucle)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    Console.WriteLine("Introduce el numero de trienios:");
                    numTrienios = Convert.ToInt32(Console.ReadLine());
                    if (numTrienios < 0 || numTrienios > 12)
                    {
                        throw new Exception();
                    }
                    Console.WriteLine("---------------------------");
                    bucle = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce un numero de trienios válido");
                }
            }
            #endregion
            bucle = true; //Reset de variable para poder realizar el resto de bucles

            //Creacion de mi objeto Empleado
            Empleado miEmpleado = new Empleado(categoria, nif, nombre, numHijos, numTrienios);

            Console.WriteLine("Introduce los datos referentes a la nomina");

            #region Insercion valor fecha nomina
            while (bucle)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    Console.WriteLine("Introduce fecha de liquidación (dd/mm/aaaa):");
                    fechaNomina = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("---------------------------");
                    bucle = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce una fecha de liquidación válida");
                }
            }
            #endregion
            bucle = true; //Reset de variable para poder realizar el resto de bucles

            #region Insercion valor numero horas extra
            while (bucle)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    Console.WriteLine("Introduce el numero de horas extra:");
                    numHorasExtra = Convert.ToInt32(Console.ReadLine());
                    if (numHorasExtra < 0)
                    {
                        throw new Exception();
                    }
                    bucle = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce un numero de horas extra válido");
                }
            }
            #endregion

            Console.WriteLine("Pulse una tecla para calcular y presentar la hoja salarial");
            Console.ReadLine();

            //Creacion de mi objeto Nomina
            Nomina miNomina = new Nomina(miEmpleado, fechaNomina, numHorasExtra);
            miNomina.hojaSalarial();
        }

        /**
         * Metodo para comprobar si la letra del NIF es correcta
         */
        public static string nifLetter(int nifNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            int mod = nifNumbers % 23;
            return control[mod];
        }
    }
}