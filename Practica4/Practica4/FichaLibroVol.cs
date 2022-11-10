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
    class FichaLibroVol : FichaLibro
    {
        #region Campos de clase
        private string numeroVolumen;
        #endregion

        /**
         * Constructor de clase parametrizado
         */
        public FichaLibroVol(string cadena, string titulo, int numEjemplares, string autor, string editorial, string numeroVolumen) : base(cadena, titulo, numEjemplares, autor, editorial)
        {
            this.numeroVolumen = numeroVolumen;
        }

        public override void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================");
            Console.WriteLine("Referencia : " + base.Referencia());
            Console.WriteLine("Título.... : " + base.Titulo());
            Console.WriteLine("Ejemplares : " + base.NumEjemplares());
            Console.WriteLine("Autor..... : " + base.Autor());
            Console.WriteLine("Editorial. : " + base.Editorial() + "  Nº volumen : " + this.numeroVolumen);
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        #region Propiedades solo de lectura
        public string NumeroVolumen() { return numeroVolumen; }
        #endregion
    }
}
