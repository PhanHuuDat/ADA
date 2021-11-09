//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIALPHABET
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int noOfCases = reader.NextInt();
//            Boolean[] charList = new bool[26];

//            for (int i = 0; i < noOfCases; i++)
//            {
//                string text = Console.ReadLine();
//                isPangram(charList, text.ToLower());
//            }

//        }


//        static void isPangram(Boolean[] charList, string lowText)
//        {
//            charList = new bool[26];
//            int index = 0;
//            string result= "missing ";
//            for (int i = 0; i < lowText.Length; i++)
//            {
//                if ('a' <= lowText[i] && lowText[i] <= 'z')
//                {
//                    index = lowText[i] - 'a';
//                    charList[index] = true;
//                }
//            }
//            for (int i = 0; i < charList.Length; i++)
//            {
//                if (!charList[i])
//                {
//                    char c = (char)(97 + i);
//                    result += c;
//                }
//            }
//            if(result.Equals("missing "))
//            {
//                result = "pangram";
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
