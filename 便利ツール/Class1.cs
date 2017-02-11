using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yousukeman3
{
    /// <summary>
    /// を表すクラス・コントロール
    /// </summary>
    public static class benriTools
    {
        /// <summary>
        /// 配列の要素を追加するメソッドです。
        /// </summary>
        /// <remarks>特になし。</remarks>
        /// <typeparam name="T">配列の型を入れてください。</typeparam>
        /// <param name="length">要素を増やしたい配列です。</param>
        /// <param name="add">増やしたい要素の数です。</param>
        /// <returns>増やした配列を返します。</returns>
        /// <threadsafety static="true" instance="false"/>
        public static T[] add_length<T>(this T[] length, int add)
        {
            T[] temp = new T[length.Length];
            length.CopyTo(temp, 0);
            length = new T[length.Length + add];
            temp.CopyTo(length, 0);
            return length;
        }
    }
}
