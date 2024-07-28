using System;
using System.Diagnostics;
using System.Formats.Tar;
using System.Security.Cryptography.X509Certificates;
goto inicio;
#region "Salas"
inicio:
{
    Console.Clear();
    Console.WriteLine("Uma calculadora simples em C#");
    Console.WriteLine();
    Console.WriteLine("1. Multiplicação");
    Console.WriteLine("2. Adição");
    Console.WriteLine("3. Subtração");
    Console.WriteLine("4. Divisão");
    Console.WriteLine("5. Bhaskara");
    Console.WriteLine("6. Potenciação");
    Console.WriteLine("7. Raiz Quadrada");
    Console.Write("Escolha: ");
    int acion = int.Parse(Console.ReadLine()!);
    switch (acion)
    {
        case 1:
            goto multi;
        case 2:
            goto adit;
        case 3:
            goto sub;
        case 4:
            goto div;
        case 5:
            goto bhas;
        case 6:
            goto pot;
        case 7:
            goto raz;
    }
}
multi:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor do multiplicando");
    float A1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor do multiplicador");
    float B1 = float.Parse(Console.ReadLine()!);
    multiplicar(A1, B1);
    Console.ReadLine();
    goto inicio;
}
sub:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor do minuendo");
    float A1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor do subtraendo");
    float B1 = float.Parse(Console.ReadLine()!);
    subtrair(A1, B1);
    Console.ReadLine();
    goto inicio;
}
adit:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor da 1ª parcela");
    float A1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor da 2ª parcela");
    float B1 = float.Parse(Console.ReadLine()!);
    adicionar(A1, B1);
    Console.ReadLine();
    goto inicio;
}
div:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor do dividendo");
    float A1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor do divisor");
    float B1 = float.Parse(Console.ReadLine()!);
    dividir(A1, B1);
    Console.ReadLine();
    goto inicio;
}
bhas:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor de A");
    int A1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor de B");
    int B1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor de C");
    int C1 = int.Parse(Console.ReadLine()!);
    baskara(A1, B1, C1);
    Console.ReadLine();
    goto inicio;
}
pot:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor da base");
    int A1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor do expoente");
    int B1 = int.Parse(Console.ReadLine()!);
    potencia(A1, B1);
    Console.ReadLine();
    goto inicio;
}
raz:
{
    Console.Clear();
    Console.WriteLine("Escreva o número da qual quer a raiz");
    float A1 = float.Parse(Console.ReadLine()!);
    raiz(A1);
    Console.ReadLine();
    goto inicio;
}
#endregion
static void baskara(int A, int B, int C)
{
    double delta = Math.Sqrt((B * B) - (4 * A * C));
    double x1 = (-B + (delta)) / (2 * A);
    double x2 = (-B - (delta)) / (2 * A);
    Console.WriteLine("X´ = " + x1);
    Console.WriteLine("X´´ = " + x2);
};
static void subtrair(float A, float B)
{
    float resultado = A - B;
    Console.WriteLine("O resto é " + resultado);
};
static void multiplicar(float A, float B)
{
    float resultado = (A * B);
    Console.WriteLine("O produto é " + resultado);
};
static void dividir(float A, float B)
{
    float resultado = (A / B);
    Console.WriteLine("O quociente é " + resultado);
};
static void adicionar(float A, float B)
{
    float resultado = A + B;
    Console.WriteLine("O total é " + resultado);
};
static void potencia(int A, int B)
{
    double val = Math.Pow(A, B);
    Console.WriteLine("O valor da potencia é " + val);
}
static void raiz(float A)
{
    double resultado = (Math.Sqrt(A));
    Console.WriteLine("A raiz é " + resultado);
}