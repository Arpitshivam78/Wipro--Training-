// Print array elements recursively 

using System; 

class Program{ 
     static void Main(){ 
          int[] arr = {1,2,3,4,5}; 
          PrintArray(arr, 0); 
     } 
     static void PrintArray(int[] arr, int index){ 
          if(index == arr.Length){ 
            return;  
          } 
          Console.WriteLine(arr[index]); 
          PrintArray(arr, index + 1); 

     }
}