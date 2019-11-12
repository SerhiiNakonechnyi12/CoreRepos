using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*

Интерфейсы

*/


/*
namespace Interfaces_Example
{
	public interface ISeries
	{
		int GetNext(); // возвратить следующее по порядку число
		void Reset(); // перезапустить
		void SetStart(int х); // задать начальное значение
	}

	// Использовать интерфейс ISeries для реализации // процесса генерирования простых чисел.
	class Primes : ISeries
	{
		int start;
		int val;
		public Primes()
		{
			start = 2;
			val = 2;
		}
		public int GetNext()
		{
			int i, j;
			bool isprime;
			val++;
			for (i = val; i < 1000000; i++)
			{
				isprime = true;
				for (j = 2; j <= i / j; j++)
				{
					if ((i % j) == 0)
					{
						isprime = false;
						break;
					}
				}
				if (isprime)
				{
					val = i;
					break;
				}
			}
			return val;
		}
		public void Reset()
		{
			val = start;
		}
		public void SetStart(int x)
		{
			start = x;
			val = start;
		}
	}

	// Реализовать интерфейс ISeries и добавить в // класс ByTwos метод GetPrevious().
    class ByTwos : ISeries
	{
		int start;
		int val;
		int prev;
		public ByTwos()
		{
			start = 0;
			val = 0;
			prev = -2;
		}
		public int GetNext()
		{
			prev = val;
			val += 2;
			return val;
		}
		public void Reset()
		{
			val = start;
			prev = start - 2;
		}
		public void SetStart(int x)
		{
			start = x;
			val = start;
			prev = val - 2;
		}
        // Метод, не указанный в интерфейсе ISeries.
        public int GetPrevious()
        {
            return prev;
        }
    }




class SeriesDemo
	{
		static void Main()
		{
			ByTwos ob = new ByTwos();
			for (int i = 0; i < 5; i++)
				Console.WriteLine("Следующее число равно " + ob.GetNext());
			Console.WriteLine("\nСбросить"); ob.Reset();
			for (int i = 0; i < 5; i++)
				Console.WriteLine("Следующее число равно " + ob.GetNext());
			Console.WriteLine("\nНачать с числа 100"); ob.SetStart(100);
			for (int i = 0; i < 5; i++)
				Console.WriteLine("Следующее число равно " + ob.GetNext());
		}
	}

}

*/





