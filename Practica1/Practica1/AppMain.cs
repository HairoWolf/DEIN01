using Practica1;

/*
* PRÁCTICA.............: Práctica 1.
* NOMBRE y APELLIDOS...: Javier Tienda González
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: P.O.O. Abstracción. Definición de Clases.
* FECHA de ENTREGA.....: 19 de octubre de 2022
*/

class AppMain
{
    public static void Main(String[] args)
    {
        string marca = "";
        byte pulgadas = 0;
        int consumo = 0;
        double precio = 0;
        byte option = 0; //Variable para la eleccion en el menu
        bool bucle = true; //Boolean para iterar sobre bucles donde la variable se introduzca un valor no válido

        Console.WriteLine("Introduce los datos de la pantalla");
        while (bucle)
        {
            try
            { 
                Console.Write("Marca: ");
                marca = Console.ReadLine().ToString();
                Console.WriteLine("----------------------------------");
                bucle = false;
            }
            catch
            {
                Console.WriteLine("Introduce un valor válido");
            }
        }
        bucle = true;

        while (bucle)
        {
            try
            {
                Console.Write("Pulgadas: ");
                pulgadas = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                bucle = false;
            }
            catch
            {
                Console.WriteLine("Introduce un valor válido");
            }
        }
        bucle = true;

        while (bucle)
        {
            try
            {
                Console.Write("Consumo: ");
                consumo = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                bucle = false;
            }
            catch
            {
                Console.WriteLine("Introduce un valor válido");
            }
        }
        bucle = true;

        while (bucle)
        {
            try
            { 
                Console.Write("Precio: ");
                string precioTemp = Console.ReadLine();
                if (precioTemp.Contains("."))
                {
                    precioTemp.Replace(".", ",");
                }
                precio = Convert.ToDouble(precioTemp);
                Console.WriteLine("----------------------------------");
                bucle = false;
            }
            catch
            {
                Console.WriteLine("Introduce un valor válido");
            }
        }

        ClaseTv miTv = new ClaseTv(marca, pulgadas, consumo, precio);

        while (option != 8)
        {
            Console.WriteLine("Selecciona una de las distintas opciones: " + "" +
                "\n (1) Pulsar On/Off " +
                "\n (2) Subir Volumen " +
                "\n (3) Bajar Volumen " +
                "\n (4) Poner Canal" +
                "\n (5) Cambiar a canal anterior " +
                "\n (6) Estado actual " +
                "\n (7) Información Técnica " +
                "\n (8) Finalizar aplicación");
            try
            {
                option = Convert.ToByte(Console.ReadLine());
                if(option < 1 || option > 8)
                {
                    throw new Exception();
                }
                switch (option)
                {
                    case 1:
                        miTv.pulsarOnOff();
                        break;
                    case 2:
                        miTv.subirVolumen();
                        break;
                    case 3:
                        miTv.bajarVolumen();
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Canal: ");
                            byte canal = Convert.ToByte(Console.ReadLine());
                            Console.WriteLine("----------------------------------");
                            miTv.ponerCanal(canal);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Introduce un valor válido");
                            Console.WriteLine("----------------------------------");
                        }
                        break;
                    case 5:
                        miTv.cambiarCanalAnterior();
                        break;
                    case 6:
                        miTv.estadoActual();
                        break;
                    case 7:
                        miTv.informacionTécnica();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Introduce una opción válida");
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
