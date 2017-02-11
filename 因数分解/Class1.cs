using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yousukeman3;

namespace yousukeman3
{
    namespace mymath
    {
        /// <summary>
        /// 二次関数を扱うためのクラスです。ローマ字でごめんなさい。
        /// </summary>
        public class Nijikannsuu
        {
            /// <summary>
            /// 各項の係数を保持するフィールドですが<c>a</c>,<c>b</c>,<c>c</c>プロパティがあるので使用できないようにしています。
            /// 詳しい説明は<see cref="a" />,<see cref="b" />,<see cref="c" />をご覧ください。
            /// </summary>
            private double a_, b_, c_;
            /// <summary>
            ///   <see cref="Nijikannsuu" /> クラスのコンストラクタです。
            /// </summary>
            /// <param name="a">二次方程式の各項の係数を降べきの順に突っ込んでください。</param>
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
            /// <summary>
            ///  <see cref="Nijikannsuu"/> クラスのコンストラクタです。
            /// </summary>
            /// <param name="sdash">二次方程式の各項の係数を降べきの順に、<c>' '</c>で区切って突っ込んでください。</param>
            public Nijikannsuu(string sdash)
            {
                int x = 0;
                double[] b = new double[3];
                foreach (string s in sdash.Split(' '))
                {
                    b[x++] = Convert.ToDouble(s);
                }
                this.a = b[0];
                this.b = b[1];
                this.c = b[2];
            }
            /// <summary>
            /// <see cref="Nijikannsuu" /> のコンストラクタです。
            /// </summary>
            /// <param name="a">二次関数のx^2の項を表す数値</param>
            /// <param name="b">二次関数のxの項を表す数値</param>
            /// <param name="c">二次関数の整数項を表す数値</param>
            public Nijikannsuu(double a,double b,double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            /// <summary>
            /// 判別式の解を取得するためのプロパティです。
            /// </summary>
            public double juge
            {
                get
                {
                    return b * b - 4 * a * c;
                }
            }
            /// <summary>
            /// 判別式の正負を真偽値で取得するためのプロパティです。
            /// </summary>
            public bool jugeB
            {
                get
                {
                    return juge >= 0;
                }
            }
            /// <summary>
            /// 二次関数のx^2の項の値を保持するプロパティです。
            /// </summary>
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
            /// <summary>
            /// 二次関数のxの項を保持するプロパティです。
            /// </summary>
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
            /// <summary>
            /// 二次関数の整数項を保持するプロパティです。
            /// </summary>
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
            /// <summary>
            /// 二次方程式の大きい方の解を文字列で取得する。
            /// </summary>
            /// <returns>二次方程式の小さい方の解を文字列で返します。</returns>
            public string solvePs()
            {
                if (a == 0 && b != 0)
                {
                    return "一次方程式です。" + Convert.ToString(-c / b);
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
            /// <summary>
            /// 二次方程式の大きい方の解を文字列で取得する。
            /// </summary>
            /// <returns>二次方程式の大きい方の解を文字列で返します。</returns>
            public string solveNs()
            {
                if (a == 0 && b != 0)
                {
                    return "一次方程式です。" + Convert.ToString(-c / b);
                }
                else if (a == 0 && b == 0)
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
        /// <summary>
        /// を表すクラス・コントロール
        /// </summary>
        static class sosuu
        {
            /// <summary>
            /// を実行する・取得する
            /// </summary>
            /// <param name="target">を表す数値</param>
            /// <param name="sosuuretu">かどうかを表す値</param>
            /// <returns></returns>
            public static int[] soinsuubunnkai(int target, bool sosuuretu)
            {
                int target_ = target;
                int[] sosuu_length = { 2 };
                int[] sosuu_used = new int[1];
                int sosuu = 3;
                int counter = 1;
                while (target_ % sosuu_length[0] == 0)
                {
                    target_ = target_ / sosuu_length[0];
                    sosuu_used[0] = sosuu_used[0] + 1;
                }
                sosuu = 3;
                for (int sosuu_index = 0; target_ != 1; sosuu_index = 0)
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
                    if (sosuu_length.Length >= counter + 1)
                        while (target_ % sosuu_length[counter] == 0)
                        {
                            target_ = target_ / sosuu_length[counter];
                            sosuu_used[counter]++;
                        }
                    if (sosuu_index + 1 == sosuu_length.Length)
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
}