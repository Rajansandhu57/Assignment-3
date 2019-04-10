using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Assignment_3
{
    
        
            public delegate void Sort_DataStructure();


        class Program
        {
            static void Main(string[] args)
            {
                Student a = new Student();
                a.Announcement();

            }
        }

        class Student
        {
            String Student_name;
            String StudentID;
            double StudentGPA;

          
            public void Announcement()
            {
                try
                {

                    using (StreamReader sr = new StreamReader("U:/Users/730233/a.txt"))
                    {
                        string line;


                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }

            String[] names = new String[5] { "Bill", "Mary", "Laura", "Sam", "Steve" };
            Random r1;

            public Student()
            {
                r1 = new Random();
                Student_name = names[r1.Next(0, 4)];
                StudentID = Convert.ToString(r1.Next(1000, 9999));
                StudentGPA = Convert.ToDouble(r1.Next(1, 99));
            }

            public double AverageStudentGPA()
            {
                
                return 0;
            }
        }

        public interface IDataStructure
        {
            void Sort();
        }

        class DataStructureQueue : IDataStructure
        {
            

            public Queue q1 = new Queue();

            Sort_DataStructure Sort1;

            public void Sorter()
            {
               
            }

            public void Run()
            {
                for (int i = 0; i < 20; i++)
                {
                    q1.Enqueue(new Student());
                }
                Sort1 = new Sort_DataStructure(Sorter);
            }
            public void Sort()
            {

            }

        }

        class DataStructureStack : IDataStructure
        {
            
            public Stack s1 = new Stack();

            Sort_DataStructure Sort1;

            public void Sorter()
            {
            }

            public void Run()
            {
                for (int i = 0; i < 20; i++)
                {
                    s1.Push(new Student());
                }

                Sort1 = new Sort_DataStructure(Sorter);
            }

            public void Sort() { }
        }

    }

    namespace BubbleSort
    {
        class MySort
        {
            static void Main2(string[] args)
            {
                int[] arr = { 78, 55, 45, 98, 13 };
                int temp;

                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    for (int i = 0; i <= arr.Length - 2; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted:");
                foreach (int p in arr)
                    Console.Write(p + " ");
                Console.Read();
            }
        }
    }

    