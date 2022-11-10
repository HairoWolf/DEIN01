/*
* PRÁCTICA.............: Práctica 3.
* NOMBRE y APELLIDOS...: Javier Tienda González
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Sentencias de Control. Excepciones.
* FECHA de ENTREGA.....: 03 de noviembre de 2022
*/

namespace Practica3
{
    class AppMain
    {
        public static void Main(String[] args)
        {
            int numPreguntas = 0;
            int tiempoMax = 0;
            byte option = 0;//Variable para la eleccion en el menu
            bool loop = true; //Boolean para iterar sobre bucles donde la variable se introduzca un valor no válido

            while (option != 4)
            {
                try
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Juego de multiplicar\n 1. Establecer tiempo máximo para las respuestas\n " +
                        "2. Establecer el número de preguntas\n 3. JUGAR\n 4. Salir\n\n Opción: ");
                    option = Convert.ToByte(Console.ReadLine());
                    if (option < 1 || option > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Introduce una opcion válida");
                    }
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Introduce el tiempo máximo para las respuestas (min 5s): ");
                            while (loop)
                            {
                                try
                                {
                                    tiempoMax = Convert.ToInt32(Console.ReadLine());
                                    if(tiempoMax < 5)
                                    {
                                        throw new Exception();
                                    }
                                    loop = false;
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("Introduce un tiempo válido (min 5s):");
                                }
                            }
                            loop = true;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Introduce el número de preguntas: ");
                            while (loop)
                            {
                                try
                                {
                                    numPreguntas = Convert.ToInt32(Console.ReadLine());
                                    if (numPreguntas <= 0)
                                    {
                                        throw new Exception();
                                    }
                                    loop = false;
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("Introduce un número de preguntas válido");
                                }
                            }
                            loop = true;
                            break;
                        case 3:
                            if(numPreguntas == 0 || tiempoMax == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Debe ejecutar antes las opciones 1 y 2 del menú\nPulse una tecla para continuar...");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                int aciertos = 0;
                                for(int i = 0; i < numPreguntas; i++)
                                {
                                    aciertos = preguta(aciertos, tiempoMax);
                                }
                                Console.Clear();
                                Console.WriteLine("Aciertos: " + aciertos + " Fallos: " + (numPreguntas - aciertos));
                                Console.WriteLine("Nota: " + (aciertos * 100/numPreguntas) + "%\n\nPulse una tecla para volver al menú...");
                                Console.ReadLine();
                            }
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
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

        private static int preguta(int aciertos, int tiempoMax)
        {
            DateTime localDate = DateTime.Now;
            Random random = new Random();
            int num1 = random.Next(1, 10);
            int num2 = random.Next(1, 10);
            Console.WriteLine(num1 + " * " + num2 + " = ");
            int solucion = num1 * num2;
            string respuesta = "";
            ConsoleKeyInfo key = new ConsoleKeyInfo((char)ConsoleKey.Backspace, ConsoleKey.Backspace, false, false, false);
            TimeSpan time = DateTime.Now - localDate;
            int timeToCompare = int.Parse(time.Seconds.ToString());
            do
            {
                time = DateTime.Now - localDate;
                timeToCompare = int.Parse(time.Seconds.ToString());
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey();
                    respuesta += key.Key;
                    respuesta = respuesta.Replace("D", "");
                }
                else 
                {
                    Thread.Sleep(100);
                }
            } while (timeToCompare < tiempoMax && key.Key != ConsoleKey.Enter);

            try
            {
                respuesta = respuesta.Replace("Enter", "");
                int respuestaAComparar = Convert.ToInt32(respuesta);
                if(respuestaAComparar == solucion)
                {
                    Console.WriteLine(" ->Bien");
                    aciertos++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ->Mal. El resultado es: " + solucion);
                }

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Fallo al introducir el numero");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" -> Pulse una tecla para continuar...");
            Console.ReadLine();
            return aciertos;
        }
    }
}