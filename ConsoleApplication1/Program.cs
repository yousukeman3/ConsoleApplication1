using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s; Nijikannsuu n; int eroor = 0; for (;;)
            {
                try
                {
                    s = Console.ReadLine();
                    if (s == "exit") break;
                    n = new Nijikannsuu(s.Split(' '));
                    Console.WriteLine(n.solvePs() + "," + n.solveNs());
                }
                catch (Exception)
                {
                    Console.WriteLine("eroor");
                    eroor++; if (eroor >= 10) Console.WriteLine("頭冷やせ");
                    if (eroor == 20) Console.WriteLine("あと十回eroorで強制終了");
                    if (eroor >= 30) break;
                }
            }
        }
    }
    class Nijikannsuu
    {
        double a_, b_, c_;
        public Nijikannsuu(string[] a)
        {
            int x = 0;
            double[] b = new double[3];
            foreach (string s in a)
            {
                b[x] = Convert.ToDouble(s);
                x++;
            }
            this.a = b[0];
            this.b = b[1];
            this.c = b[2];
        }
        public double juge
        {
            get
            {
                return b * b - 4 * a * c;
            }
        }
        public bool jugeB
        {
            get
            {
                return juge >= 0;
            }
}
public double a
        {
            get
            {
                return a_;
            }
            set
            {
                a_ = value;
            }
        }
public double b
        {
            get
            {
                return b_;
            }
            set
            {
                b_ = value;
            }
        }
public double c
        {
            get
            {
                return c_;
            }
            set
            {
                c_ = value;
            }
        }
public string solvePs()
        {
            if (a == 0 && b != 0)
            {
                return Convert.ToString(-c / b);
            }
            else if (a == 0 && b == 0)
            {
                return Convert.ToString(c);
            }
            else if (jugeB)
            {
                return Convert.ToString((-b + Math.Sqrt(juge)) / (2 * a));
            }
            else
            {
                return Convert.ToString(-b / (2 * a)) + "+" + Convert.ToString(Math.Sqrt(-juge) / 2 * a) + "i";
            }
        }
public string solveNs()
        {
            if (a == 0 && b != 0)
            {
                return Convert.ToString(-c / b);
            }
            else if (a == 0 && b == 0)
            {
                return Convert.ToString(c);
            }
            else if (jugeB)
            {
                return Convert.ToString((-b - Math.Sqrt(juge)) / (2 * a));
            }
            else
            {
            return Convert.ToString(-b / (2 * a)) + "-" + Convert.ToString(Math.Sqrt(-juge) / 2 * a) + "i";
            }
        }
    }
}