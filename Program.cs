using System;

namespace tapsiriq_3
{
    class Program
    {

        // tapsiriq 1
        class Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public Point()
            {
                x = 0;
                y = 0;
            }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
          
            public void Show()
            {
                Console.WriteLine("x----"+x);
                Console.WriteLine("y----"+y);
            }
        }
        //tapsiriq 2

        class Counter
        {
            public int min { get; set; }
            public int max { get; set; }
            public int currentdata { get; set; }
            public Counter()
            {
                min = 0;
                max = 0;
                currentdata = min;

            }

            public Counter(int min, int max)
            {
                this.min = min;
                this.max = max;
                currentdata = min;
            }
            public void Increment()
            {
                if (currentdata == max) currentdata = min;
                else currentdata++;


            }
            public void Show()
            {
                Console.WriteLine("Currentdata-----"+currentdata);
            }

        }
        // tapsiriq 3
        class Calculator
        {
           
            public double Plus(double first, double second)
            {
                return first + second;
    
            }
            public double Cix(double first, double second)
            {
                return first - second;

            }

            public double Vur(double first, double second)
            {
                return first * second;

            }
            public double Bol(double first, double second)
            {
                if (second is 0)
                {
                
                    return 0;
                    
                }
                else
                {
                    return first / second;
                }
             
                
            }
        }
        static void Main(string[] args)
        {
            ////tapsiriq 1
            //Point p = new(3, 4);
            //p.Show();
            /////////////////////////////////////////////////////////////
            //tapsiriq 2
            //Counter c = new(5,789);
            //while (true)
            //{
            //    c.Increment();
            //    c.Show();
            //}
            //tapsiriq 3
            Calculator c = new();
            Console.WriteLine("Cemi==="+c.Plus(5.5,6.5));
            Console.WriteLine("Ferq===="+c.Cix(5,6));
            Console.WriteLine("Vur===="+c.Vur(5,6));
            if(c.Bol(5, 0) == 0)
            {
                Console.WriteLine("sifira bolmek omaz");
            }
            else Console.WriteLine("Bol====="+ c.Bol(5, 0));
       
            

        }
    }
}
