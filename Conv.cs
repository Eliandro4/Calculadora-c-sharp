using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Conva
{
    public class Conv
    {
        public BigInteger[] bigo(string[] args0)
        {
            BigInteger[] armos = new BigInteger[(args0.Length - 1)];
            for (int i = 1; i < args0.Length; i++)
            {
                BigInteger.TryParse(args0[i], out armos[i - 1]);
                //Console.WriteLine(armos[(i - 1)]);
            }
            return armos;
        }
        public int[] into(string[] args0)
        {
            int[] argos = new int[(args0.Length - 1)];
            for (int i = 1; i < args0.Length; i++)
            {
                int.TryParse(args0[i], out argos[i - 1]);
                //Console.WriteLine(argos[(i - 1)]);
            }
            return argos;
        }
        public float[] froto(string[] args0)
        {
            float[] argos = new float[(args0.Length - 1)];
            for (int i = 1; i < args0.Length; i++)
            {
                float.TryParse(args0[i], out argos[i - 1]);
                //Console.WriteLine(argos[(i - 1)]);
            }
            return argos;
        }
    }
}
