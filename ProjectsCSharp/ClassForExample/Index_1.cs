﻿using System;

/// <summary>
/// Пример по книге Шилда
/// </summary>

/*
namespace Index_1
{
	class RangeArray
	{
		// Закрытые данные.
		int[] a; // ссылка на базовый массив
		int lowerBound; // наименьший индекс
		int upperBound; // наибольший индекс
						// Автоматически реализуемое и доступное только для чтения свойство Length.
		public int Length { get; private set; }
		// Автоматически реализуемое и доступное только для чтения свойство Error.
		public bool Error { get; private set; }
		// Построить массив по заданному размеру.
		public RangeArray(int low, int high)
		{
			high++;
			if (high <= low)
			{
				Console.WriteLine("Неверные индексы");
				high = 1; // создать для надежности минимально допустимый массив
				low = 0;
			}
			a = new int[high - low];
			Length = high - low;
			lowerBound = low;
			upperBound = --high;
		}
		// Это индексатор для класса RangeArray.
		public int this[int index]
		{
			// Это аксессор get.
			get
			{
				if (ok(index))
				{
					Error = false;
					return a[index - lowerBound];
				}
				else
				{
					Error = true; return 0;
				}
			}
			// Это аксессор set.
			set
			{
				if (ok(index))
				{
					a[index - lowerBound] = value;
					Error = false;
				}
				else Error = true;
			}
		}
		// Возвратить логическое значение true, если
		// индекс находится в установленных границах.
		private bool ok(int index)
		{
			if (index >= lowerBound & index <= upperBound) return true;
			return false;
		}
	}
	// Продемонстрировать применение отказоустойчивого массива.
	// Продемонстрировать применение массива с произвольно
	// задаваемыми пределами индексирования.
	//
	class RangeArrayDemo
	{
		static void Main()
		{
			RangeArray ra = new RangeArray(-5, 5);
			RangeArray ra2 = new RangeArray(1, 10);
			RangeArray ra3 = new RangeArray(-20, -12);
			// Использовать объект ra в качестве массива.
			Console.WriteLine("Длина массива ra: " + ra.Length);
			for (int i = -5; i <= 5; i++)
				ra[i] = i;
			Console.Write("Содержимое массива ra: ");
			for (int i = -5; i <= 5; i++)
				Console.Write(ra[i] + " "); Console.WriteLine("\n");
			// Использовать объект ra2 в качестве массива.
			Console.WriteLine("Длина массива ra2: " + ra2.Length);
			for (int i = 1; i <= 10; i++)
				ra2[i] = i;
			Console.Write("Содержимое массива ra2: ");
			for (int i = 1; i <= 10; i++)
				Console.Write(ra2[i] + " "); Console.WriteLine("\n");
			// Использовать объект raЗ в качестве массива.
			Console.WriteLine("Длина массива ra3: " + ra3.Length);
			for (int i = -20; i <= -12; i++)
				ra3[i] = i;
			Console.Write("Содержимое массива ra3: ");
			for (int i = -20; i <= -12; i++)
				Console.Write(ra3[i] + " ");
			Console.WriteLine("\n");
		}
	}
}
*/