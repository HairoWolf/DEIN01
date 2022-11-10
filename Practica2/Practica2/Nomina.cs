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
    class Nomina
    {
        #region Campos de clase
        private Empleado empleadoNomina;
        private DateTime fechaNomina;
        private int numHorasExtra;
        private int porcentajeIRPF;
        #endregion

        /**
         * Constructor de clase con 3 parametros
         */
        public Nomina(Empleado empleadoNomina, DateTime fechaNomina, int numHorasExtra)
        {
            this.empleadoNomina = empleadoNomina;
            this.fechaNomina = fechaNomina;
            this.numHorasExtra = numHorasExtra;
            switch (this.empleadoNomina.Categoria)
            {
                case 1:
                    this.porcentajeIRPF = 18 - this.empleadoNomina.NumHijos;
                    break;
                case 2:
                    this.porcentajeIRPF = 15 - this.empleadoNomina.NumHijos;
                    break;
                case 3:
                    this.porcentajeIRPF = 12 - this.empleadoNomina.NumHijos;
                    break;
            }
        }

        /**
         * Constructor de clase predefinido
         */
        public Nomina()
        {
            this.empleadoNomina = new Empleado();
            this.fechaNomina = DateTime.Now;
            this.numHorasExtra = 0;
        }

        public double baseCotizacion()
        {
            return devengosPagaExtra() + devengosPagaExtra() / 6;
        }

        public double cotizacionSegDes()
        {
            return devengosPagaExtra() * 1.97 / 100;
        }

        public double cotizacionSegSoc()
        {
            return baseCotizacion() * 4.51 / 100;
        }

        public double devengosPagaExtra()
        {
            return this.empleadoNomina.SalarioBase + importeAntiguedad();
        }

        public void hojaSalarial()
        {
            Console.Clear();
            Console.WriteLine("HOJA SALARIAL \n");
            Console.WriteLine("LIQUIDACIÓN DE HABERES AL " + this.fechaNomina);
            Console.WriteLine("Nombre........: " + this.empleadoNomina.Nombre);
            Console.WriteLine("NIF...........: " + this.empleadoNomina.Nif);
            Console.WriteLine("Categoría.....: " + this.empleadoNomina.Categoria);
            Console.WriteLine("Nº de Trienios: " + this.empleadoNomina.NumTrienios);
            Console.WriteLine("Nº de Hijos...: " + this.empleadoNomina.NumHijos);
            Console.WriteLine("DEVENGOS \t\t  DESCUENTOS");
            Console.WriteLine("-------- \t\t  ----------");
            Console.WriteLine("Salario base " + this.empleadoNomina.SalarioBase + " \t Cotización Seg.Soc. " + cotizacionSegSoc());
            Console.WriteLine("Antigüedad " + importeAntiguedad() + " \t\t Cotización Seg.Des. " + cotizacionSegDes());
            Console.WriteLine("Importe Hor.Ext. " + importeHorasExtras() + " \t Retención IRPF " + retencionIRPF());
            Console.WriteLine("Paga Extra " + devengosPagaExtra() + "\n");
            Console.WriteLine("Total Devengos " + (totalDevengado() + devengosPagaExtra()) + " \t Total Descuentos " + totalDescuentos() + "\n");
            Console.WriteLine("----------------------------");
            Console.WriteLine("LIQUIDO A PERCIBIR " + liquido());
            Console.WriteLine("--------------------------------------------------");
        }

        public double importeAntiguedad()
        {
            return this.empleadoNomina.NumTrienios * this.empleadoNomina.SalarioBase * 4 / 100;
        }

        public double importeHorasExtras()
        {
            return this.numHorasExtra * this.empleadoNomina.SalarioBase * 1 / 100;
        }

        public double retencionIRPF()
        {
            if(this.fechaNomina.Month == 12 || this.fechaNomina.Month == 6)
            {
                return (totalDevengado() + devengosPagaExtra()) * this.porcentajeIRPF / 100;
            }
            else
            {
                return totalDevengado() * this.porcentajeIRPF / 100;
            }
        }

        public double liquido()
        {
            if (this.fechaNomina.Month == 12 || this.fechaNomina.Month == 6)
            {
                return totalDevengado() + devengosPagaExtra() - totalDescuentos();
            }
            else
            {
                return totalDevengado() - totalDescuentos();
            }
        }

        public double totalDescuentos()
        {
            return cotizacionSegSoc() + cotizacionSegDes() + retencionIRPF();
        }

        public double totalDevengado()
        {
            return this.empleadoNomina.SalarioBase + importeAntiguedad() + importeHorasExtras();
        }
    }
}
