using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Arithmetic obj = new Arithmetic();
            obj.arth();
            Logical obj2 = new Logical();
            obj2.log();
            Relational obj3 = new Relational();
            obj3.rel();
            Assignment obj4 = new Assignment();
            obj4.Ass();
            Bitwise obj5 = new Bitwise();
            obj5.bit();
            unary obj6 = new unary();
            obj6.una();
            stringop obj7 = new stringop();
            obj7.str1();
        }
        class Arithmetic
        {
            public void arth()
            {

                int num1 = 20;
                int num2 = 30;
                int result;
                result = num1 + num2;
                Console.WriteLine("Value is {0}", result);
                result = num1 - num2;
                Console.WriteLine("Value is {0}", result);
                result = num1 * num2;
                Console.WriteLine("Value is {0}", result);
                result = num1 / num2;
                Console.WriteLine("Value is {0}", result);
                result = num1 % num2;
                Console.WriteLine("Value is {0}", result);
            }
        }
    }

}


class Logical
{
    public void log()
    {
        int x = 5;
        Console.WriteLine(x > 3 && x < 10);
        Console.WriteLine(x > 3 || x < 4);
        Console.WriteLine(!(x > 3 && x < 10));
    }
}

class Relational
{
    public void rel()
    {
        int a = 21;
        int b = 10;

        if (a == b)
        {
            Console.WriteLine(" a is equal to b");
        }
        else
        {
            Console.WriteLine(" a is not equal to b");
        }

        if (a < b)
        {
            Console.WriteLine(" a is less than b");
        }
        else
        {
            Console.WriteLine(" a is not less than b");
        }
        if (a > b)
        {
            Console.WriteLine("  a is greater than b");
        }
        else
        {
            Console.WriteLine(" a is not greater than b");
        }

        
        a = 5;
        b = 20;

        if (a <= b)
        {
            Console.WriteLine("a is either less than or equal to  b");
        }

        if (b >= a)
        {
            Console.WriteLine("b is either greater than or equal to b");
        }
    }
}


class Assignment
{
    public void Ass()
    {
        int x = 5;
        Console.WriteLine(x);
        
        x += 3;
        Console.WriteLine(x);

        x -= 3;
        Console.WriteLine(x);

        x *= 3;
        Console.WriteLine(x);

        x /= 3;
        Console.WriteLine(x);

        x &= 3;
        Console.WriteLine(x);

        x |= 3;
        Console.WriteLine(x);
    }
}


class Bitwise
{
    public void bit()
    {
        int a = 60;            
        int b = 13;            
        int c = 0;

        c = a & b;             
        Console.WriteLine( "Value of c is {0}", c);

        c = a | b;             
        Console.WriteLine("Value of c is {0}", c);

        c = a ^ b;             
        Console.WriteLine("Value of c is {0}", c);

        c = ~a;                
        Console.WriteLine(" Value of c is {0}", c);

        c = a << 2;     
        Console.WriteLine( "Value of c is {0}", c);

        c = a >> 2;      
        Console.WriteLine( "Value of c is {0}", c);
        Console.ReadLine();
    }
}

class unary
{
    public void una()
    {
        int x = 23;
        int result;

        Console.WriteLine("x is " + x);
        result = x++;
        Console.WriteLine("Post increment of x is " + x);

        Console.WriteLine("x is " + x);
        result = x--;
        Console.WriteLine("Post decrement of x is " + x);

        Console.WriteLine("x is " + x);
        result = ++x;
        Console.WriteLine("Pre increment of x is " + x);

        Console.WriteLine("x is " + x);
        result = --x;
        Console.WriteLine("Pre decrement of x is " + x);
    }
}

class stringop
{
    public void str1()
    {
        string s1 = "my";
        string s2 = "name";
        string s3 = "is pankaj";
        bool result1, result2;

       
        result1 = s1 == s2;
        Console.WriteLine("s1 is equal to s2: {0} ", result1);

        result2 = s1 == s3;
        Console.WriteLine("s1 is equal to s3: {0} ", result2);
    }
}