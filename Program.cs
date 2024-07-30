using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Tar;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Calculadora
{
    internal class Ito
    {
        public static string[] tipo = { "", ""};
        public static double x1;
        public static double x2;
        static void Main(string[] args)
        {
        double R = 0;
        string arg = args[0];
        switch(args[0])
        {
            case "-1":
                R = Calculagi.Calc.multiplicar(float.Parse(args[1]), float.Parse(args[2]));
                tipo[0] = "produto";
                tipo[1] = "O ";
            break;
            case "-2":
                R = Calculagi.Calc.adicionar(float.Parse(args[1]), float.Parse(args[2]));
                tipo[0] = "total";
                tipo[1] = "O ";
            break;
            case "-3":
                R = Calculagi.Calc.subtrair(float.Parse(args[1]), float.Parse(args[2]));
                tipo[0] = "resto";
                tipo[1] = "O ";
            break;
            case "-4":
                R = Calculagi.Calc.dividir(float.Parse(args[1]), float.Parse(args[2]));
                tipo[0] = "quociente";
                tipo[1] = "O ";
            break;
            case "-5":
                Calculagi.Calc.baskara(int.Parse(args[1]), int.Parse(args[2]), int.Parse(args[3]), out x1, out x2);
            break;
            case "-6":
                R = Calculagi.Calc.potencia(int.Parse(args[1]), int.Parse(args[2]));
                tipo[0] = "resultado";
                tipo[1] = "O ";
            break;
            case "-7":
                R = Calculagi.Calc.raiz(int.Parse(args[1]));
                tipo[0] = "resultado";
                tipo[1] = "O ";
            break;
            case "-8":
                R = Calculagi.Calc.porcentagem(float.Parse(args[1]), float.Parse(args[2]));
                tipo[0] = "resultado";
                tipo[1] = "O ";
            break;
            case "-9":
                R =Calculagi.Calc.aria_circulo(float.Parse(args[1]));
                tipo[0] = "aria do circulo";
                tipo[1] = "A ";
            break;
            case "-10":
                R = Calculagi.Calc.aria_triangulo(float.Parse(args[1]), float.Parse(args[2]));
                tipo[0] = "aria do triangulo";
                tipo[1] = "A ";
            break;
            case "-11":
                R = Calculagi.Calc.aria_retangulo(float.Parse(args[1]), float.Parse(args[2]));
                tipo[0] = "aria do retangulo";
                tipo[1] = "A ";
            break;
            case "-12":
                R = Calculagi.Calc.aria_trapezio(float.Parse(args[1]), int.Parse(args[2]), int.Parse(args[3]));
                tipo[0] = "aria do trapezio";
                tipo[1] = "A ";
            break;
            case "-13":
                R = Calculagi.Calc.aria_losango(float.Parse(args[1]), float.Parse(args[2]));
                tipo[0] = "aria do losango";
                tipo[1] = "A ";
            break;
            case "-14":
                R = Calculagi.Calc.fatorial(int.Parse(args[1]));
                tipo[0] = "fatorial";
                tipo[1] = "O ";
            break;
        };
        if (args[0] == "-5")
        {
            Console.WriteLine("X´ = " + x1);
            Console.WriteLine("X´´ = " + x2);
        }
        else
        {
            Console.WriteLine(tipo[1] + tipo[0] + " é " + R);
        }
        Console.ReadLine();
        }
    }
}