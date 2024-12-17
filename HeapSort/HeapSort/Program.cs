using System.Numerics;
using System.Runtime.Intrinsics;

namespace HeapSort
{
    public class Program
    {
        public static void Heapify(List<int> arr, int n, int i)
        {
            int largest = i;       
            int left = 2 * i + 1;  
            int right = 2 * i + 2; 

            
            if (left < n && arr[left] > arr[largest])
                largest = left;

            
            if (right < n && arr[right] > arr[largest])
                largest = right;

           
            if (largest != i)
            {
                
                (arr[i], arr[largest]) = (arr[largest], arr[i]);

                Heapify(arr, n, largest);
            }
        }


        public static void HeapSortFunc(List<int> arr)
        {
            int n = arr.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {

                (arr[0], arr[i]) = (arr[i], arr[0]);


                Heapify(arr, i, 0);
            }
        }
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 9, 4, 3, 8, 10, 2, 5 };

            Console.WriteLine("Original Array:");
            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();

            
            HeapSortFunc(arr);

            Console.WriteLine("Sorted Array:");
            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }
       
    }
  
}
