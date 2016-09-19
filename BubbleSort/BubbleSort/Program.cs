using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 2016/9/19
/// </summary>
/// 
namespace BubbleSort
{

    /// <summary>
    /// 主程序
    /// </summary>
    /// 
    class Program
    {
        static void Main ( string [ ] args )
        {
            int [ ] arry = new int [ ] { 5 , 3 , 8 , 10 , 4 , 20 , 50 , 2 , 1 };
            Sort.BubbleSort ( arry );
            for (int i = 0 ; i < arry.Length ; i++)
            {
                Console.Write ( "\t" + arry [ i ] );
            }
            Console.Read ( );
        }
    }

    /// <summary>
    /// 冒泡排序算法函数
    /// </summary>
    /// 
    static class Sort
    {
        public static void BubbleSort ( this int [ ] arry )
        {
            for (int i = 0 ; i < arry.Length ; i++)
                for (int j = 0 ; j < arry.Length - 1 - i ; j++)
                {
                    if (arry [ j ] > arry [ j + 1 ])
                    {
                        int temp = arry [ j + 1 ];
                        arry [ j + 1 ] = arry [ j ];
                        arry [ j ] = temp;
                    }
                }
        }
    }
}
