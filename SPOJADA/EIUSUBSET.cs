//using System;
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
//            List<int> binaryList = new List<int>();
//            for (int i = 0; i < arrayLength; i++)
//            {
//                list[i] = reader.NextInt();
//            }
//            result.Append(loop - 1).Append("\n");
//            for (int i = 1; i < loop; i++)
//            {
//                binaryList = convertBinary(i);
//                int trueLocate = list.Length - binaryList.Count;
//                for (int j = 0; j < binaryList.Count; j++)
//                {
//                    if (binaryList[j] == 1)
//                    {
//                        result.Append(list[trueLocate + j]).Append(" ");
//                    }
//                }
//                result.Append("\n");
//            }
//            Console.WriteLine(result);
//        }

//        static List<int> convertBinary(int number)
//        {
//            List<int> binaryList = new List<int>();

//            int multiple = 0;
//            int i = -1;

//            while (multiple < number)
//            {
//                i++;
//                multiple = 1 << i;              
//            }
            
//            while (i >= 0)
//            {
//                if (number - multiple >= 0)
//                {
//                    number -= multiple;
//                    multiple = multiple >> 1;
//                    binaryList.Add(1);                  
//                }
//                else
//                {
//                    binaryList.Add(0);
//                    multiple = multiple >> 1;
//                }
//                i--;
//            }

//            return binaryList;
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
