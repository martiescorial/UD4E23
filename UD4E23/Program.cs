using System;

namespace UD4E23
{
    class Program
    {
        static void Main(string[] args)
        {
            double operando1;
            double operando2;
            double resultado = 0;

            //Nos pide los operandos y el signo de operacion
            String texto = "Escribe el operando 1";
            operando1 = Convert.ToInt32(texto);

            String operacion = "Escribe el codigo de operacion";

            String texto2 = "Escribe el operando 2";
            operando2 = Convert.ToInt32(texto2);

            //segun el codigo de operacion, haremos una u otra accion
            switch (operacion)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "/":
                    resultado = operando1 / operando2;
                    break;
                case "^":
                    resultado = (int)Math.Pow(operando1, operando2);
                    break;
                case "%":
                    resultado = operando1 % operando2;
                    break;
            }

            Console.WriteLine(null, operando1 + " " + operacion + " " + operando2 + " = " + resultado);

        }
    }
}
