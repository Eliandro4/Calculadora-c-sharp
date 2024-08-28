using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Conva;

namespace Vero
{
    public class Very
    {
        public void exec(string vero, string[] args0, BigInteger[] armos, float[] args, int[] amios, out BigInteger[] bigsai, out float[] floatsai, out int[] intsai)
            {
            Conv conv = new Conv();
            int.TryParse(vero, out int vera);
            int am = veri(vera);
            if (am == 1)
            {
                args = conv.froto(args0);
            }
            if (am == 2)
            {
                amios = conv.into(args0);
            }
            if (am == 3)
            {
                armos = conv.bigo(args0);
            }
            bigsai = armos;
            intsai = amios;
            floatsai = args;
            conv = null!;
        }
        public int veri(int vamo)
        {
            int res = 0;
            int[] floar = { -2, -3, -4, -8, -9, -10, -11, -12, -14};
            int[] intar = { -5, -6, -7};
            int[] bigin = { -1, -13};
            for (int i = 0; i<9; i++)
            {
                if (vamo == floar[i])
                {
                    res = 1;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (vamo == intar[i])
                {
                    res = 2;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (vamo == bigin[i])
                {
                    res = 3;
                }
            }
            return res;
        }
    }
}