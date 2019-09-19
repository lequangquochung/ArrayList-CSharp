using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            create();
           
        }
        static void create()
        {
            int n = int.Parse(Console.ReadLine());
            ArrayList arr = new ArrayList(n);
            Console.WriteLine("nhap vao");
            for (int i = 0; i < arr.Capacity; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr.Add(num);
            }

            for (int i = 0; i < arr.Capacity; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Insert");
            Insert(n, arr);
            Console.WriteLine("remove");
            removeArrList(n, arr);

        }
        

        static void Insert( int index, ArrayList arr) 
        {
            Console.WriteLine("Nhap Index");
            index = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Value");
            int val = int.Parse(Console.ReadLine());
            arr.Insert(index, val);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        static void removeArrList(int index, ArrayList arr)
        {
            Console.WriteLine("Nhap Index");
            index = int.Parse(Console.ReadLine());
            arr.Remove(index);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }



        


        //private static int IndexOutOfRangeException(ArrayList arr, int index)
        //{ 
        //    index = int.Parse(Console.ReadLine());            
        //    for ( int i = 0; i < arr.Capacity; i++)
        //    {
        //        arr[i] = arr[i + 1];
        //    }
        //    return ArrayList[arr];

        //}
    }
}
