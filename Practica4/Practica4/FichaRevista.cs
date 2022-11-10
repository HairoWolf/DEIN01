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
    class FichaRevista : Ficha
    {
        #region Campos de clase
        private int numero;
        private int año;
        #endregion

        /**
         * Constructor de clase parametrizado
         */
        public FichaRevista(string cadena, string titulo, int numEjemplares, int numero, int año) : base(cadena, titulo, numEjemplares)
        {
            this.numero = numero;
            this.año = año;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================");
            Console.WriteLine("Referencia : " + base.Referencia());
            Console.WriteLine("Título.... : " + base.Titulo());
            Console.WriteLine("Ejemplares : " + base.NumEjemplares());
            Console.WriteLine("Numero.... : " + this.numero);
            Console.WriteLine("Año....... : " + this.año);
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        #region Propiedades solo de lectura
        public int Numero() { return numero; }
        public int Año() { return año; }
        #endregion
    }
}
