using System;

namespace Massiv_4
{
	class Program
	{
		static void Main()
		{
			Console.Write("Введите количество элементов желаемого массива (от 1 до 255):\t");
			byte sizeOfmyArray = byte.Parse(Console.ReadLine());

			int[] myArray = new int[sizeOfmyArray];

			Console.WriteLine("\nЗаполните этот массив своими числами (принимаются только натуральные числа):");

			for (int i = 0; i < myArray.Length; i++)
			{
				myArray[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("\nВаш массив:");

			for (int i = 0; i < myArray.Length; i++)
			{
				Console.Write(myArray[i] + " ");
			}

			int smallestNumber = myArray[0];
			for (int i = 0; i < myArray.Length; i++)
			{
				if (myArray[i] < smallestNumber)
				{
					smallestNumber = myArray[i];
				}
			}

			Console.WriteLine("\n\nНаименьшее число вашего массива: " + smallestNumber);
			Console.ReadLine();
		}
	}
}
