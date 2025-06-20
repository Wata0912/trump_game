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

            //ペアの数
            int count = 0;
            //比較元の設定
            for (int j = 0; j < 4; j++)
            {
                //比較先の設定、残り枚数分繰り返す
                for (int i = j + 1; i < 4; i++)
                {
                    //比較元と比較先の値が等しいときCountを+する
                    if ((cards[i] & 0xf) == (cards[j] & 0xf))
                    {
                        //ペアの数をカウントする
                        count++;
                    }

                }
            }

            //役の判定と出力
            switch (count)
            {
                case 0:
                    Console.WriteLine("ハイカード");
                    break;
                case 1:
                    Console.WriteLine("ワンペア!");
                    break;
                case 2:
                    Console.WriteLine("ツーペア!!");
                    break;
                case 3:
                    Console.WriteLine("スリーカード!!!");
                    break;
                case 6:
                    Console.WriteLine("フォーカード!!!!");
                    break;
            }

            Console.WriteLine("Enterを押してください");
            Console.ReadLine();
            
        }
    }
}
