﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIUSUBSET
//    {
//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();

//        static void Main(string[] args)
//        {
//            int arrayLength = reader.NextInt();
//            int[] list = new int[arrayLength];
//            int loop = 1 << arrayLength;
//            int compareValue = 1 << (arrayLength - 1);

//            for (int i = 0; i < arrayLength; i++)
//            {
//                list[i] = reader.NextInt();
//            }
//            result.Append(loop - 1).Append("\n");
//            for (int i = 1; i < loop; i++)
//            {
//                for (int j = 0, value = i; j < arrayLength; j++, value <<= 1)
//                {
//                    if ((value & compareValue) == compareValue)
//                    {
//                        result.Append(list[j]).Append(" ");
//                    }
//                }
//                result.Append("\n");
//            }
//            Console.WriteLine(result);
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
