//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class ADA_FIN_Q2
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int input = reader.NextInt();

//            long num1 = 0;
//            long num2 = 0;
//            long result = 0;
//            for (int i = 0; i < input; i++)
//            {
//                long number = reader.NextInt();
//                result += number;
//                long max = Math.Max(num1 + number, num2);
//                num1 = num2;
//                num2= max;
//            }
//            result += num2;

//            Console.WriteLine(result);
//        }
//    }


//    class Reader
//    {
//        private int index = 0;
//        private string[] tokens;
//        public string next()
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
//            return int.Parse(next());
//        }
//        public long NextLong()
//        {
//            return long.Parse(next());
//        }
//        public double NextDouble()
//        {
//            return double.Parse(next());
//        }
//    }

//}
