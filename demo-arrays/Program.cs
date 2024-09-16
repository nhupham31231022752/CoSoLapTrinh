
using ConsoleApp1;
using System.Collections;
using System.Data;

namespace Sample
{
    class Program
    {
        #region Input
        /// <summary>
        /// Ham nay nhap du lieu cho mang tu dong
        /// </summary>
        /// <param name="a">mang can nhap</param>
        static void InputRandomData(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(100);
            }
        }

        /// <summary>
        /// Nhap mang tu nguoi dunng
        /// </summary>
        /// <param name="a">mang can nhap</param>
        static void InputDataFromUser(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Please enter a number:");

                bool res = int.TryParse(Console.ReadLine(), out a[i]);
                if (!res)
                {
                    Console.WriteLine("Incorect number. Enter again");
                    i--;
                }
            }
        }
        /// <summary>
        /// In mang ra man hinh
        /// </summary>
        /// <param name="a">mang can in</param>
        static void PrintArray(int[] a)
        {
            foreach (int i in a)
                Console.Write($"{i} ");
            Console.WriteLine("\n");
        }
        #endregion

        #region search

        /// <summary>
        /// TIm phan tu seachItem trong mang a
        /// </summary>
        /// <param name="a">mang chua phan tu</param>
        /// <param name="searchItem">phan tu can tim</param>
        /// <returns>chi so của phan tu tim neu tim thay; -1 neu khong tim thay</returns>
        static int LinearSearch(int[] a, int searchItem)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == searchItem)
                    return i;
            }
            return -1;
        }

        //-------------------------------------------------
        //???? DIY: search all position in which an value appears
        //-------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        #endregion

        #region Sort
        static void BubleSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                for (int j = i; j < a.Length; j++)
                    if (a[i] < a[j])
                    {
                        int tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
        }
        #endregion

        #region exercises
        /// <summary>
        /// Calculate average
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static double CalculateAverageValue(int[] a)
        {
            double sum = 0d;
            foreach (int v in a)
            {
                sum += v;
            }
            return sum / a.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool CheckExist(int[] a, int value)
        {
            foreach (int val in a)
                if (val == value)
                    return true;
            return false;
        }

        static void PrintMaxMinElement(int[] a)
        {
            int max = a[0], min = a[0];
            foreach (int val in a)
            {
                if (min > val) min = val;
                if (max < val) max = val;
            }
            Console.WriteLine($"min = {min}");
            Console.WriteLine($"max = {max}");
        }

        /// <summary>
        /// to remove a specific element from an array.
        /// </summary>
        /// <param name="a">mang</param>
        /// <param name="ele">phan tu can xoa</param>
        static bool RemoveElement(int[] a, int ele)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ele)
                {
                    for (int j = i; j < a.Length - 1; j++)
                    {
                        a[j] = a[j + 1];
                    }
                    return true;// loai bo phan tu dau tien tim thay
                }
            }
            return false;//khong co phan tu can xoa
        }

        /// <summary>
        /// vi du: hom nay toi di hoc bu mon C#
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        static bool CheckWordExistInSentence(string sentence, string word)
        {
            char[] s = sentence.ToCharArray();
            char[] w = word.ToCharArray();
            //bai toan chuyen ve dang: kiem tra mot mang co trong 1 mang hay khong
            //DIY
            //????
            return false;
        }


        #endregion

        public static void Mainx()
        {
            //Random rnd = new Random();
            //int[] a = new int[5];//khai bao + khoi tao đoi tuong
            //InputRandomData(a);
            //PrintArray(a);

            /*
            //search linear
            Console.Write("\nEnter search value"); 
            int value=int.Parse(Console.ReadLine());//chu y
            int pos = LinearSearch(a, value);
            if (pos < 0)
                Console.WriteLine("khong tim thay");
            else
                Console.WriteLine($"tim thay tai vi tri {pos}");
            

            //sear binary - ****** mang phai duoc sap xep truoc do
            int[] b = { 1, 3, 6, 8, 11, 16, 30, 37, 80 };
            int res = BinarySearchIterative(b, 11);
            if (res < 0)
                Console.WriteLine("khong tim thay");
            else
                Console.WriteLine($"tim thay tai vi tri {res}");
            */

            //BubleSort(a);
            //PrintArray(a);

            //Array.Sort(a);
            //PrintArray(a);

            //double avg = CalculateAverageValue(b);
            //Console.WriteLine($"Average of a is {avg}");
            //int k = 6;
            //bool exist = CheckExist(b, k);
            //string r = exist ? "co" : "khong co";
            //Console.WriteLine($"Phan tu {k} {r} trong mang") ;

            //PrintMaxMinElement(a);

            int[] b = { 3, 5, 6, 4, 7 };
            bool r2 = RemoveElement(b, 16);
            //bo phan tu cuooi
            if (r2)
                Array.Resize(ref b, b.Length - 1);
            PrintArray(b);
        }
    }
}