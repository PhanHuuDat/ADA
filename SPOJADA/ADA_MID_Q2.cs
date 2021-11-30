//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class ADA_MID_Q2
//    {
//        static Reader reader = new Reader();

//        static List<int> males = new List<int>();
//        static List<int> females = new List<int>();

//        static int res = int.MaxValue;
//        static int temp = 0;
//        static void Main(string[] args)
//        {
//            int male = reader.NextInt();
//            int female = reader.NextInt();
//            int X = reader.NextInt();

//            for (int ind = 0; ind < male; ind++)
//            {
//                males.Add(reader.NextInt());
//            }

//            for (int ind = 0; ind < female; ind++)
//            {
//                females.Add(reader.NextInt());
//            }
//            males.Sort();
//            females.Sort();
//            binarySearch(X);
//            Console.WriteLine(res);
//        }

//        static void binarySearch(int X)
//        {
//            double left = 0;
//            double right = 10000000;

//            while (left <= right)
//            {
//                int mid = (int) ((left + right) / 2);
//                int result = GetSet(mid);

//                if (result >= X)
//                {
//                    right = mid;
//                    res = res < temp ? res : temp;
                    
//                }
//                else
//                {
//                    left = mid +1;
//                }
//                if (right == left)
//                {
//                    break;
//                }
//            }

//        }

//        static int GetSet(int H)
//        {
//            int i = 0;
//            int j = 0;
//            int result = 0;
//            temp = 0;
//            while (i < males.Count && j < females.Count)
//            {
//                int flag = Math.Abs(males[i] - females[j]);
//                if (flag <= H)
//                {
//                    result++;
//                    i++;
//                    j++;
//                    temp = temp > flag ? temp : flag;

//                }
//                else
//                {
//                    if (males[i] > females[j])
//                    {
//                        j++;
//                    }
//                    else
//                    {
//                        i++;
//                    }
//                }
//            }
//            return result;
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
