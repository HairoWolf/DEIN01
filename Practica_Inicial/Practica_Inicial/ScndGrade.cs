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
    class ScndGrade
    {
        #region Campos sobre los que se va a hacer la ecuacion de Segundo Grado
        private double a, b, c;
        #endregion

        public ScndGrade(double a, double b, double c)
        {
            this.a = a; 
            this.b = b; 
            this.c = c;
        }

        public void calcular()
        {
            #region Campos calculados
            string rNegativa, rPositiva;
            double radicando;
            #endregion

            Console.WriteLine("Ecuación: " + a + "x\xB2+" + b + "b+" + c);
            radicando = (Math.Pow(b, 2) - 4 * a * c);
            if (radicando >= 0)
            {
                rNegativa = ((-b - Math.Sqrt(radicando)) / (2 * a)).ToString("0.###");
                rPositiva = ((-b + Math.Sqrt(radicando)) / (2 * a)).ToString("0.###"); ;
            }
            else
            {
                radicando = -radicando;
                rNegativa = -b / 2 + "-" + (((Math.Sqrt(radicando)) / 2) + "i");
                rPositiva = -b / 2 + "+" + (((Math.Sqrt(radicando)) / 2) + "i");
            }
            Console.WriteLine("Resultado 1 ==> " + rPositiva);
            Console.WriteLine("Resultado 2 ==> " + rNegativa);
        }
    }
}
