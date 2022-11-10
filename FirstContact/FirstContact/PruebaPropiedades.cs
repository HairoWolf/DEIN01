using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstContact
{
    class PruebaPropiedades
    {
        public static void Main(string[] args)
        {
            CCuenta c05 = new CCuenta();
            c05.asignarNombre("Feliciana");
            c05.asignarCuenta("987341208");
            c05.asignarTipoDeInterés(2.5);
            c05.ingreso(250);
            c05.reintegro(50);
            System.Console.WriteLine(c05.obtenerNombre());
            System.Console.WriteLine(c05.obtenerCuenta());
            System.Console.WriteLine(c05.estado());
            System.Console.WriteLine(c05.obtenerTipoDeInterés());
        }
    }

}
