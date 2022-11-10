using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 4.
* NOMBRE y APELLIDOS...: Javier Tienda González
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Diseño de clases. Herencia y polimorfismo.
* FECHA de ENTREGA.....: 10 de noviembre de 2022
*/

namespace Practica4
{
    class FichaDVD : Ficha
    {
        #region Campos de clase
        private string director;
        private int año;
        private string[] listaActores;
        #endregion

        /**
         * Constructor de clase parametrizado
         */
        public FichaDVD(string cadena, string titulo, int numEjemplares, string director, int año, string[] listaActores) : base(cadena, titulo, numEjemplares)
        {
            this.director = director;
            this.año = año;
            this.listaActores = listaActores;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================");
            Console.WriteLine("Referencia : " + base.Referencia());
            Console.WriteLine("Título.... : " + base.Titulo());
            Console.WriteLine("Ejemplares : " + base.NumEjemplares());
            Console.WriteLine("Director.. : " + this.director);
            Console.WriteLine("Año....... : " + this.año);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\t---Actores---");
            for(int i = 0; i < listaActores.Length; i++)
            {
                Console.WriteLine("Actor..... : " + this.listaActores[i]);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        #region Propiedades solo de lectura
        public string Director() { return director; }
        public int Año() { return año; }
        public string[] ListaActores() { return listaActores; }
        #endregion
    }
}
