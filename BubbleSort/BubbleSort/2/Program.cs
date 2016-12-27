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
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] inputnum = input.Split(' ');
			int[] arry = new int[inputnum.Length];
			for (int i = 0; i < inputnum.Length; i++)
			{
				arry[i] = int.Parse(inputnum[i]);
			}

			Sort.BubbleSort(arry);
			for (int i = 0; i < arry.Length; i++)
			{
				Console.Write("{0} ",arry[i]);
			}
			Console.Read();
		}
	}

	/// <summary>
	/// 冒泡排序算法函数
	/// </summary>
	/// 
	static class Sort
	{
		public static void BubbleSort(this int[] arry)
		{
			for (int i = 0; i < arry.Length; i++)
				for (int j = 0; j < arry.Length - 1 - i; j++)
				{
					if (arry[j] > arry[j + 1])
					{
						int temp = arry[j + 1];
						arry[j + 1] = arry[j];
						arry[j] = temp;
					}
				}
		}
	}
}
