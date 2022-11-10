using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 2.
* NOMBRE y APELLIDOS...: Javier Tienda González
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Definición de Clases. Uso de Métodos.
* FECHA de ENTREGA.....: 27 de octubre de 2022
*/

namespace Practica2
{
    class Empleado
    {
        #region Campos de clase
        private int categoria, numHijos, numTrienios, salarioBase;
        private string nif, nombre;
        #endregion

        /**
         * Constructor de clase con 5 parametros
         */
        public Empleado(int categoria, string nif, string nombre, int numHijos, int numTrienios)
        {
            this.categoria = categoria;
            this.nif = nif;
            this.nombre = nombre;
            this.numHijos = numHijos;
            this.numTrienios = numTrienios;
            switch (this.categoria)
            {
                case 1:
                    this.salarioBase = 2500;
                    break;
                case 2:
                    this.salarioBase = 2000;
                    break;
                case 3:
                    this.salarioBase = 1500;
                    break;
            }
        }

        /**
         * Constructor predefinido
         */
        public Empleado()
        {
            this.categoria = 1;
            this.nif = "11111111A";
            this.nombre = "Predefinido";
            this.numHijos = 0;
            this.numTrienios = 0;
        }

        /**
         * Destructor vacío
         */
        ~Empleado()
        {
            Console.WriteLine("El empleado se ha finalizado");
        }

        #region Propiedades de los campos de clase
        public int Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }

        public string Nif
        {
            get
            {
                return this.nif;
            }
            set
            {
                this.nif = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int NumHijos
        {
            get
            {
                return this.numHijos;
            }
            set
            {
                this.numHijos = value;
            }
        }

        public int NumTrienios
        {
            get
            {
                return this.numTrienios;
            }
            set
            {
                this.numTrienios = value;
            }
        }

        public int SalarioBase
        {
            get
            {
                return this.salarioBase;
            }
            set
            {
                this.salarioBase = value;
            }
        }
        #endregion
    }
}
