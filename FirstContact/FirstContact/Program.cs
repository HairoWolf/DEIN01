// Versión 1.1
class Ejemplo37Bis{
    public static void Maain(string[] args){
        System.Console.WriteLine("Elige que operacion realizar (+)sumar (-)restar");
        char tipo_op = Convert.ToChar(Console.ReadLine());
        System.Console.WriteLine("Escribe un número");
        double v1 = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Escribe otro número");
        double v2 = Convert.ToDouble(Console.ReadLine());
        if (calcular(tipo_op, v1, v2) != System.Double.MaxValue)
            System.Console.WriteLine("{0} {1} {2} = {3}", v1, tipo_op, v2, calcular(tipo_op,
            v1, v2));
        else
            System.Console.WriteLine("La operación no es válida...");
        //System.Console.ReadLine();
    }
    public static double calcular(char c, double op1, double op2){
        if (c == '+')
            return op1 + op2;
        if (c == '-')
            return op1 - op2;
        else
            return System.Double.MaxValue;
    }
}
