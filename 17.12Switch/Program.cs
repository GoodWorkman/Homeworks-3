/*
1.	в) Добавить диалог с использованием switch демонстрирующий работу класса.

*/

using System;

class Complex
{
    // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
    public double im;
    public double re;

    public Complex Plus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + this.im;
        x3.re = x2.re + this.re;
        return x3;
    }

    public Complex Minus(Complex x)
    {
        Complex y = new Complex();
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

    public Complex Multi(Complex x)
    {
        Complex y = new Complex();
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

    public string ToString()
    {
        return re + "+" + im + "i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex complex1 = new Complex();
        complex1.re = 1;
        complex1.im = 1;

        Complex complex2 = new Complex();
        complex2.re = 2;
        complex2.im = 2;
        Complex result;
        Console.WriteLine("1- сложение. 2 - вычитание. 3 - умножение");
        string n = Console.ReadLine();
        switch (n)
        {
            case "1":
                result = complex1.Plus(complex2);
                Console.WriteLine(result.ToString());
                break;
            case "2":
                result = complex1.Minus(complex2);
                Console.WriteLine(result.ToString());
                break;
            case "3":
                result = complex1.Multi(complex2);
                Console.WriteLine(result.ToString());
                break;
            default:
                Console.WriteLine("Error");
                break;
        }



    }
}
