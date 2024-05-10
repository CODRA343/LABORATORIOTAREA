// See https://aka.ms/new-console-template for more information
using System;

public class Piramide
{
    public static void ImprimirPiramide(int altura)
    {
        if (altura > 0)
        {
            // Agrega espacios en blanco iniciales para centrar la pirámide (ajusta el espaciado según sea necesario)
            Console.Write(new String(' ', altura - 1));

            // Imprime el número con un espacio delante
            Console.Write("{0} ", altura);

            // Pasa a la siguiente línea después de imprimir
            Console.WriteLine();

            // Llamadas recursivas para imprimir los lados izquierdo y derecho
            ImprimirPiramide(altura - 1);
            ImprimirPiramide(altura - 1);
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Ingrese la altura de la pirámide: ");
        int altura = int.Parse(Console.ReadLine());

        ImprimirPiramide(altura);

        Console.ReadKey(true); // Espera a que se presione una tecla antes de cerrar (opcional)
    }
}
