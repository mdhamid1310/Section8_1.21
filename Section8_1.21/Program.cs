using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_1._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }
        public static void runApp()
        {
            string[] students = { "Bob", "Alice", "David", "Grace", "Jack", "Henry", "Frank", "Ivy", "Charlie", "Ella" };

            Console.WriteLine("Unsorted Students:");
            DisplayStudents(students);

            SelectionSort(students);

            Console.WriteLine("\nSorted Students:");
            DisplayStudents(students);
        }

        public static void SelectionSort(string[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(arr[j], arr[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    // Swap the elements
                    string temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        public static void DisplayStudents(string[] arr)
        {
            foreach (string student in arr)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine();
        }

    }
}
