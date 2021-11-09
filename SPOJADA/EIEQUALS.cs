//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIEQUALS
//    {
//        static Reader reader = new Reader();
//        static void Main(String[] args)
//        {
//            int n = reader.NextInt();
//            int k = reader.NextInt();
//            Boolean flag = true;

//            Dictionary<int, int> listA = new Dictionary<int, int>();
//            List<int> isPerm = new List<int>();

//            for (int i = 0; i < n; i++)
//            {
//                int temp = reader.NextInt();
//                if (!listA.ContainsKey(temp))
//                {
//                    listA.Add(temp, 1);
//                }
//                else
//                {
//                    listA[temp] += 1;
//                }
//            }
//            for (int i = 0; i < n; i++)
//            {
//                int temp = reader.NextInt();
//                if (!listA.ContainsKey(temp))
//                {
//                    listA.Add(temp, -1);
//                }
//                else
//                {
//                    listA[temp] -= 1;
//                }
//            }
//            foreach (int key in listA.Keys)
//            {
//                if (listA[key] == 1 || listA[key] == -1)
//                {
//                    isPerm.Add(key);
//                }
//                else if (listA[key] != 0)
//                {
//                    flag = false;
//                    break;
//                }
//            }

//            if (isPerm.Count==2)
//            {
//                flag = k >= Math.Abs(isPerm[0] - isPerm[1]) ? true : false;
//            }
//            else
//            {
//                if (isPerm.Count > 2)
//                {
//                    flag = false;
//                }
//            }
          
//            if (flag)
//            {
//                Console.WriteLine("YES");
//            }
//            else
//            {
//                Console.WriteLine("NO");
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
