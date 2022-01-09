//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EISTORE
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int noOfType = reader.nextInt();
//            int money = reader.nextInt();

//            int[] findMin = new int[money + 1];
//            Array.Fill(findMin, int.MaxValue-1);
//            findMin[0] = 0;

//            for (int i = 0; i < noOfType; i++)
//            {
//                int type = reader.nextInt();
//                for(int j = type; j < money + 1; j++)
//                {
//                    findMin[j] = Math.Min(findMin[j], findMin[j-type]+1);
//                }
//            }

//            Console.WriteLine(findMin[money]);
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

//        public int nextInt()
//        {
//            return int.Parse(next());
//        }
//        public long nextLong()
//        {
//            return long.Parse(next());
//        }
//        public double nextDouble()
//        {
//            return double.Parse(next());
//        }
//    }
//}
