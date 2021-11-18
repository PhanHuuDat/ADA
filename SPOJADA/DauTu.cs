//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{

//    class DauTu
//    {

//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();
//        static List<double> moneyPerMonth = new List<double>();

//        static void Main(string[] args)
//        {
//            double money = reader.NextDouble();
//            double totalMoney;
//            double left = 0;
//            double right = 10;

//            double absoluteNum = money;

//            for (int i = 0; i < 12; i++)
//            {
//                moneyPerMonth.Add(reader.NextDouble());
//            }

//            while (left + 0.0000000001 < right)
//            {              
//                double mid = (left + right) / 2;
//                totalMoney = getMoney(mid);
                
//                if (totalMoney > money)
//                {
//                    right = mid;
//                }
//                else
//                {
//                    left = mid;
//                }
//            }

//            Console.WriteLine(Math.Round(left, 9));
//        }
//        static double getMoney(double rate)
//        {
//            double totalMoney = moneyPerMonth[0];
//            for (int i = 1; i < 12; i++)
//            {
//                totalMoney = totalMoney * (1 + rate) + moneyPerMonth[i];
//            }
//            return totalMoney;
//        }

//        static void binarySearch(List<int> arr, int first, int last, int key)
//        {
//            int mid = (first + last) / 2;
//            while (first <= last)
//            {
//                if (arr[mid] < key)
//                {
//                    first = mid + 1;
//                }
//                else if (arr[mid] == key)
//                {
//                    break;
//                }
//                else
//                {
//                    last = mid - 1;
//                }
//                mid = (first + last) / 2;
//            }
//            if (first > last)
//            {

//            }
//        }

//    }



//    class Reader
//    {
//        private int index = 0;
//        private string[] tokens;
//        public string Next()
//        {
//            while (tokens == null || tokens.Length <= index)
//            {
//                tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//                index = 0;
//            }
//            return tokens[index++];
//        }

//        public int NextInt()
//        {
//            return int.Parse(Next());
//        }
//        public long NextLong()
//        {
//            return long.Parse(Next());
//        }
//        public double NextDouble()
//        {
//            return double.Parse(Next());
//        }
//    }
//}
