using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //カード枚数の配列を作成
            int[] cards = new int[4];
            //入力された数字
            string num;
            //文字列から数字への変換判定
            bool result;

                //カード入力処理
                for (int i = 0; i < cards.Length; i++)
                {
                    while (true)
                    {
                        //値が範囲外なら繰り返す
                        Console.Write($"{i + 1}番目のカードの数字(1～13)を入力してください＞");
                        num = Console.ReadLine();
                        result = int.TryParse(num, out cards[i]);
                        if (result == true && cards[i] > 0 && cards[i] < 14)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("再入力してください");
                        }
                    }

                }

            Console.WriteLine("Enterを押してください");
            Console.ReadLine();
            
        }
    }
}
