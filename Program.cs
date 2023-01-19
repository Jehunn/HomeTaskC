using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace HomeTasks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1: Verilmiş ədələr siyahısındakı ədələrdən ən kiçiyini tapan metod
            int[] array = { 321, 123, 145, 57, 2, 4, 17 };
            int result = minNum(array);
            Console.WriteLine(result);
            #endregion


            #region Task 2: Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod
            //Console.WriteLine("Sozu daxil edin");
            //string word = Console.ReadLine();
            //Console.WriteLine("Axtardiginiz ededi daxil edin");
            //char wantedChar = Convert.ToChar(Console.ReadLine());
            //var result1 = CharStr(word, wantedChar);
            //Console.WriteLine(result1);
            #endregion


            #region Task 3: Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod,əgər həmin ədəd siyahıda yoxdursa -1 qaytarsın, varsa ilk yerləşdiyi indexi
            int[] arr = { 15, 30, 21, 50, 210, 8 };
            var result1 = IndexOfNumber(arr, 50);
            Console.WriteLine(result1);
            #endregion


            #region Task 4: Verilmiş yazını əksinə çevirən metod
            Console.WriteLine("Yazini daxil edin");
            string word2=Console.ReadLine();
            var result2 = OppositeW(word2);
            Console.WriteLine(result2);
            #endregion


            #region Task 5: Verilmiş yazıda rəqəm olub olmadığını tapan metod
            Console.WriteLine("Yazini daxil edin");
            string word3=Console.ReadLine();
            var result3=HasDigit(word3);
            Console.WriteLine(result3);
            #endregion





        }



    }


    #region Task1
    //static int minNum(int[] array)
    //{
    //    //int min = array[0];
    //    //for (int i = 0; i < array.Length; i++)
    //    //{
    //    //    if (array[i] < min)
    //    //    {
    //    //        array[i] = min;
    //    //    }
    //    //}
    //    //return min;
    //}
    #endregion


    #region Task2
    //    static int CharStr(string word, char cr)
    //    {
    //    int count = 0;
    //    for (int i = 0; i < word.Length; i++)
    //    {
    //        if (word[i] == cr)
    //        {
    //            count++;
    //        }
    //    }
    //    return count;
    //}
    #endregion


    #region Task3
    //static internal IndexOfNumber(int[] arr, int dig)
    //{
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        if (arr[i] == dig)
    //        {
    //            return i;
    //        }
    //    }
    //    return -1;
    //}
    #endregion


    #region Task5
    static bool HasDigit(string word3)
    {
        char[] dig = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        for(int j = 0; j < word3.Length; j++)
        {
            for (int i = 0; i < dig.Length; i++)
            {
                if (word3[j] == dig[i])
                {
                    return true;
                }
            }
        }
        return false;    
            
    }
    #endregion









}