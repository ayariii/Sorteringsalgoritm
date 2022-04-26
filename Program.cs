using System; 
using System.Linq;

class Sort { 
    public static void Main() 
    { 
        int[] arr = new int[] {2, 10, 5, 8, 4, 11}; 
        Console.WriteLine("Array Before Sorting:\n");
        foreach(int value in arr) 
        { 
            Console.Write(value + " "); 
        } 
        Console.WriteLine("\n");
        arr = arr.OrderByDescending(c => c).ToArray();
        Console.WriteLine("Array After Sorting:\n"); 
        foreach(int value in arr) 
        { 
            Console.Write(value + " "); 
        } 
    } 
} 