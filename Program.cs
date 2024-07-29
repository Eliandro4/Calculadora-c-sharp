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
    Console.WriteLine("8. Porcentagem");
    Console.WriteLine("9. Area do Circulo");
    Console.WriteLine("10. Area do Triangulo");
    Console.WriteLine("11. Area do Retangulo");
    Console.WriteLine("12. Area do Trapezio");
    Console.WriteLine("13. Area do Losangulo");
    Console.WriteLine("14. Fatorial");
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
        case 8:
            goto porc;
        case 9:
            goto arcir;
        case 10:
            goto artri;
        case 11:
            goto arret;
        case 12:
            goto artra;
        case 13:
            goto arlos;
        case 14:
            goto fato;
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
porc:
{
    Console.Clear();
    Console.WriteLine("Escreva a porcentagem");
    float A1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor da qual quer pegar a porcentagem");
    float B1 = float.Parse(Console.ReadLine()!);
    porcentagem(A1, B1);
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
arcir:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor do raio");
    float A1 = float.Parse(Console.ReadLine()!);
    aria_circulo(A1);
    Console.ReadLine();
    goto inicio;
};
artri:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor da base");
    float B1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor da altura");
    float H1 = float.Parse(Console.ReadLine()!);
    aria_triangulo(B1, H1);
    Console.ReadLine();
    goto inicio;
};
arret:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor da base");
    float B1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor da altura");
    float H1 = float.Parse(Console.ReadLine()!);
    aria_retangulo(B1, H1);
    Console.ReadLine();
    goto inicio;
};
artra:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor da base maior");
    float B1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor da base menor");
    float B2 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor da altura");
    float A1 = float.Parse(Console.ReadLine()!);
    aria_trapezio(B1, B2, A1);
    Console.ReadLine();
    goto inicio;
};
arlos:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor da diagonal menor");
    float D1 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Escreva o valor da diagonal maior");
    float D2 = float.Parse(Console.ReadLine()!);
    aria_losango(D1, D2);
    Console.ReadLine();
    goto inicio;
};
fato:
{
    Console.Clear();
    Console.WriteLine("Escreva o valor da base");
    int F1 = Math.Abs(int.Parse(Console.ReadLine()!));
    int F2 = fatorial(F1);
    Console.WriteLine("O fatorial de " + F1 + " é " + F2);
    Console.ReadLine();
    goto inicio;
};
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
static void porcentagem(float A, float B)
{ //Sim, eu sei que eu poderia ter feito isso usando o "%"
    float resultado = ((A / B) * 100);
    Console.WriteLine("O resultado é " + resultado);
};
static void aria_circulo(float raio)
{
    double resposta = (3.14 * Math.Pow(raio, raio));
    Console.WriteLine("A area do círulo é " + resposta);
};
static void aria_triangulo(float basio, float altura)
{
    float resultado = ((basio * altura) / 2);
    Console.WriteLine("A area do triangulo é " + resultado);
};
static void aria_retangulo(float basio, float altura)
{
    float resultado = (basio * altura);
    Console.WriteLine("A area do retângulo é " + resultado);
};
static void aria_trapezio(float bmaior, float bmenor, float altura)
{
    float resultado = (((bmaior + bmenor) * altura) / 2);
    Console.WriteLine("A area do trapezio é " + resultado);
};
static void aria_losango(float dmenor, float dmaior)
{
    float resultado = ((dmaior * dmenor) / 2);
    Console.WriteLine("A area do losango é " + resultado);
};
static int fatorial(int F)
{
    int F2 = F;
    for (int i = F; i > 1; i--)
        {
            F2 = F2 * ((F - 1));
            F = F - 1;
        };
    return F2;
};