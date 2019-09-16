using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_冒泡排序的扩展
{
    class Program
    {
        static void Sort(int[] sortArray)
        {
            bool swaaped = true;
            do
            {
                swaaped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swaaped = true;
                    }
                }
            } while (swaaped);
        }

        static void CommonSort<T>(T[] sortArray,Func<T,T,bool> compareMethod)
        {
            bool swaaped = true;
            do
            {
                swaaped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareMethod(sortArray[i],sortArray[i+1]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swaaped = true;
                    }
                }
            } while (swaaped);
        }
        static void Main(string[] args)
        {
            //int[] sortArray=new int[]{123,34,55555,223,67,87};
            //Sort(sortArray);
            //foreach (var temp in sortArray)
            //{
            // Console.WriteLine(temp+" ");   
            //}

            Employee[] employees = new Employee[]
            {
                new Employee("D", 12),
                new Employee("a", 45),
                new Employee("h", 789),
                new Employee("k", 999)
            };
            CommonSort<Employee>(employees,Employee.Compare);
            foreach (Employee em in employees)
            {
                Console.WriteLine(em);
            }
            {
                
            }

            Console.ReadKey();
        }
    }
}
