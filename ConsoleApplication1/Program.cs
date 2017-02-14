using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    static class benriTools
    {
        public static T[] add_length<T>(this T[] length, int add)
        {
            T[] temp = new T[length.Length];
            length.CopyTo(temp, 0);
            length = new T[length.Length + add];
            temp.CopyTo(length, 0);
            return length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            string s; Nijikannsuu n; int eroor = 0; string chara;int i;
        c:
            chara = Console.ReadLine();
            if(chara == "a")
            {
                goto a;
            }
            else if(chara == "b")
            {
                goto b;
            }
            else
            {
                goto c;
            }
            a:
            for (;;)
            {
                try
                {
                    s = Console.ReadLine();
                    if (s == "exit") break;
                    n = new Nijikannsuu(s.Split(' '));
                    if (n.solveNs() == n.solvePs())
                    {
                        Console.WriteLine(n.solveNs());
                    }
                    else
                    { 
                        Console.WriteLine(n.solvePs() + "," + n.solveNs());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("eroor");
                    eroor++; if (eroor >= 10) Console.WriteLine("頭冷やせ");
                    if (eroor == 20) Console.WriteLine("あと十回eroorで強制終了");
                    if (eroor >= 30) break;
                }
            }
            b:
            for ( ;  ; )
            {
                try
                {
                    s = Console.ReadLine();
                    i = 0;
                    foreach (int sosuu_ in sosuu.soinsuubunnkai(Convert.ToInt32(s),false))
                    {
                        if (sosuu_ != 0)
                        {
                            Console.WriteLine(sosuu.soinsuubunnkai(Convert.ToInt32(s), true)[i]+":"+sosuu_.ToString()+"個");
                        }
                        i++;
                    }
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
                b[x++] = Convert.ToDouble(s);
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
                return "一次方程式です。"+Convert.ToString(-c / b);
            }
            else if (a == 0 && b == 0)
            {
                return "二次方程式ではありません。　";
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
                return "一次方程式です。" + Convert.ToString(-c / b);
            }
            else if(a == 0&&b==0)
            {
                return "二次方程式ではありません。　";
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
    static class sosuu
    {
        public static int[] soinsuubunnkai(int target,bool sosuuretu)
        {
            int target_ = target;
            int[] sosuu_length = {2};
            int[] sosuu_used = new int[1];
            int sosuu = 3;
            int counter = 1;
            while (target_%sosuu_length[0]==0)
            {
                target_ = target_ / sosuu_length[0];
                sosuu_used[0] = sosuu_used[0] + 1;
            }
            sosuu = 3;
            for (int sosuu_index = 0 ; target_ != 1 ; sosuu_index = 0 )
            {
                while (sosuu_index + 1 <= sosuu_length.Length)
                {
                    if (sosuu % sosuu_length[sosuu_index] != 0)
                    {
                        sosuu_index++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sosuu_index == sosuu_length.Length)
                {
                    sosuu_used = sosuu_used.add_length(1);
                    sosuu_length = sosuu_length.add_length(1);
                    sosuu_length[counter] = sosuu;
                }
                sosuu++;
                if (sosuu_length.Length>=counter+1)
                while (target_ % sosuu_length[counter] == 0)
                {
                    target_ = target_ / sosuu_length[counter];
                    sosuu_used[counter]++;
                }
                if (sosuu_index+1==sosuu_length.Length)
                {
                    counter++;
                }
            }
            if (sosuuretu)
            {
                return sosuu_length;
            }
            return sosuu_used;
        }
    }
}
