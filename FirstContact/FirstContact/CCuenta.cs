using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstContact{
    // Definición de la clase Cuenta
    class CCuenta{
        // Atributos
        private string nombre;
        private string cuenta;
        private double saldo;
        private double tipoDeInterés;

        // Métodos (Constructor sobrecargado)
        public CCuenta() { }

        public CCuenta(string nom, string cue, double sal, double tipo){
            asignarNombre(nom);
            asignarCuenta(cue);
            ingreso(sal);
            asignarTipoDeInterés(tipo);
        }

        ~CCuenta(){
            // Operaciones de limpieza
            System.Console.WriteLine("Je, je, je. Destruyendo la cuenta de " + this.obtenerNombre());
        }

        public void asignarNombre(string nom){
            if (nom == null || nom.Length == 0)
            {
                System.Console.WriteLine("Error: cadena vacía");
                return;
            }
            nombre = nom;
        }

        public string obtenerNombre(){
            return nombre;
        }

        public void asignarCuenta(string cue){
            if (cue == null || cue.Length == 0)
            {
                System.Console.WriteLine("Error: cuenta no válida");
                return;
            }
            cuenta = cue;
        }

        public string obtenerCuenta(){
            return cuenta;
        }

        public double estado(){
            return saldo;
        }

        public void ingreso(double cantidad){
            if (cantidad < 0)
            {
                System.Console.WriteLine("Error: cantidad negativa");
                return;
            }
            saldo = saldo + cantidad;
        }

        public void reintegro(double cantidad){
            if (saldo - cantidad < 0)
            {
                System.Console.WriteLine("Error: no dispone de saldo");
                return;
            }
            saldo = saldo - cantidad;
        }

        public void asignarTipoDeInterés(double tipo){
            if (tipo < 0)
            {
                System.Console.WriteLine("Error: tipo no válido");
                return;
            }
            tipoDeInterés = tipo;
        }

        public double obtenerTipoDeInterés(){
            return tipoDeInterés;
        }
    }
}
