using System;



public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }
    public Fraction(int wholeNumber)
    {  
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
}










class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
    }
}