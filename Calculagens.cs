using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculagi
{
    internal class Calc
    {
        public static string[] baskara(int[] ABC)
        {
            int delta = ((ABC[1] * ABC[1]) - (4 * ABC[0] * ABC[2]));
            double rdelta = 0;
            if (delta < 0)
            {
                throw new ArgumentException("Número negativo não tem raiz, isso aí tá errado:", nameof(delta));
            }
            rdelta = double.Parse(raiz(delta));
            double x1 = (-ABC[2] + (rdelta)) / (2 * ABC[0]);
            double x2 = (-ABC[2] - (rdelta)) / (2 * ABC[0]);
            string[] resultado = { Convert.ToString(x1), Convert.ToString(x2) };
            return resultado;
        }
        public static string subtrair(float[] num)
        {
            float yul = num[0];
            for (int i = 1; i < (num.Length); i++)
            {
                //Console.WriteLine($"{yul} - {num[i]} = {yul - num[i]}");
                yul = (yul - num[i]);
            };
            return Convert.ToString(yul);
        }
        public static string multiplicar(BigInteger[] num)
        {
            BigInteger yul = 1;
            for (int i = 0; i < (num.Length); i++)
            {
                //Console.WriteLine($"{yul} * {num[i]} = {yul * num[i]}");
                yul = (yul * num[i]);
            };
            return Convert.ToString(yul)!;
        }
        public static string dividir(float[] AB)
        {
            float yul = AB[0];
            int i;
            for (i = 1; i < (AB.Length); i = 1 + i)
            {
                //Console.WriteLine($"{yul} / {AB[i]} = {yul / AB[i]}");
                yul = yul / AB[i];
            }
            return Convert.ToString(yul);
        }
        public static string adicionar(float[] num)
        {
            float yul = 0;
            for (int i = 0; i < (num.Length); i++)
            {
                //Console.WriteLine($"{yul} + {num[i]} = {yul + num[i]}");
                yul = (yul + num[i]);
            }
            return Convert.ToString(yul);
        }
        public static string potencia(int[] Dou)
        {
            BigInteger F2 = Dou[0];
            for (int i = 1; i < Dou[1]; Dou[1]--)
            {
                F2 = F2 * Dou[0];
            }
            return Convert.ToString(F2)!;
        }
        public static string raiz(int A)
        {
            if (A < 0)
            {
                Console.WriteLine("Número negativo não tem raiz, convertendo para número positivo");
            }
            int A2 = Math.Abs(A);
            double C = 1e-10;
            double B = A2 / 2.0;
            while (Math.Abs(B * B - A2) > C)
            {
                B = (B + A2 / B) / 2.0;
            }
            return Convert.ToString(B);
        }
        public static string porcentagem(float[] AB)
        { //Sim, eu sei que eu poderia ter feito isso usando o "%"
            float resultado = ((AB[0] * AB[1]) / 100);
            return Convert.ToString(resultado);
        }
        public static string aria_circulo(float raio)
        {
            double resposta = (3.14 * (raio * raio));
            return Convert.ToString(resposta);
        }
        public static string aria_trianlos(float[] basalt)
        {
            float resultado = ((basalt[0] * basalt[1]) / 2);
            return Convert.ToString(resultado);
        }
        public static string aria_retangulo(float[] basalt)
        {
            float resultado = (basalt[0] * basalt[1]);
            return Convert.ToString(resultado);
        }
        public static string aria_trapezio(float[] Bba)
        {
            float resultado = (((Bba[0] + (Bba[1]) * Bba[2])) / 2);
            return Convert.ToString(resultado);
        }
        public static string fatorial(BigInteger F)
        {
            BigInteger F2 = F;
            for (BigInteger i = F; i > 1; i--)
            {
                //Console.WriteLine($"{F2} * {F -1} = {F2 * (F -1)}");
                F2 = F2 * ((F - 1));
                F = F - 1;
            };
            return Convert.ToString(F2)!;
        }
        public static string imc(float[] deta)
        {
            /* Param: detalhes[0] é altura, detalhes[1] é peso
             * div = altura * altura
             * Calc: (peso / div)
            */
            double resultado = (deta[1] / (deta[0] * deta[0]));
            return Convert.ToString(resultado);
        }
    }
}