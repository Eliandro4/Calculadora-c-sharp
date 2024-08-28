using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Tar;
using System.Net.Security;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Calculagi;
using Microsoft.VisualBasic;

namespace Calculadora
{
    internal class Ito
    {
        static void Main(string[] args0)
        {
            if (args0.Length > 0)
            {
                float[] args = new float[(args0.Length - 1)];
                BigInteger[] armos = new BigInteger[(args0.Length - 1)];
                int[] amios = new int[(args0.Length - 1)];
                string[] R = new string[2];
                bool nas = false;
                Vero.Very very = new Vero.Very();
                very.exec(args0[0], args0, armos, args, amios, out armos, out args, out amios);
                very = null!;
                switch (args0[0])
                {
                    case "-1":
                        R[0] = Calc.multiplicar(armos); // A * B A/B
                        nas = true;
                        break;
                    case "-2":
                        R[0] = Calc.adicionar(args); // A + B A/B
                        nas = true;
                        break;
                    case "-3":
                        if (args.Length > 0)
                        {
                            R[0] = Calc.subtrair(args); // A - B A/B
                            nas = true;
                        }
                        break;
                    case "-4":
                        if (args.Length > 0)
                        {
                            R[0] = Calc.dividir(args); // A : B A/B
                            nas = true;
                        }
                        break;
                    case "-5":
                        if (args.Length == 3)
                        {
                            R = Calc.baskara(amios); // ((B +- √[B² - 4 * A * C]) /2) A/B/C/X1/X2
                        }
                        break;
                    case "-6":
                        if (args.Length == 2)
                        {
                            R[0] = Calc.potencia(amios); // A elevado a B
                            nas = true;
                        }
                        break;
                    case "-7":
                        if (args.Length == 1)
                        {
                            R[0] = Calc.raiz(amios[0]); //Pega a raiz quadrada de A
                            nas = true;
                        }
                        break;
                    case "-8":
                        if (args.Length == 2)
                        {
                            R[0] = Calc.porcentagem(args);
                            nas = true;
                        }
                        break;
                    case "-9":
                        if (args.Length == 1)
                        {
                            R[0] = Calc.aria_circulo(args[0]);
                            nas = true;
                        }
                        break;
                    case "-10":
                        if (args.Length == 2)
                        {
                            R[0] = Calc.aria_trianlos(args);
                            nas = true;
                        }
                        break;
                    case "-11":
                        if (args.Length == 2)
                        {
                            R[0] = Calc.aria_retangulo(args);
                            nas = true;
                        }
                        break;
                    case "-12":
                        if (args.Length == 3)
                        {
                            R[0] = Calc.aria_trapezio(args);
                            nas = true;
                        }
                        break;
                    case "-13":
                        if (args.Length == 1)
                        {
                            R[0] = Calc.fatorial(armos[0]);
                            nas = true;
                        }
                        break;
                    case "-14":
                        if (args.Length == 2)
                        {
                            R[0] = Calc.imc(args);
                            nas = true;
                        }
                        break;
                };
                if (args0[0] == "-5")
                {
                    Console.WriteLine("X´ = " + R[0]);
                    Console.WriteLine("X´´ = " + R[1]);
                }
                else if (args0[0] == "-h")
                {
                    int i = 0;
                    string[] msg = { "Multiplicação", "Adição", "Subtração", "Divisão", "Equação Segundo Grau", "Potenciação", "Raiz Quadrada", "Porcentagem", "Área do Círculo", "Área do Triangulo / Losango", "Área do Retângulo", "Área do Trapezio", "Fatorial", "IMC", "Mostra essa msg" };
                    string[] paramdeta = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                    foreach (string ms in msg)
                    {
                        if (i < 14)
                        {
                            Console.WriteLine($"\"-{i + 1}\". {msg[i]} ({paramdeta[i]})");
                        }
                        else
                        {
                            Console.WriteLine($"\"-h\". {msg[i]} ({paramdeta[i]})");
                        }
                        i++;
                    }
                }
                else if (nas == true)
                {
                    int mas = (Math.Abs(int.Parse(args0[0]) + 1));
                    string[] naso = { "produto", "total", "resto", "quociente", "", "resultado", "raiz", "resultado", "área do círculo", "área do triangulo / losango", "área do retangulo", "área do trapezio", "fatorial", "imc" };
                    string[] type = { "O", "O", "O", "O", "", "O", "A", "O", "A", "A", "A", "A", "A", "O", "O" };
                    Console.WriteLine($"{type[mas]} {naso[mas]} é {R[0]} ");
                }
                else
                {
                    throw new ArgumentException("Ocorreu um erro");
                }
            }
            else
            {
                throw new ArgumentException("CalculadoraC#: \"Cadê os argumentos?\"");
            };
        }
        
    }
}