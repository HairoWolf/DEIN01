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
    class FichaLibro : Ficha
    {
        #region Campos de clase
        private string autor;
        private string editorial;
        #endregion

        /**
         * Constructor de clase parametrizado
         */
        public FichaLibro(string cadena, string titulo, int numEjemplares, string autor, string editorial) : base(cadena, titulo, numEjemplares)
        {
            this.autor = autor;
            this.editorial = editorial;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================");
            Console.WriteLine("Referencia : " + base.Referencia());
            Console.WriteLine("Título.... : " + base.Titulo());
            Console.WriteLine("Ejemplares : " + base.NumEjemplares());
            Console.WriteLine("Autor..... : " + this.autor);
            Console.WriteLine("Editorial. : " + this.editorial); 
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        #region Propiedades solo de lectura
        public string Autor() { return autor; }
        public string Editorial() { return editorial; }
        #endregion
    }
}
