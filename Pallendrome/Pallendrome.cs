using System;

namespace Pallendrome
{
  public class Pallendrome
  {
    public static string SmallestPossiblePallendrome(string value)
    {
      var forward = value;
      var reversed = ReverseString(forward);
      var comparison = reversed;

      int counter = 1;
      while (forward != comparison)
      {
        forward = value + value.Substring(0, counter);
        comparison = ReverseString(forward);

        counter++;
      }

      return forward;
    }

    private static string ReverseString(string value)
    {
      var charArray = value.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
  }

}
