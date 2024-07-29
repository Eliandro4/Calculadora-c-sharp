using System;
using System.Diagnostics;
using System.Formats.Tar;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CalculadoraC_
{
    internal class Ito
    {
        static void Main()
        {
        goto inicio;
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
                float R = Calculagi.Calc.multiplicar(A1, B1);
                Console.WriteLine("O produto é " + R);
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
                float R = Calculagi.Calc.subtrair(A1, B1);
                Console.WriteLine("O resto é " + R);
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
                double R = Calculagi.Calc.adicionar(A1, B1);
                Console.WriteLine("O total é " + R);
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
                double R = Calculagi.Calc.dividir(A1, B1);
                Console.WriteLine("O quociente é " + R);
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
                float R = Calculagi.Calc.porcentagem(A1, B1);
                Console.WriteLine("O resultado é " + R);
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
                Calculagi.Calc.baskara(A1, B1, C1, out double x1, out double x2); //x1 e x2 sendo declarada aqui, pq sim
                Console.WriteLine("X´ = " + x1);
                Console.WriteLine("X´´ = " + x2);
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
                double R = Calculagi.Calc.potencia(A1, B1);
                Console.WriteLine("O valor da potencia é " + R);
                Console.ReadLine();
                goto inicio;
            }
        raz:
            {
                Console.Clear();
                Console.WriteLine("Escreva o número da qual quer a raiz");
                float A1 = float.Parse(Console.ReadLine()!);
                double R = Calculagi.Calc.raiz(A1);
                Console.WriteLine("A raiz é " + R);
                Console.ReadLine();
                goto inicio;
            }
        arcir:
            {
                Console.Clear();
                Console.WriteLine("Escreva o valor do raio");
                float A1 = float.Parse(Console.ReadLine()!);
                double R = Calculagi.Calc.aria_circulo(A1);
                Console.WriteLine("A area do círulo é " + R);
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
                float R = Calculagi.Calc.aria_triangulo(B1, H1);
                Console.WriteLine("A area do triangulo é " + R);
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
                float R = Calculagi.Calc.aria_retangulo(B1, H1);
                Console.WriteLine("A area do retângulo é " + R);
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
                float R = Calculagi.Calc.aria_trapezio(B1, B2, A1);
                Console.WriteLine("A area do trapezio é " + R);
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
                float D3 = Calculagi.Calc.aria_losango(D1, D2);
                Console.WriteLine("A area do losango é " + D3);
                Console.ReadLine();
                goto inicio;
            };
        fato:
            {
                Console.Clear();
                Console.WriteLine("Escreva o valor da base");
                int F1 = Math.Abs(int.Parse(Console.ReadLine()!));
                int F2 = Calculagi.Calc.fatorial(F1);
                Console.WriteLine("O fatorial de " + F1 + " é " + F2);
                Console.ReadLine();
                goto inicio;
            };
        }
    }
}