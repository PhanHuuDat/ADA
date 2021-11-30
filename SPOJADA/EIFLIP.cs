//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIFLIP
//    {
//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();
//        static void Main(string[] args)
//        {
//            int numOfTestcases = reader.NextInt();

//            for (int i = 0; i < numOfTestcases; i++)
//            {
//                Boolean[] lego = new Boolean[9];

//                int min = int.MaxValue;
//                char black = '*';
//                int maxAppear = 0;
//                int index = 0;
//                for (int j = 0; j < 3; j++)
//                {
//                    string status = reader.Next();
                    
//                    foreach (char c in status)
//                    {
//                        if (c.CompareTo(black) == 0)
//                        {
//                            lego[index] = true;
//                            maxAppear++; 
//                        }
//                        index++;
//                    }
//                }
//                if (maxAppear == 0)
//                {
//                    min = 0;
//                }
//                else
//                {
//                    int length = (1 << 9) - 1;

//                    for (int j = 1; j <= length; j++)
//                    {
//                        int temp = j;
//                        int taps = 0;
//                        Boolean[] checkLego = new Boolean[9];
//                        for (index = 0; index < 9; index++)
//                        {
//                            if ((temp & 1) == 1)
//                            {
//                                check(index, checkLego);
//                                taps++;
//                            }
//                            temp >>= 1;
//                        }
//                        if (taps < min)
//                        {
//                            Boolean checkStatus = true;
//                            for (int x = 0; x < 9; x++)
//                            {
//                                if (!checkLego[x] == lego[x])
//                                {
//                                    checkStatus = false;
//                                    break;
//                                }
//                            }
//                            if (checkStatus)
//                            {
//                                min = taps;
//                            }
//                        }
//                        if (min == 1)
//                        {
//                            break;
//                        }

//                    }
//                }
//                result.Append(min).Append("\n");
//            }
//            Console.WriteLine(result);
//        }

//        static Boolean[] check(int temp, Boolean[] a)
//        {
//            a[temp] = !a[temp];
//            int row = temp / 3;
//            if (temp + 1 < (row + 1) * 3)
//            {
//                a[temp + 1] = !a[temp + 1];
//            }
//            if (temp - 1 >= row * 3)
//            {
//                a[temp - 1] = !a[temp - 1];
//            }
//            if (temp + 3 <= 8)
//            {
//                a[temp + 3] = !a[temp + 3];
//            }
//            if (temp - 3 >= 0)
//            {
//                a[temp - 3] = !a[temp - 3];
//            }

//            return a;
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
