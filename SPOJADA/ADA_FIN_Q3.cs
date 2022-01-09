//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class ADA_FIN_Q3
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int input = reader.NextInt();
//            int count = 0;

//            while (input > 0)
//            {
//                int temp = input;
//                int max = 0;

//                while (temp != 0 && max != 9)
//                {
//                    max = Math.Max(max, temp % 10);
//                    temp = temp / 10;
//                }
//                input -= max;
//                count++;
//            }
//            Console.WriteLine(count);
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
