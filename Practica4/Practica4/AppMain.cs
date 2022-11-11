/*
* PRÁCTICA.............: Práctica 4.
* NOMBRE y APELLIDOS...: Javier Tienda González
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Diseño de clases. Herencia y polimorfismo.
* FECHA de ENTREGA.....: 10 de noviembre de 2022
*/

using System.Collections;

namespace Practica4
{
    class AppMain
    {
        public static void Main(String[] args)
        {
            byte menu = 0;
            Auxiliar misMetodos = new Auxiliar();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("---GESTIÓN BIBLIOTECA---");
            ArrayList listaFichas = new ArrayList();
            while (menu != 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Selecciona una de las distintas opciones: " +
                    "\n (1) Consultar Biblioteca " +
                    "\n (2) Crear Fichas" +
                    "\n (3) Finalizar aplicación");
                try
                {
                    menu = Convert.ToByte(misMetodos.leerEnteroPositivo("Teclee opción: "));
                    if (menu < 1 || menu > 3)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        switch (menu)
                        {
                            case 1:
                                Console.Clear();
                                if(listaFichas.Count == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("No existe ninguna ficha");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                for(int i = 0; i < listaFichas.Count; i++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\t---Ficha Nº" + (i + 1) + "---");
                                    ((Ficha)listaFichas[i]).imprimir();
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Pulse una tecla para continuar...");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                #region Creacion Fichas
                                byte option2 = 0;
                                while (option2 != 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Selecciona una de las distintas opciones: " +
                                        "\n (1) Crear Ficha Libro " +
                                        "\n (2) Crear Ficha Libro Volumen " +
                                        "\n (3) Crear Ficha Revista " +
                                        "\n (4) Crear Ficha DVD" +
                                        "\n (5) Salir al menu");
                                    try
                                    {
                                        option2 = Convert.ToByte(misMetodos.leerEnteroPositivo("Teclee opción: "));
                                        if (option2 < 1 || option2 > 5)
                                        {
                                            throw new Exception();
                                        }
                                        else
                                        {
                                            switch (option2)
                                            {
                                                case 1:
                                                    #region Creacion Ficha Libro
                                                    Console.Clear();
                                                    FichaLibro miFichaLibro = creaFichaLibro();
                                                    Console.Clear();
                                                    miFichaLibro.imprimir();
                                                    listaFichas.Add(miFichaLibro);
                                                    Console.WriteLine("Pulse una tecla para continuar...");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    #endregion
                                                    break;
                                                case 2:
                                                    #region Creacion Ficha Libro Volumen
                                                    Console.Clear();
                                                    FichaLibroVol miFichaLibroVol = creaFichaLibroVol();
                                                    Console.Clear();
                                                    miFichaLibroVol.imprimir();
                                                    listaFichas.Add(miFichaLibroVol);
                                                    Console.WriteLine("Pulse una tecla para continuar...");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    #endregion
                                                    break;
                                                case 3:
                                                    #region Creacion Ficha Revista
                                                    Console.Clear();
                                                    FichaRevista miFichaRevista = creaFichaRevista();
                                                    Console.Clear();
                                                    miFichaRevista.imprimir();
                                                    listaFichas.Add(miFichaRevista);
                                                    Console.WriteLine("Pulse una tecla para continuar...");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    #endregion
                                                    break;
                                                case 4:
                                                    #region Creacion Ficha DVD
                                                    Console.Clear();
                                                    FichaDVD miFichaDVD = creaFichaDVD();
                                                    Console.Clear();
                                                    miFichaDVD.imprimir();
                                                    listaFichas.Add(miFichaDVD);
                                                    Console.WriteLine("Pulse una tecla para continuar...");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    #endregion
                                                    break;
                                                case 5:
                                                    break;
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("Introduce una opcion válida");
                                    }
                                }
                                break;
                            #endregion
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Hasta luego!!!");
                                Console.ForegroundColor = ConsoleColor.White;
                                Environment.Exit(0);
                                break;
                        }
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Introduce una opcion válida");
                }
            }
        }

        /**
         * Metodos para la creacion de las Fichas
         */
        public static FichaLibro creaFichaLibro()
        {
            Auxiliar misMetodos = new Auxiliar();
            string cadena = misMetodos.leerCadena("Introduce la cadena de texto de la referencia del libro");
            string titulo = misMetodos.leerCadena("Introduce el titulo del libro");
            int numEjemplares = misMetodos.leerEnteroPositivo("Introduce el numero de ejemplares");
            string autor = misMetodos.leerCadena("Introduce el autor del libro");
            string editorial = misMetodos.leerCadena("Introduce la editorial del libro");
            return new FichaLibro(cadena, titulo, numEjemplares, autor, editorial);
        }

        public static FichaLibroVol creaFichaLibroVol()
        {
            Auxiliar misMetodos = new Auxiliar();
            string cadena = misMetodos.leerCadena("Introduce la cadena de texto de la referencia del libro");
            string titulo = misMetodos.leerCadena("Introduce el titulo del libro");
            int numEjemplares = misMetodos.leerEnteroPositivo("Introduce el numero de ejemplares");
            string autor = misMetodos.leerCadena("Introduce el autor del libro");
            string editorial = misMetodos.leerCadena("Introduce la editorial del libro");
            string numeroVolumen = misMetodos.leerCadena("Introduce el numero de Volumen");
            return new FichaLibroVol(cadena, titulo, numEjemplares, autor, editorial, numeroVolumen);
        }

        public static FichaRevista creaFichaRevista()
        {
            Auxiliar misMetodos = new Auxiliar();
            string cadena = misMetodos.leerCadena("Introduce la cadena de texto de la referencia de la revista");
            string titulo = misMetodos.leerCadena("Introduce el titulo de la revista");
            int numEjemplares = misMetodos.leerEnteroPositivo("Introduce el numero de ejemplares");
            int numero = misMetodos.leerEnteroPositivo("Introduce el numero de la revista");
            int año = misMetodos.leerEnteroPositivo("Introduce el año de la revista");
            return new FichaRevista(cadena, titulo, numEjemplares, numero, año);
        }

        public static FichaDVD creaFichaDVD()
        {
            Auxiliar misMetodos = new Auxiliar();
            string cadena = misMetodos.leerCadena("Introduce la cadena de texto de la referencia del DVD");
            string titulo = misMetodos.leerCadena("Introduce el titulo del DVD");
            int numEjemplares = misMetodos.leerEnteroPositivo("Introduce el numero de ejemplares");
            string director = misMetodos.leerCadena("Introduce el director del DVD");
            int año = misMetodos.leerEnteroPositivo("Introduce el año del DVD");
            int numActores = misMetodos.leerEnteroPositivo("Introduce el numero de actores");
            ArrayList listaActores = new ArrayList();
            for(int i = 1; i <= numActores; i++)
            {
                listaActores.Add(misMetodos.leerCadena("- Actor " + i + "º :"));
            }
            return new FichaDVD(cadena, titulo, numEjemplares, director, año, (string[])listaActores.ToArray(typeof(string)));
        }
    }
}