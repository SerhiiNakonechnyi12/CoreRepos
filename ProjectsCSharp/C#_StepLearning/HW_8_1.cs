using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
namespace HW_8_1
{
	class Program
	{
		private static Dictionary<string, object> dict;

		private static void Add(string strKey, object dataType)
		{
			if (!dict.ContainsKey(strKey))
			{
				dict.Add(strKey, dataType);
			}
			else
			{
				dict[strKey] = dataType;
			}
		}

		private static T GetAnyValue<T>(string strKey)
		{
			object obj;
			T retType;
			dict.TryGetValue(strKey, out obj);

			try
			{
				retType = (T)obj;
			}
			catch (Exception)
			{
				retType = default(T);
			}
			return retType;
		}
        
		static void Main(string[] args)
		{
			dict = new Dictionary<string, object>();
			int x = 0;
			// Ключи для англ. слов            
			Add("Ukraine", "Україна");
			Add("USA", "США");
			Add("Canada", "Канада");
			Add("France", "Франция");
			Add("Japan", "Япония");
			Add("China", "Китай");

			// Ключи перевода
			Add("Україна", "Ukraine");
			Add("США", "USA");
			Add("Канада", "Canada");
			Add("Франция", "France");
			Add("Япония", "Japan");
			Add("Китай", "China");

			Console.WriteLine("\t=== Программа переводчик === ");

			while (x != 3)
			{
				Console.WriteLine("\n===================================");
				Console.WriteLine("Главное меню: ");
				Console.WriteLine("Перевести слова - 1");
				Console.WriteLine("Показать содержимое словаря - 2");
				Console.WriteLine("Выход - 3");
				Console.WriteLine("===================================");
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
						Console.WriteLine("Перевод: " + GetAnyValue<string>(a));

						if (a == "3")
						{
							break;
						}
					}
				}

				if (x == 2)
				{
					foreach (var item in dict)
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


