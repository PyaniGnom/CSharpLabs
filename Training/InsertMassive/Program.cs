using System;

namespace InsertMassive
{
	internal class Program
	{
		static void ReSize<T>(ref T[] array, int newSize)
		{
			T[] newArray = new T[newSize];

			for (int i = 0; i < array.Length && i < newArray.Length; i++)
				newArray[i] = array[i];

			array = newArray;
		}

		static void Insert(ref int[] oldArray, int value, int index)
		{
			int[] newArray = new int[oldArray.Length + 1];

			newArray[index] = value;

			for (int i = 0; i < index; i++)
				newArray[i] = oldArray[i];

			for (int i = index; i < oldArray.Length; i++)
				newArray[i + 1] = oldArray[i];

			oldArray = newArray;
		}

		static void AddFirst(ref int[] oldArray, int value)
		{
			Insert(ref oldArray, value, 0);
		}

		static void AddLast(ref int[] oldArray, int value)
		{
			Insert(ref oldArray, value, oldArray.Length);
		}

		static void Delete(ref int[] oldArray, int index)
		{
			int[] newArray = new int[oldArray.Length - 1];

			for (int i = 0; i < index; i++)
				newArray[i] = oldArray[i];

			for (int i = index + 1; i < oldArray.Length; i++)
				newArray[i - 1] = oldArray[i];

			oldArray = newArray;
		}

		static void DeleteFirst(ref int[] oldArray)
		{
			Delete(ref oldArray, 0);
		}

		static void DeleteLast(ref int[] oldArray)
		{
			Delete(ref oldArray, oldArray.Length - 1);
		}

		static void Main(string[] args)
		{
			/*
			int[] myArray = { 5, 6, 7, 8, 9 };

			string[] strArray = { "world test jopa" };

			ReSize(ref strArray, 10);
			*/

			/*
			int[] myArray = { 5, 6, 7, 8, 9 };

			Insert(ref myArray, 500, 3);

			AddLast(ref myArray, 1000);
			*/

			/*
			int[] myArray = { 5, 6, 7, 8, 9 };

			DeleteLast(ref myArray);
			*/


		}
	}
}
