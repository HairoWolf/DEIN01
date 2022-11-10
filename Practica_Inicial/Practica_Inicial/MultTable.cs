using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica Inicial V1.
* NOMBRE y APELLIDOS...: Javier Tienda González
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de octubre de 2022
*/

namespace Practica_Inicial
{
    class MultTable
    {
        #region Campos de clase
        private double factor;
        private int nElementos;
        #endregion

        public MultTable(double factor, int nElementos)
        {
            this.factor = factor;
            this.nElementos = nElementos;
        }

        public void calcular()
        {
            byte posicion = 0; //Variable para el control de la posicion de la paginacion

            Console.Clear();
            #region Bucle para la impresion de todos los elementos
            for (int i = 1; i < nElementos + 1; i++)
            {
                #region Campos para el control de la paginacion
                bool bucle = true; //Variable para la repeticion de la elecion en el menu
                byte option = 0; //Variable para la eleccion en el menu
                #endregion
                posicion++;

                #region Calculo e impresion de la linea
                double calculo = factor * i;
                Console.WriteLine(factor + " * " + i + " = " + calculo);
                #endregion

                #region Condicion para actuar segun el valor de la posicion
                if (posicion == 20)
                {
                    #region Bucle para la repeticion de la eleccion en el menu
                    while (bucle)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        try
                        {
                            Console.WriteLine("Selecciona las distintas opciones: " +
                            "\n (1) Mostrar los siguientes 20 elementos \n (2) Salir ");
                            option = Convert.ToByte(Console.ReadLine());
                            if(option == 1) 
                            {
                                Console.Clear();
                            }
                            else if (option == 2)
                            {
                                bucle = false;
                                i = nElementos;
                                Console.Clear();
                            }
                            else
                            {
                                throw new Exception();
                            }
                            bucle = false;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("Introduce una opción válida");
                        }
                        posicion = 0;
                    }
                    #endregion
                }
                #endregion
            }
            #endregion
        }
    }
}
