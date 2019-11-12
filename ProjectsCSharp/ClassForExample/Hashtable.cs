using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

/*
Тема: Коллекции.Generic

Задание обязательное: 

Создать примитивный англо-русский и русско-английский словарь, содержащий пары слов — названий стран на русском и английском языках.
Пользователь должен иметь возможность выбирать направление перевода и запрашивать перевод.

//=========================================

Задание дополнительное:

Создать необобщенный класс точки в трехмерном пространстве с целочисленными координатами (Point3D), который наследуется от generic-класса Point2D<T>, рассмотренного в уроке.

Реализовать в классе: 
Конструктор с параметрами, который принимает начальные значения для координат точки.
Метод ToString().
*/

/*
namespace Hashtable_1
{

	class Program
	{
		static void Main()
		{
			int x = 0;
			//Console.WriteLine("B");

			Hashtable hashtable = new Hashtable();

			//hashtable.Add("1", 5);
			//hashtable.Add(10, "test");
		
			// Ключи для англ. слов		
			hashtable.Add("Ukraine", "Україна");
			hashtable.Add("USA", "США");
			hashtable.Add("Canada", "Канада");
			hashtable.Add("France", "Франция");
			hashtable.Add("Japan", "Япония");
			hashtable.Add("China", "Китай");

			// Ключи перевода
			hashtable.Add("Україна", "Ukraine");
			hashtable.Add("США", "USA");
			hashtable.Add("Канада", "Canada");
			hashtable.Add("Франция", "France");
			hashtable.Add("Япония", "Japan");
			hashtable.Add("Китай", "China");

			//WriteLine(hashtable.Count);
			//hashtable.Remove(10);
			//hashtable.Remove("1");

			//foreach (var item in hashtable.Values)
			//{
			//	WriteLine(item);
			//}



			//foreach (var item in hashtable.Keys)
			//{
			//	WriteLine(item);
			//}

			//WriteLine(hashtable[10]);


			Console.WriteLine("\t=== Программа переводчик === ");

			while (x != 3)
			{
				Console.WriteLine("\n===================================");
				Console.WriteLine("Главное меню: ");
				Console.WriteLine("Перевести слова - 1");
				Console.WriteLine("Показать содержимое словаря - 2");
				Console.WriteLine("Выход - 3");
				Console.WriteLine("===================================");

				//string a = Convert.ToString(Console.ReadLine());

				//WriteLine(hashtable["USA"]);
				//WriteLine("Перевод: " + hashtable[a]);
				x = Convert.ToInt32(Console.ReadLine());
				//Console.WriteLine("");
				if (x == 1)
				{
					Console.WriteLine("\t=== Меню перевода слов === ");
					Console.WriteLine("Меню: ");
					Console.WriteLine("Выход в главное меню - 3\n");
					while (true)
					{
						Console.WriteLine("\nВведите слово: ");
						string a = Convert.ToString(Console.ReadLine());
						Console.WriteLine("Перевод: " + hashtable[a]);

						if (a == "3")
						{
							break;
						}
					}
				}

				if (x == 2)
				{
					foreach (var item in hashtable.Values)
					{
						WriteLine(item);
					}
				}
			}
			Console.ReadLine();
		}

	}


}
*/
