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
    abstract class Ficha
    {
        #region Campos de clase
        private string referencia;
        private string titulo;
        private int numEjemplares;
        private int numOrden = 0;
        #endregion

        /**
         * Constructor de clase parametrizado
         */
        public Ficha(string cadena, string titulo, int numEjemplares)
        {
            this.numOrden++;
            this.referencia = cadena + "/" + this.numOrden;
            this.titulo = titulo;
            this.numEjemplares = numEjemplares;
        }

        public abstract void imprimir();

        #region Propiedades solo de lectura
        public string Referencia() { return referencia; }
        public string Titulo() { return titulo; }
        public int NumEjemplares() { return numEjemplares; }
        public int NumOrden() { return numOrden; }
        #endregion

    }
}
