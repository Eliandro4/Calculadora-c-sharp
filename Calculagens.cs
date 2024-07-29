using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculagi
{
    internal class Calc
    {
        public static void baskara(int A, int B, int C, out double x1, out double x2)
        {
            double delta = Math.Sqrt((B * B) - (4 * A * C));
            x1 = (-B + (delta)) / (2 * A);
            x2 = (-B - (delta)) / (2 * A);
        }
        public static float subtrair(float A, float B)
        {
            float resultado = A - B;
            return resultado;
        }
        public static float multiplicar(float A, float B)
        {
            float resultado = (A * B);
            return resultado;
        }
        public static float dividir(float A, float B)
        {
            float resultado = (A / B);
            return resultado;
        }
        public static float adicionar(float A, float B)
        {
            float resultado = A + B;
            return resultado;
        }
        public static double potencia(int A, int B)
        {
            double val = Math.Pow(A, B);
            return val;
        }
        public static double raiz(float A)
        {
            double resultado = (Math.Sqrt(A));
            return resultado;
        }
        public static float porcentagem(float A, float B)
        { //Sim, eu sei que eu poderia ter feito isso usando o "%"
            float resultado = ((A / B) * 100);
            return resultado;
        }
        public static double aria_circulo(float raio)
        {
            double resposta = (3.14 * Math.Pow(raio, raio));
            return resposta;
        }
        public static float aria_triangulo(float basio, float altura)
        {
            float resultado = ((basio * altura) / 2);
            return resultado;
        }
        public static float aria_retangulo(float basio, float altura)
        {
            float resultado = (basio * altura);
            return resultado;
        }
        public static float aria_trapezio(float bmaior, float bmenor, float altura)
        {
            float resultado = (((bmaior + bmenor) * altura) / 2);
            return resultado;
        }
        public static float aria_losango(float dmenor, float dmaior)
        {
            float resultado = ((dmaior * dmenor) / 2);
            return resultado;
        }
        public static int fatorial(int F)
        {
            int F2 = F;
            for (int i = F; i > 1; i--)
            {
                F2 = F2 * ((F - 1));
                F = F - 1;
            };
            return F2;
        }
    }
}
