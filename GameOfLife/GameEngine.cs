using System;

namespace GameOfLife
{
	public class GameEngine
	{
		public uint CurrentGeneration { get; private set; }
		private bool[,] _field;
		private readonly int _rows;
		private readonly int _cols;

		public GameEngine(int rows, int cols, int density)
		{
			_rows = rows;
			_cols = cols;
			_field = new bool[cols, rows];

			Random random = new Random();
			for (int x = 0; x < cols; x++)
			{
				for (int y = 0; y < rows; y++)
				{
					_field[x, y] = random.Next(density) == 0;
				}
			}
		}

		public void NextGeneration()
		{
			bool[,] newField = new bool[_cols, _rows];

			for (int x = 0; x < _cols; x++)
			{
				for (int y = 0; y < _rows; y++)
				{
					int neighboursCount = CountNeighbours(x, y);
					bool hasLife = _field[x, y];

					if (!hasLife && neighboursCount == 3)
						newField[x, y] = true;
					else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
						newField[x, y] = false;
					else
						newField[x, y] = _field[x, y];
				}
			}
			_field = newField;
			CurrentGeneration++;
		}

		public bool[,] GetCurrentGeneration()
		{
			bool[,] result = new bool[_cols, _rows];

			for (int x = 0; x < _cols; x++)
			{
				for (int y = 0; y < _rows; y++)
				{
					result[x, y] = _field[x, y];
				}
			}

			return result;
		}

		private int CountNeighbours(int x, int y)
		{
			int count = 0;

			for (int i = -1; i < 2; i++)
			{
				for (int j = -1; j < 2; j++)
				{
					int col = (x + i + _cols) % _cols;
					int row = (y + j + _rows) % _rows;

					bool isSelfChecking = col == x && row == y;
					bool hasLife = _field[col, row];

					if (hasLife && !isSelfChecking)
						count++;
				}
			}

			return count;
		}

		private bool ValidateCellPosition(int x, int y)
		{
			return x >= 0 && y >= 0 && x < _cols && y < _rows;
		}

		private void UpdateCell(int x, int y, bool state)
		{
			if (ValidateCellPosition(x, y))
				_field[x, y] = state;
		}

		public void AddCell(int x, int y)
		{
			UpdateCell(x, y, state: true);
		}

		public void RemoveCell(int x, int y)
		{
			UpdateCell(x, y, state: false);
		}

	}
}
