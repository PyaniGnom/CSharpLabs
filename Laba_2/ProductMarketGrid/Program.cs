using System;
// ReSharper disable StringLiteralTypo

namespace ProductMarketGrid
{
	internal static class Program
	{
		private static void RedText(string msg)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(msg);
			Console.ResetColor();
		}

		private static void Main()
		{
			Console.Title = "Рынки продукции | Laba02_Isaev.N.S_211 - 327";

		Again:
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Вводите только натуральные, неотрицательные числа");

		Input_Columns:
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("\nВведите количество продукции: ");

			bool checkColumns = uint.TryParse(Console.ReadLine(), out uint columns);

			if (!checkColumns)
			{
				RedText("\nОшибка! Введите корректное значение!\nПодсказка: вводите только натуральные, неотрицательные числа");
				goto Input_Columns;
			}
			switch (columns)
			{
				case 0:
					RedText("\nОшибка! Ввести нужно хотя бы не меньше 1");
					goto Input_Columns;

				case > 10:
					RedText("\nОшибка! Слишком много продукции, введите поменьше :)");
					goto Input_Columns;
			}

		Input_Rows:
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("\nВведите количество рынков: ");

			bool checkRows = uint.TryParse(Console.ReadLine(), out uint rows);

			if (!checkRows)
			{
				RedText("\nОшибка! Введите корректное значение!\nПодсказка: вводите только натуральные, неотрицательные числа");
				goto Input_Rows;
			}
			switch (rows)
			{
				case 0:
					RedText("\nОшибка! Ввести нужно хотя бы не меньше 1");
					goto Input_Rows;

				case > 20:
					RedText("\nОшибка! Слишком много рынков, введите поменьше :)");
					goto Input_Rows;
			}

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\n\nТаблица стоимости каждой продукции на каждом из рынков:\n");
			Console.ForegroundColor = ConsoleColor.White;

			int[,] myArray = new int[rows, columns];
			Random random = new();

			for (int y = 0; y < rows; y++)
			{
				for (int x = 0; x < columns; x++)
				{
					myArray[y, x] = random.Next(10, 300);
				}
			}

			Console.Write("\t\t  ");
			for (int x = 1; x <= columns; x++)
			{
				Console.Write($"Продукт №{x}    ");
			}

			Console.WriteLine();

			for (int y = 0, marketNumber = 1; y < rows; y++, marketNumber++)
			{
				Console.Write(marketNumber >= 10 ? $"Рынок №{marketNumber} " : $"Рынок №{marketNumber}  ");

				for (int x = 0; x < columns; x++)
				{
					Console.Write("{0,14}", myArray[y, x]);
				}

				Console.WriteLine();
			}

		Input_Continue:
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n\nХотите перейти к действиям с представленными данными? [Y/N]: ");

			switch (Console.ReadLine())
			{
				case "y":
				case "Y":
				Input_ProductNumber:
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("\nОпределение среднего арифметического стоимости выбранной продукции:");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Выберите продукт (введите только число — номер продукции): ");

					bool checkProductNumber = uint.TryParse(Console.ReadLine(), out uint productNumber);

					if (!checkProductNumber || productNumber == 0 || productNumber > columns)
					{
						RedText("\nОшибка! Продукта под таким номером не существует!\nПодсказка: выберите номер продукта из таблицы");
						goto Input_ProductNumber;
					}

					productNumber--;

					double averageCost = 0;
					for (int i = 0; i < rows; i++)
					{
						averageCost += myArray[i, productNumber];
					}

					productNumber++;

					Console.WriteLine($"\nСредняя стоимость продукта №{productNumber}: " + averageCost / rows);

				Input_MarketNumber:
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("\nОпределение для выбранного рынка самой дешёвой продукции:");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Выберите рынок (введите только число — номер рынка): ");

					bool checkMarketNumber = uint.TryParse(Console.ReadLine(), out uint marketNumber);

					if (!checkMarketNumber || marketNumber == 0 || marketNumber > rows)
					{
						RedText("\nОшибка! Рынка под таким номером не существует!\nПодсказка: выберите номер рынка из таблицы");
						goto Input_MarketNumber;
					}

					marketNumber--;

					double minCost = myArray[marketNumber, 0];
					for (int i = 0; i < columns; i++)
					{
						if (myArray[marketNumber, i] < minCost)
						{
							minCost = myArray[marketNumber, i];
						}
					}

					marketNumber++;

					Console.WriteLine($"\nМинимальная стоимость продукта на рынке №{marketNumber}: " + minCost);
					break;

				case "n":
				case "N":
					Console.ResetColor();
					break;

				default:
					RedText("\nОшибка! К вводу доступны только символы 'Y' и 'N'!");
					goto Input_Continue;
			}

		Input_Again:
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\n\nХотите начать заново? [Y/N]: ");

			switch (Console.ReadLine())
			{
				case "y":
				case "Y":
				Input_Clear:
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("Очистить консоль перед началом? [Y/N]: ");

					switch (Console.ReadLine())
					{
						case "y":
						case "Y":
							Console.Clear();
							goto Again;

						case "n":
						case "N":
							Console.WriteLine("\n");
							goto Again;

						default:
							RedText("\nОшибка! К вводу доступны только символы 'Y' и 'N'!\n");
							goto Input_Clear;
					}

				case "n":
				case "N":
					Console.ResetColor();
					break;

				default:
					RedText("\nОшибка! К вводу доступны только символы 'Y' и 'N'!");
					goto Input_Again;
			}

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nРабота завершена! Для закрытия консоли, нажмите клавишу ENTER");
			Console.ResetColor();
			Console.ReadLine();
		}
	}
}
