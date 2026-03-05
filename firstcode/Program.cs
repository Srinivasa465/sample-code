using System;
public class Solution {
   public static void Main (String[] args) {


      Console.WriteLine ("Enter the name");
      String str = Console.ReadLine ();

      String reverse = "";

      for (int i = str.Length - 1; i >= 0; i--) {
         reverse += str[i];
      }

      Console.WriteLine ("Reversedstring : " + reverse);
      Console.ReadLine ();
   }

  
}
