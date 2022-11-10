using Practica_Inicial;
using System.Media;

/*
* PRÁCTICA.............: Práctica Inicial V1.
* NOMBRE y APELLIDOS...: Javier Tienda González
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de octubre de 2022
*/

class appMain
{
    public static void Main(String[] args)
    {
        #region Campos para el control de las inserciones por teclado
        byte option = 0; //Variable para la eleccion en el menu
        bool bucle = true; //Boolean para iterar sobre bucles donde la variable se introduzca un valor no válido
        #endregion

        #region Bucle de ejecucion del programa
        while (option != 3)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Selecciona las distintas opciones: " + "" +
                "\n (1) Resolver Ecuación de Segundo Grado \n (2) Mostrar tabla de multiplicar \n (3) Salir ");
            try
            {
                option = Convert.ToByte(Console.ReadLine());

                #region Control de opciones no validas
                if (option > 3 || option < 1)
                {
                    throw new Exception();
                }
                #endregion

                switch (option)
                {
                    #region Ecuacion Segundo Grado
                    case 1:
                        Console.Clear();
                        double a = 0;
                        double b = 0;
                        double c = 0;

                        //Control para no permitir la insercion de los tres valores como 0
                        while (a == 0 && b == 0 && c == 0) 
                        {
                            #region Insercion valor A
                            while (bucle)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                try
                                {
                                    Console.WriteLine("Introduce el valor a");
                                    a = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("---------------------------");
                                    bucle = false;
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("Introduce un valor válido");
                                }
                            }
                            #endregion
                            bucle = true; //Reset de variable para poder realizar el resto de bucles

                            #region Insercion valor B
                            while (bucle)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                try
                                {
                                    Console.WriteLine("Introduce el valor b");
                                    b = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("---------------------------");
                                    bucle = false;
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("Introduce un valor válido");
                                }
                            }
                            #endregion
                            bucle = true; //Reset de variable para poder realizar el resto de bucles

                            #region Insercion valor C
                            while (bucle)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                try
                                {
                                    Console.WriteLine("Introduce el valor c");
                                    c = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("---------------------------");
                                    bucle = false;
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("Introduce un valor válido");
                                }
                            }
                            #endregion
                            bucle = true; //Reset de variable para poder realizar el resto de bucles

                            #region Condicional para la restriccion de valores
                            if (a == 0 && b == 0 && c == 0)
                            {
                                Console.WriteLine("Los tres valores no pueden ser iguales a 0");
                                Console.WriteLine("---------------------------");
                            }
                            #endregion
                        }
                        ScndGrade miSegundoGrado = new ScndGrade(a, b, c); //Creacion de mi objeto
                        miSegundoGrado.calcular(); //Metodo para calcular la ecuacion de segundo grado
                        Console.WriteLine("---------------------------");
                        break;
                    #endregion

                    #region Tabla de Multiplicar
                    case 2:
                        Console.Clear();
                        double factor = 0;
                        int nElementos = 0;
                        #region Insercion factor sobre el que se va a calcular
                        while (bucle)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            try
                            {
                                Console.WriteLine("Introduce el factor");
                                factor = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("---------------------------");
                                bucle = false;
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Introduce un valor válido");
                            }
                        }
                        #endregion
                        bucle = true; //Reset de variable para poder realizar el resto de bucles

                        #region Insercion numero de elementos a calcular
                        while (bucle)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            try
                            {
                                Console.WriteLine("Introduce el número Elementos");
                                nElementos = Convert.ToInt32(Console.ReadLine());
                                if (nElementos <= 0)
                                {
                                    throw new Exception("Numero de elementos tiene que ser mayor de 0");
                                }
                                Console.WriteLine("---------------------------");
                                bucle = false;
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Introduce un valor válido");
                            }
                        }
                        #endregion
                        bucle = true; //Reset de variable para poder realizar el resto de bucles

                        MultTable miTablaMultiplicar = new MultTable(factor, nElementos); //Creacion de mi objeto
                        miTablaMultiplicar.calcular(); //Metodo para sacar la tabla de multiplicar
                        break;
                    #endregion

                    #region Finalizacion del programa
                    case 3:
                        Environment.Exit(0);
                        break;
                    #endregion
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Introduce una opción válida");
            }
        }
        #endregion
    }
}
