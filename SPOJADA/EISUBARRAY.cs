//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EISUBARRAY
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int arrayLength = reader.NextInt();

//            List<long> orginalList = new List<long>();
//            long minSubArray;
//            long maxSubArray;
//            long minTemp;
//            long maxTemp;

//            orginalList.Add(reader.NextInt());
//            for (int i = 0; i < arrayLength - 1; i++)
//            {
//                orginalList.Add(reader.NextInt());
//            }

//            minSubArray = orginalList[0];
//            maxSubArray = orginalList[0];
//            minTemp = maxTemp = orginalList[0];

//            for (int i = 1; i < arrayLength; i++)
//            {

//                minTemp = Math.Min(minTemp + orginalList[i], orginalList[i]);
//                maxTemp = Math.Max(maxTemp + orginalList[i], orginalList[i]);

//                maxSubArray = Math.Max(maxTemp, maxSubArray);
//                minSubArray = Math.Min(minTemp, minSubArray);

//            }

//            long result = Math.Max(Math.Abs(minSubArray), Math.Abs(maxSubArray));
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
