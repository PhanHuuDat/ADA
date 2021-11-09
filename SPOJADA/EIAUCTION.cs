//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIAUCTION
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int noOfCustomer = reader.NextInt();
//            List<int> listNum = new List<int>();
//            Dictionary<int, int> dict = new Dictionary<int, int>();
//            int largestNum = 0;
//            for (int i = 0; i < noOfCustomer; i++)
//            {
//                int temp = reader.NextInt();
//                listNum.Add(temp);
//                if (!dict.ContainsKey(temp))
//                {
//                    dict.Add(temp, 1);
//                }
//                else
//                {
//                    dict[temp] += 1;
//                }
//            }

//            foreach (int key in dict.Keys)
//            {
//                if (key > largestNum && dict[key] < 2)
//                {
//                    largestNum = key;
//                }
//            }
//            if (largestNum == 0)
//            {
//                Console.WriteLine("none");
//            }
//            else
//            {
//                int location = listNum.IndexOf(largestNum);
//                Console.WriteLine(location + 1);
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
