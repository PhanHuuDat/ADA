//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIULOGGING3
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int input = reader.NextInt();
//            int mod = 1000000007;

//            long num1 = 0;
//            long num2 = 0;
//            long c1 = 1;
//            long c2 = 1;
//            long result = 0;
//            long totalWays = 0;

//            for (int i = 0; i < input; i++)
//            {
//                int number = reader.NextInt();

//                if (num1 + number == num2)
//                {
//                    totalWays = (c1 + c2) % mod;
//                }
//                else if (num1 + number > num2)
//                {
//                    totalWays = c1 ;
//                }
//                else
//                {
//                    totalWays = c2 ;
//                }
//                c1 = c2;
//                c2 = totalWays;
//                result = Math.Max((num1 + number), num2);
//                num1 = num2;
//                num2 = result;

//            }
//            Console.WriteLine(result+" "+totalWays);
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
