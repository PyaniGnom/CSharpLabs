using System;

namespace Tipi_dannih_v_C
{
	class Program
	{
		static void Main()
		{
			string msg = "Тип {0,8} |\t.NET {1,8} |\tРазмер = {2} \t| MIN = {3,30}\t| MAX = {4}";

			Console.Title = "Типы данных в C#";

			Console.WriteLine("\n\t\t\t\t\tЧИСЛОВЫЕ (целочисленные) ТИПЫ:\n");

			Console.WriteLine(String.Format(msg, "byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));

			Console.WriteLine(String.Format(msg, "sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));

			Console.WriteLine(String.Format(msg, "short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));

			Console.WriteLine(String.Format(msg, "ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));

			Console.WriteLine(String.Format(msg, "int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));

			Console.WriteLine(String.Format(msg, "uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));

			Console.WriteLine(String.Format(msg, "long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));

			Console.WriteLine(String.Format(msg, "ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));

			Console.WriteLine("\n\t\t\t\t\tЧИСЛОВЫЕ (с плавающей точкой) ТИПЫ:\n");

			Console.WriteLine(String.Format(msg, "float", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue));

			Console.WriteLine(String.Format(msg, "double", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue));

			Console.WriteLine(String.Format(msg, "decimal", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue));

			Console.WriteLine("\n\t\t\t\t\tСИМВОЛЬНЫЕ ТИПЫ:\n");

			Console.WriteLine(String.Format(msg, "char", typeof(char).Name, sizeof(char), char.MinValue, char.MaxValue));

			Console.WriteLine(String.Format(msg, "bool", typeof(string).Name, "N/A", "N/A", "N/A"));

			Console.WriteLine("\n\t\t\t\t\tЛОГИЧЕСКИЙ ТИП:\n");

			Console.WriteLine(String.Format(msg, "bool", typeof(bool).Name, sizeof(bool), bool.FalseString, bool.TrueString));

			Console.WriteLine("\n\t\t\t\t\tОСОБЫЕ ТИПЫ:\n");

			Console.WriteLine(String.Format(msg, "object", typeof(object).Name, "N/A", "N/A", "N/A"));

			Console.WriteLine(String.Format(msg, "dynamic", "N/A", "N/A", "N/A", "N/A"));

			Console.ReadLine();
		}
	}
}