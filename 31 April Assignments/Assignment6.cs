class Program{ 
      static string reverseString(string str){ 
            if(str.length = 0){ 
                return str; 
            } 
            else{ 
                return str(str.length -1) + reverseString(str.Substring(0, str.length - 1));
            } 
      } 
      static void Main(string[] args){ 
            string str = "Hello"; 
            Console.WriteLine(reverseString(str));
      }
}