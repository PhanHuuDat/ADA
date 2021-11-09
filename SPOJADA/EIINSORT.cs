//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIINSORT
//    {
//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();

//        static void Main(string[] args)
//        {
//            int numberOfEmployees = reader.NextInt();
//            List<Employee> employees = new List<Employee>();
//            int id, sales;

//            for(int i = 0; i < numberOfEmployees; i++)
//            {
//                id = reader.NextInt();
//                sales = reader.NextInt();
//                Employee employee = new Employee(id, sales);
//                employees.Add(employee);
//            }
//            employees = insertionSort(employees);
//            foreach(Employee key in employees)
//            {
//                result.Append(key.ID).Append(" ").Append(key.sales).Append("\n");
//            }
//            Console.WriteLine(result);


//        }
//        static List<Employee> insertionSort(List<Employee> list)
//        {
//            int n = list.Count;

//            for (int i = 1; i < n; ++i)
//            {
//                Employee key = list[i];
//                int j = i - 1;

//                while (j >= 0 && list[j].sales > key.sales)
//                {
//                    list[j + 1] = list[j];
//                    j = j - 1;
//                }
//                list[j + 1] = key;
//            }
//            return list;
//        }
//    }

//    class Employee
//    {
//        public int ID;
//        public int sales;

//        public Employee(int ID, int sales)
//        {
//            this.ID = ID;
//            this.sales = sales;
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
