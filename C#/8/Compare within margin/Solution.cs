using System;
public class Kata
{
  public static int CloseCompare(double a, double b, double margin = 0)
  {
    double delta = Math.Abs(a - b);

    if (delta <= margin) {
        return 0;
    }

    if (a < b) {
        return -1;
    }

    return 1;
  }
}