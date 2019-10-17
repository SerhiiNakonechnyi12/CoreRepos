using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


/*
Тема: Индексаторы

Задание 1.
В С # индексация начинается с нуля, но в некоторых языках программирования
это не так. Например, в Turbo Pascal индексация массиве начинается с 1.
Напишите класс RangeOfArray, который  позволяет работать с массивом такого типа,
в котором индексный диапазон устанавливается пользователем.
Например, в диапазоне от 6 до 10, или от -9 до 15.
Подсказка:  В классе можно объявить две переменных, которые будут
содержать верхний и нижний индекс допустимого диапазона.

*/


namespace ConsoleApp12
{

    class classA
    {
        public int[] a;

        public classA(int size)
        {
            a = new int[size];
        }

        public int this[int index] //Индексатор
        {
            get { return a[index]; }
            set { a[index] = value; }
        }
    }
    class Program
    {
        public static void Main()
        {
            classA A = new classA(4);

            A[0] = 2;
            A[1] = 3;
            A[2] = 4;
            A[3] = 5;

            
            for (int i = 0; i < A.a.Length; i++)
            {
                WriteLine(A[i]); //2 3 4
            }
        }
    }
}