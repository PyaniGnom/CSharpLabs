using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriza
{
	internal class Program
	{
		static int Calc(int[][] Matrix, int N)
		{
			if (N == 2)
			{
				return Matrix[0][0] * Matrix[1][1] - Matrix[0][1] * Matrix[1][0]; // Определитель 2-мерной матрицы
			}
			int result = 0;
			for (int j = 0; j < N; j++)
			{
				var newMatrix = DelCol(Matrix, 0);
				newMatrix = DelRow(newMatrix, j); // создание новой матрицы 2x2 из старой
				result += (j % 2 == 1 ? -1 : 1) * Matrix[j][0] * Calc(newMatrix, N - 1); // Рекурсия для поиска минора
			}
			return result;
		}

		static int[][] MatrixCreate(int rows, int cols)
		{
			int[][] result = new int[rows][];
			for (int i = 0; i < rows; ++i)
				result[i] = new int[cols]; // автоинициализация матрицы нулей
			return result;
		}

		static int[][] DelRow(int[][] Matrix, int RowNumber) //Махинации для удаления ряда
		{
			int[][] result = new int[Matrix.Length - 1][];
			for (int i = 0, j = 0; i < Matrix.Length; i++, j++)
			{
				if (i == RowNumber)
				{
					j--;
					continue;
				}
				else
					result[j] = Matrix[i];
			}
			return result;
		}

		static int[][] DelCol(int[][] Matrix, int ColMun) // Удаление колонки
		{
			int[][] result = new int[Matrix.Length - 1][];
			result = MatrixCreate(Matrix.Length, Matrix.Length - 1);
			for (int i = 0; i < Matrix.Length; i++)
			{
				for (int j = 0, z = 0; j < Matrix.Length; j++, z++)
				{
					if (j == ColMun)
					{
						z--;
						continue;
					}
					else
					{
						result[i][z] = Matrix[i][j];
					}
				}
			}
			return result;

		}

		static void Main(string[] args)
		{
			Console.WriteLine("Введите размерность матрицы:");
            //int N = Convert.ToInt32(Console.ReadLine());
            // Меняем вот этот кусок кода, если хотим ввести матрицу другой размерности
            int N = 3;
            int[][] matrix = MatrixCreate(N, N);
            matrix[0] = new int[3] { 1, 2, 3 };
            matrix[1] = new int[3] { 5, 3, 25 };
            matrix[2] = new int[3] { 7, 8, 9 };
            // До вот этого момента (Считывание значений реализуем через цикл с помощью .Split() ).
            
            Console.WriteLine(Calc(matrix, N).ToString()); 

		}
	}
}
