using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yousukeman3
{
    namespace 二次方程式
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
            /// <returns></returns>
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
    }
}