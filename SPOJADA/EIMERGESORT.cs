//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIMERGESORT
//    {
//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();

//        static void Main(string[] args)
//        {
//            int numberOfEmployees = reader.NextInt();
//            List<Employee> employees = new List<Employee>();
//            int id, sales;

//            for (int i = 0; i < numberOfEmployees; i++)
//            {
//                id = reader.NextInt();
//                sales = reader.NextInt();
//                Employee employee = new Employee(id, sales);
//                employees.Add(employee);
//            }
//            employees = sort(employees, 0, employees.Count - 1);
//            foreach (Employee key in employees)
//            {
//                result.Append(key.ID).Append(" ").Append(key.sales).Append("\n");
//            }
//            Console.WriteLine(result);


//        }
//        static List<Employee> merge(List<Employee> list, int l, int m, int r)
//        {

//            // Tìm kích thước của 2 mảng con để merged
//            int n1 = m - l + 1;
//            int n2 = r - m;

//            // Tạo mảng tạm
//            List<Employee> L = new List<Employee>();
//            List<Employee> R = new List<Employee>();


//            int i = 0, j = 0;
//            // Copy dữ liệu vào mảng tạm
//            for (i = 0; i < n1; ++i)
//            {
//                L.Add(list[l + i]);
//            }

//            for (j = 0; j < n2; ++j)
//            {
//                R.Add(list[m + 1 + j]);
//            }


//            // Merge các mảng tạm lại
//            // Chỉ mục ban đầu của 2 mảng con
//            i = 0;
//            j = 0;

//            // Chỉ mục ban đầu của mảng phụ được hợp nhất
//            int k = l;
//            while (i < n1 && j < n2)
//            {
//                if (L[i].sales <= R[j].sales)
//                {
//                    list[k] = L[i];
//                    i++;
//                }
//                else
//                {
//                    list[k] = R[j];
//                    j++;
//                }
//                k++;
//            }

//            // Sao chép các phần tử còn lại của L[] nếu có
//            while (i < n1)
//            {
//                list[k] = L[i];
//                i++;
//                k++;
//            }

//            // Sao chép các phần tử còn lại của R[] nếu có
//            while (j < n2)
//            {
//                list[k] = R[j];
//                j++;
//                k++;
//            }
//            return list;
//        }

//        static List<Employee> sort(List<Employee> list, int l, int r)
//        {
//            if (l < r)
//            {

//                // Tìm điểm chính giữa
//                int m = (l + r) / 2;

//                // Hàm đệ quy tiếp tục chia đôi
//                sort(list, l, m);
//                sort(list, m + 1, r);

//                merge(list, l, m, r);
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
