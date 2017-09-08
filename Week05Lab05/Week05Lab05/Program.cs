using System;
using System.IO;
public class ExceptionLearning
{
    public static void Main()
    {
        int a = 10;
        int b = 20;
        int c = add(a, b);
    }
    private static int add(int a, int b)
    {
        throw new NotImplementedException();
    }
}