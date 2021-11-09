//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIUQBHV
//    {
//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();
//        static char[] passToChar;
//        static void Main(string[] args)
//        {
//            string password = reader.Next();
//            passToChar = password.ToCharArray();
//            Dictionary<char, int> dict = new Dictionary<char, int>();           
//            int permutaion = 1;
//            int div = 1;
//            for(int i = 2; i<= password.Length; i++)
//            {
//                permutaion *= i;
//            }           
            
//            for (int i = 0; i < password.Length; i++)
//            {
//                if (!dict.ContainsKey(passToChar[i]))
//                {
//                    dict.Add(passToChar[i], 1);
//                }
//                else
//                {
//                    dict[passToChar[i]] += 1;
//                }
//            }
//            foreach(int key in dict.Values)
//            {
//                if (key > 1)
//                {
//                    for (int i = 2; i <= key; i++)
//                    {
//                        div *= i;
//                    }
//                }
//            }
//            Array.Sort(passToChar);
//            permutaion = permutaion / div;
//            result.Append(permutaion).Append("\n");
//            result.Append(passToChar).Append("\n");
//            for (int i = 0;i< permutaion-1; i++)
//            {
//                nextPermutation(passToChar);
//                result.Append(passToChar).Append("\n");
//            }
//            Console.WriteLine(result);
//        }

//        static void nextPermutation(char[] chars)
//        {
            
//            int mark = -1;
//            for (int i = chars.Length - 1; i > 0; i--)
//            {
//                if (chars[i] > chars[i - 1])
//                {
//                    mark = i - 1;
//                    break;
//                }
//            }

//            if (mark == -1)
//            {
//                reverse(chars, 0, chars.Length - 1);
//                return;
//            }

//            int idx = chars.Length - 1;
//            for (int i = chars.Length - 1; i >= mark + 1; i--)
//            {
//                if (chars[i] > chars[mark])
//                {
//                    idx = i;
//                    break;
//                }
//            }

//            swap(chars, mark, idx);

//            reverse(chars, mark + 1, chars.Length - 1);
//        }

//        static void swap(char[] chars, int i, int j)
//        {
//            char t = chars[i];
//            chars[i] = chars[j];
//            chars[j] = t;
//        }

//        static void reverse(char[] chars, int i, int j)
//        {
//            while (i < j)
//            {
//                swap(chars, i, j);
//                i++;
//                j--;
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
