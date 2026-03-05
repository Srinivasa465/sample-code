using System;
public class Solution {
   public static void Main (String[] args) {


      Console.WriteLine ("Enter the name");
      String str = Console.ReadLine ();

      String reversed = "";

      for (int i = str.Length - 1; i >= 0; i--) {
         reversed += str[i];
      }

      Console.WriteLine ("Reversed string : " + reversed);
      Console.ReadLine ();
   }

  
}
