using System;
/*
namespace CodeFile7
{
    
    public abstract class Figure
    {

        public abstract int perimeter();// Периметр Фигуры
        public abstract int area();//Площадь Фигуры
    }

    public class Triangle : Figure// Треугольник
    {
        int a; int b; int c;
        public Triangle(int a, int b, int c)
        { this.a = a; this.b = b; this.c = c; }
        public Triangle()
        { this.a = 0; this.b = 0; this.c = 0; }

        public void set_a(int d)
        { a = d; }

        public void set_b(int d)
        { b = d; }
        public void set_c(int d)
        { c = d; }

        public override int area()
        {
            int p = a + b + c;
            int k = p / 2;
            int S;
            return S = Convert.ToInt32(Math.Sqrt(k * (k - a) * (k - b) * (k - c)));
        }

        public override int perimeter()
        {
            int p;
            return p = a + b + c;
        }
    }

    public class Square : Figure//квадрат 
    {
        int a;//сторона квадрата 
        public Square(int a)
        { this.a = a; }
        public override int area()
        {
            int S;
            return S = Convert.ToInt32(Math.Pow(a, 2));

        }
        public Square()
        { this.a = 0; }
        public void set_a(int d)
        { a = d; }
        public override int perimeter()
        {
            int p;
            return p = 4 * a;
        }
    }
    public class Rectangle : Figure// прямоугольник 
    {
        int a;//сторона прямоугольникa  
        int b;//сторона прямоугольникa  
        public override int area()
        {
            int S;
            return S = a * b;
        }
        public Rectangle()

        { this.a = 0; this.b = 0; }
        public void set_a(int d)
        { a = d; }
        public void set_b(int d)
        { b = d; }
        public override int perimeter()
        {

            int p; return p = (a + b) * 2;
        }
    }
    public class Acircle : Figure// круг
    {
        int r;
        public Acircle(int r)
        {
            this.r = r;
        }
        public override int area()
        {
            int S;

            return S = 3 * r;
        }
        public Acircle()
        { this.r = 0; }
        public void set_r(int d)
        { r = d; }
        public override int perimeter()
        {
            //Формула периметра круга через диаметр
            int p; return p = 2 * 3 * r;

        }
    }
      
    class Составная_Фигура
    {
        static void Main(string[] args)
        {
            int t = 0, kr = 0, kv = 0, pr = 0;
            int st = 0, skr = 0, skv = 0, spr = 0;
            Console.WriteLine("Составная Фигура");
            Console.WriteLine();
            Console.WriteLine("Введите количество Треугольников");
            t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Введите сторону  а  " + i + "го");
                Triangle A = new Triangle(); A.set_a(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Введите сторону   b" + i + "го");
                A.set_b(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Введите сторону   c" + i + "го");
                A.set_c(Convert.ToInt32(Console.ReadLine()));
                st = st + A.area();
            }
            Console.WriteLine();
            Console.WriteLine("Введите количество прямоугольников");
            pr = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < pr; i++)
            {
                Console.WriteLine("Введите сторону прямоугольника  а" + i + "го");
                Rectangle A = new Rectangle();
                A.set_a(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Введите сторону прямоугольника   b" + i + "го");
                A.set_b(Convert.ToInt32(Console.ReadLine()));

                spr = spr + A.area();
            }

            Console.WriteLine();
            Console.WriteLine("Введите количество квадратов");
            kv = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kv; i++)
            {
                Console.WriteLine("Введите сторону квадрата  а  " + i + "го");
                Square A = new Square();
                A.set_a(Convert.ToInt32(Console.ReadLine()));

                skv = skv + A.area();
            }
            Console.WriteLine();
            Console.WriteLine("Введите количество кругов");
            kr = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kr; i++)
            {
                Console.WriteLine("Введите Радиус  а  " + i + "го");
                Acircle A = new Acircle();
                A.set_r(Convert.ToInt32(Console.ReadLine()));

                skr = skr + A.area();
            }
            int S = skr + skv + spr + st;

            Console.WriteLine("общая площадь" + S);
            Console.WriteLine();
                
            //Треугольник, Квадрат, Прямоугольник, Круг.
        }
        
    }
    
}

    */