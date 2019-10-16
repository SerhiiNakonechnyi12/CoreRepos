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
        public int[,] array;

        public classA(int rows, int cols)
        {
            array = new int[rows, cols];
        }

        public int this[int rows, int cols] //Двумерный индексатор
        {
            get { return array[rows, cols]; }
            set { array[rows, cols] = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            classA A = new classA(2, 3);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    A[i, j] = j;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Write(A[i, j]);
                }
                WriteLine();
            }
        }
    }
}

