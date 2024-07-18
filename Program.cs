using System;

namespace CSC295HW2
{
    public class SingleElementFinder
    {
       
        public static int FindSingle(int[] arr)
        {
            int low = 0;                    
            int high = arr.Length - 1;     

            
            while (low < high)
            {
                int mid = (low + high) / 2; 

                
                if (mid % 2 != 0)
                    mid--;                  

                
                if (arr[mid] == arr[mid + 1])
                {
                    
                    low = mid + 2;          
                }
                else
                {
                    
                    high = mid;             
                }
            }

            
            return arr[low];                
        }

        public static void Main(string[] args)
        {
            
            int[] arr1 = { 1 };                                                         
            int[] arr2 = { 1, 1, 2 };                                                   
            int[] arr3 = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };                     
            int[] arr4 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 7, 7, 8, 8, 9, 9 };         
            int[] arr5 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10,
                           11, 11, 12, 12, 15, 15, 16, 16, 17, 20, 20, 33, 33, 35, 44,
                           44, 53, 53, 77, 77, 85, 85, 100, 100 };                     

            
            Console.WriteLine("Single element in arr1: " + FindSingle(arr1)); 
            Console.WriteLine("Single element in arr2: " + FindSingle(arr2)); 
            Console.WriteLine("Single element in arr3: " + FindSingle(arr3)); 
            Console.WriteLine("Single element in arr4: " + FindSingle(arr4)); 
            Console.WriteLine("Single element in arr5: " + FindSingle(arr5)); 
        }
    }
}
    



