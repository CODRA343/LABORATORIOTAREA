////Recursividad:
////1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100.

//int Imprime(int a)
//{
//    if (a <= 100)
//    {
//        int valor = 1 + Imprime(a + 1);
//        if (a % 2 == 0)
//        {
//            Console.WriteLine(valor);
//        }
//        return valor;
//    }
//    else
//        return 1;
//}
//Imprime(1);
//Console.ReadKey();

////2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n.

Console.Write("Ingrese un numero entero positivo: ");
int a = int.Parse(Console.ReadLine());
int sumatoria(int a)
{
    if (a > 0)
    {
        int valor = a + sumatoria(a - 1);
        return valor;
    }
    else
        return 0;
}
int v = sumatoria(a);
Console.WriteLine("La suma es " + v);
Console.ReadKey();

////3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n.

//int Piramide(int a)
//{
//    if (a > 0)
//    {
//        Console.Write(new string(' ', a - 1));
//        Console.Write("{0} ", a);
//        Console.WriteLine();
//        Piramide(a - 1);
//        Piramide(a - 1);
//        return 0;
//    }
//    else
//        return 0;
//}
//Piramide(5);
//Console.ReadKey();

////4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.



////5) Ejercicio 5: Escribe una función recursiva que imprima la tabla de multiplicar del n.

//Console.WriteLine("Ingrese un número para generar su tabla de multiplicar hasta el mismo número");
//Console.Write("Ingrese el número: ");
//int numeromul = int.Parse(Console.ReadLine());
//Console.WriteLine("Tabla de multiplicar del {0}:", numeromul);
//for (int x = 1; x <= numeromul; x++)
//{
//    int resultado = numeromul * x;
//    Console.WriteLine("{0} x {1} = {2}", numeromul, x, resultado);
//}
//Console.ReadLine();

//Arreglos y Matrices:

////6) Crea una matriz de números reales.

//using System.Numerics;

//double[,] numerosReales;
//numerosReales = new double[2, 3];
//numerosReales[0, 0] = 3.14;
//numerosReales[0, 1] = -2.5;
//numerosReales[0, 2] = 0.0;
//numerosReales[1, 0] = 1.23;
//numerosReales[1, 1] = 7.65;
//numerosReales[1, 2] = 4.65;

//for (int fila = 0; fila < numerosReales.GetLength(0); fila++)
//{
//    for (int columna = 0; columna < numerosReales.GetLength(1); columna++)
//    {
//        Console.Write(numerosReales[fila, columna] + " ");
//    }
//    Console.WriteLine();
//}

////7) Crea una matriz de números complejos.

//Complex[,] númeroscomplejos;
//númeroscomplejos = new Complex[2, 3];
//númeroscomplejos[0, 0] = new Complex(1.0, 2.0);
//númeroscomplejos[0, 1] = new Complex(7.8, 2.4);
//númeroscomplejos[0, 2] = new Complex(5.3, -4.5);
//númeroscomplejos[1, 0] = new Complex(1.34, 2.14);
//númeroscomplejos[1, 1] = new Complex(-1.4, 0.0);
//númeroscomplejos[1, 2] = new Complex(0.0, -8.9);

//for (int filac = 0; filac < númeroscomplejos.GetLength(0); filac++)
//{
//    for (int columnac = 0; columnac < númeroscomplejos.GetLength(1); columnac++)
//    {
//        Console.Write(númeroscomplejos[filac, columnac] + " ");
//    }
//    Console.WriteLine();
//}

////8) Crea una matriz de matrices.

//int[][] matriz = new int[4][] {
//    new int[] {12, 34, 23},
//    new int[] {25, 34, 23},
//    new int[] {21, 13, 22},
//    new int[] {13, 17, 19},
//};
//for (int i = 0; i < matriz.Length; i++)
//{
//    for (int j = 0; j < matriz[i].Length; j++)
//    {
//        Console.Write(matriz[i][j] + " ");
//    }
//    Console.WriteLine();
//}
////9) Accede al elemento central de una matriz.

//int[,] matriz =
//    {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//    };
//int filas = matriz.GetLength(0);
//int columnas = matriz.GetLength(1);
//int indiceFilaCentral = (filas - 1) / 2;
//int indiceColumnaCentral = (columnas - 1) / 2;
//int elementoCentral = matriz[indiceFilaCentral, indiceColumnaCentral];
//Console.WriteLine("Elemento central: {0}", elementoCentral);

////10) Suma dos matrices de diferentes tamaños.
////11) Multiplica una matriz por un número.
////12) Calcula la media de los elementos de una matriz.

////Ejercicio Matrices:

////Ejercicio 1: Crea una matriz de números aleatorios de tamaño 100x100.

//int[,] MatrizAleatorioN = new int[100, 100];
//Random r = new Random();
//for (int i = 0; i < 100; i++)
//{
//    for (int j = 0; j < 100; j++)
//    {
//        MatrizAleatorioN[i, j] = r.Next(1, 9);
//        Console.Write(MatrizAleatorioN[i, j]);
//    }
//    Console.WriteLine(" ");
//}

////Ejercicio 2: Calcula la media, la mediana y la desviación estándar de los elementos de una matriz.

//Console.WriteLine("======================Calcular : media,mediana,desviacion estandar============");
//double media, mediana, desEstabdar;
//int[,] Matriz = new int[6, 6];
//media = 0;
//int longitudM = Matriz.Length;
//Random t = new Random();
//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        Matriz[i, j] = t.Next(1, 9);
//        Console.Write(Matriz[i, j]);
//    }
//    Console.WriteLine();
//}
//Console.Read();
//for (int a = 0; a < 6; a++)
//    for (int b = 0; b < 6; b++)
//    {
//        media += Matriz[a, b];

//    }
//{
//}
//double resultado = media / longitudM;
//Console.WriteLine("La media es: " + Math.Round(resultado, 2));
//List<int> lista = new List<int>();
//int filas = Matriz.GetLength(0);
//int columnas = Matriz.GetLength(1);
//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        lista.Add(Matriz[i, j]);
//    }
//}
//lista.Sort();
//int lonLista = lista.Count;

//if (lonLista % 2 == 0)
//{
//    double sumaMedia = (lista[(lonLista / 2) - 1] + lista[(lonLista / 2)]);
//    mediana = sumaMedia / 2;

//    Console.WriteLine("La mediana es :" + mediana);

//}
//else
//{
//    mediana = lista[(lonLista / 2)];
//    Console.WriteLine("La mediana es :" + mediana);

//}
//double sumaCuadrados = lista.Sum(x => Math.Pow(x - mediana, 2));
//double varianza = Math.Round((sumaCuadrados / (lonLista - 1)), 4);
//desEstabdar = Math.Sqrt(varianza);
//Console.WriteLine("La desviacion estandar es: " + Math.Round(desEstabdar, 4));
//Console.WriteLine(" ============== Fin del programa===============");

////Ejercicio 3: Escribe una función que encuentre el elemento máximo de una matriz.

//int[,] MatrizA = new int[4, 4];
//Random t = new Random();
//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        MatrizA[i, j] = t.Next(1, 200);
//        Console.Write(MatrizA[i, j] + " ");
//    }
//    Console.WriteLine(" ");
//}
//Console.Read();
//int elementoMayorMatriz(int[,] MatrizA)
//{
//    int elementoMayor = int.MinValue;
//    int f, c;
//    f = MatrizA.GetLength(0);
//    c = MatrizA.GetLength(1);
//    Console.WriteLine("f" + f);
//    Console.WriteLine("c" + c);
//    for (int i = 0; i < f; i++)
//    {
//        for (int j = 0; j < c; j++)
//        {
//            if (MatrizA[i, j] > elementoMayor)
//                elementoMayor = MatrizA[i, j];
//        }
//    }
//    return elementoMayor;
//}
//int max = elementoMayorMatriz(MatrizA);
//Console.WriteLine("El elemento maximo o mayor de la matriz es :" + max);

//Ejercicio 4: Escribe una función que encuentre la submatriz de mayor suma de una matriz.
//Ejercicio 5: Escribe una función que encuentre la matriz de covarianza de dos matrices.