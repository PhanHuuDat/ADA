//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIUSUBSET2
//    {
//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();

//        static void Main(string[] args)
//        {
//            int arrayLength = reader.NextInt();
//            int givenInt = reader.NextInt();
//            int total = 0;
//            int equalInt = 0;
//            int[] list = new int[arrayLength];
//            int loop = 1 << arrayLength;

//            for (int i = 0; i < arrayLength; i++)
//            {
//                list[i] = reader.NextInt();
//            }

//            for (int i = 1; i < loop; i++)
//            {
//                string binary = Convert.ToString(i, 2);
                
//                total = 0;
//                int trueLocate = list.Length - binary.Length;
//                for (int j = 0; j < binary.Length; j++)
//                {
//                    if (binary[j] == '1')
//                    {
//                        total += list[trueLocate+j];                       
//                    }
//                }
//                if(total == givenInt)
//                {
//                    equalInt++;
//                }
//            }
//            Console.WriteLine(equalInt);
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
