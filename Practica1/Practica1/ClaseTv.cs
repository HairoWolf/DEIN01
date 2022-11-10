using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
* PRÁCTICA.............: Práctica 1.
* NOMBRE y APELLIDOS...: Javier Tienda González
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: P.O.O. Abstracción. Definición de Clases.
* FECHA de ENTREGA.....: 19 de octubre de 2022
*/

namespace Practica1
{
    internal class ClaseTv
    {
        private string marca;
        private byte pulgadas;
        private int consumo;
        private double precio;
        private bool onOff; //True: encendido; False: apagado
        private byte canal; //Valores [0, 99]
        private byte canalAnterior;
        private byte volumen; // Valores [1,100]

        /**
         * Constructor parametrizado con 4 parametros
         */
        public ClaseTv(string marca, byte pulgadas, int consumo, double precio)
        {
            this.marca = marca;
            this.pulgadas = pulgadas;
            this.consumo = consumo;
            this.precio = precio;
            this.onOff = false;
            this.canal = 1;
            this.canalAnterior = 0;
            this.volumen = 10;
        }

        /**
         * Metodo para encender y apagar el televisor
         */
        public void pulsarOnOff()
        {
            if (!this.onOff)
            {
                this.onOff = true;
                this.canal = 1;
                this.canalAnterior = 1;
                this.volumen = 25;
                Console.WriteLine("Televison Encendida");
                Console.WriteLine("----------------------------------");
            }
            else
            {
                this.onOff = false;
                this.canal = 1;
                this.canalAnterior = 0;
                this.volumen = 10;
                Console.WriteLine("Televison Apagada");
                Console.WriteLine("----------------------------------");
            }
        }

        /**
         * Metodo para subir el volumen del televisor
         */
        public void subirVolumen()
        {
            if (this.onOff)
            {
                if (this.volumen >= 100)
                {
                    Console.WriteLine("Volumen: 100!");
                    Console.WriteLine("----------------------------------");
                    Console.Beep();
                }
                else
                {
                    this.volumen++;
                    Console.WriteLine("Volumen: " + this.volumen.ToString());
                    Console.WriteLine("----------------------------------");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
            }
        }

        /**
         * Metodo para bajar el volumen del televisor
         */
        public void bajarVolumen()
        {
            if (this.onOff)
            {
                if (this.volumen <= 1)
                {
                    Console.WriteLine("Volumen: 1!");
                    Console.WriteLine("----------------------------------");
                    Console.Beep();
                }
                else
                {
                    this.volumen--;
                    Console.WriteLine("Volumen: " + this.volumen.ToString());
                    Console.WriteLine("----------------------------------");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
            }
        }

        /**
         * Metodo para cambiar el canal del televisor a un canal pasado como parametro al metodo
         */
        public void ponerCanal(byte nuevoCanal)
        {
            if (this.onOff)
            {
                if (nuevoCanal < 0 || nuevoCanal > 99)
                {
                    Console.Beep();
                }
                else
                {
                    this.canalAnterior = this.canal;
                    this.canal = nuevoCanal;
                    Console.WriteLine("Canal: " + canal.ToString());
                    Console.WriteLine("----------------------------------");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
            }
        }

        /**
         * Metodo para cambiar el canal del televisor al anterior canal
         */
        public void cambiarCanalAnterior()
        {
            if (this.onOff)
            {
                byte canalTemp = this.canalAnterior;
                this.canalAnterior = this.canal;
                this.canal = canalTemp;
                Console.WriteLine("Canal: " + canal.ToString());
                Console.WriteLine("----------------------------------");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
            }
        }

        /**
         * Metodo para imprimir el estado de la television
         */
        public void estadoActual()
        {
            if (this.onOff)
            {
                Console.WriteLine("Estado: {0}", onOff ? "Encendida" : "Apagada");
                Console.WriteLine("Canal: " + this.canal +
                    "\nVolumen: " + this.volumen);
                Console.WriteLine("----------------------------------");
            }
            else
            {
                Console.WriteLine("La televison esta apagada");
                Console.WriteLine("----------------------------------");
            }
        }

        /**
         * Metodo para imprimir toda la informacion de la television
         */
        public void informacionTécnica()
        {
            Console.OutputEncoding = Encoding.UTF8; //Permite la entrada del caracter €
            Console.WriteLine("Marca: " + this.marca +
                "\nPulgadas: " + this.pulgadas + '\"' +
                "\nConsumo: " + this.consumo + "w" +
                "\nPrecio: " + this.precio + "€");
            Console.WriteLine("Estado: {0}", onOff ? "Encendida" : "Apagada");
            Console.WriteLine("Canal: " + this.canal +
                "\nCanal Anterior: " + this.canalAnterior +
                "\nVolumen: " + this.volumen);
            Console.WriteLine("----------------------------------");
        }
    }
}
