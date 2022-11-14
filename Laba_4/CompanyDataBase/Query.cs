// ReSharper disable StringLiteralTypo

namespace CompanyDataBase
{
	public class Query
	{
		public string ListCompany()
		{
			const string queryString = "SELECT [Название_предприятия] FROM Table1 ORDER BY [Код_предприятия]";

			return queryString;
		}

		public string ListCodeCompany()
		{
			const string queryString = "SELECT [Код_предприятия] FROM Table1 ORDER BY [Код_предприятия]";

			return queryString;
		}

		public string Default()
		{
			const string queryString = "SELECT Table1.[Код_предприятия], Table1.[Название_предприятия], Table1.[Адрес], Table2.[Название_изделия], " +
										"Table2.[Шифр_изделия], Table2.[Цена_квартала_1], Table2.[Цена_квартала_2], Table2.[Цена_квартала_3], " +
										"Table2.[Цена_квартала_4], Table2.[Годовой_выпуск] FROM(Table1 INNER JOIN Table2 ON Table1.[Код_предприятия] = " +
										"Table2.[Код_предприятия]) ORDER BY Table1.[Код_предприятия]";

			return queryString;
		}

		public string FirstTask()
		{
			const string queryString = "SELECT Table1.[Код_предприятия], Table1.[Название_предприятия], Table2.[Название_изделия], Table2.[Шифр_изделия], " +
										"Table2.[Цена_квартала_1], Table2.[Цена_квартала_2], Table2.[Цена_квартала_3], Table2.[Цена_квартала_4], " +
										"Table2.[Годовой_выпуск] FROM(Table1 INNER JOIN Table2 ON Table1.[Код_предприятия] = Table2.[Код_предприятия]) " +
										"WHERE(Table2.[Цена_квартала_2] <= Table2.[Цена_квартала_1]) AND (Table2.[Цена_квартала_3] <= Table2.[Цена_квартала_2]) " +
										"AND (Table2.[Цена_квартала_4] <= Table2.[Цена_квартала_3]) ORDER BY Table1.[Код_предприятия]";

			return queryString;
		}

		public string SecondTask(ref string searchCompanyName)
		{
			string queryString = "SELECT Table1.[Код_предприятия], Table1.[Название_предприятия], Table2.[Название_изделия], Table2.[Шифр_изделия], " +
									"Table2.[Годовой_выпуск], (Table2.[Цена_квартала_1] + Table2.[Цена_квартала_2] + Table2.[Цена_квартала_3] + " +
									"Table2.[Цена_квартала_4]) / 4 AS [Средняя_стоимость_за_год] FROM (Table1 INNER JOIN Table2 ON Table1.[Код_предприятия] = " +
									$"Table2.[Код_предприятия]) WHERE (Table1.[Название_предприятия] = '{searchCompanyName}')";

			return queryString;
		}

		public string ThirdTask()
		{
			const string queryString = "SELECT Table1.[Код_предприятия], Table1.[Название_предприятия], Table2.[Название_изделия], Table2.[Шифр_изделия], Table2.[Годовой_выпуск], " +
										"(Table2.[Цена_квартала_1] + Table2.[Цена_квартала_2] + Table2.[Цена_квартала_3] + Table2.[Цена_квартала_4]) / 4 * Table2.[Годовой_выпуск] AS [Средняя_стоимость_выпуска], " +
										"(IIf(IIf(IIf([Цена_квартала_1] > [Цена_квартала_2], [Цена_квартала_1], [Цена_квартала_2]) > [Цена_квартала_3], IIf([Цена_квартала_1] > [Цена_квартала_2], [Цена_квартала_1], [Цена_квартала_2]), " +
										"[Цена_квартала_3]) > [Цена_квартала_4], IIf(IIf([Цена_квартала_1] > [Цена_квартала_2], [Цена_квартала_1], [Цена_квартала_2]) > [Цена_квартала_3], IIf([Цена_квартала_1] > [Цена_квартала_2], " +
										"[Цена_квартала_1], [Цена_квартала_2]), [Цена_квартала_3]), [Цена_квартала_4])) * [Годовой_выпуск] AS [Максимальная_стоимость_выпуска] FROM(Table1 INNER JOIN Table2 ON Table1.[Код_предприятия] = Table2.[Код_предприятия])";

			return queryString;
		}

		public string FourthTask(string oldValue, string newValue)
		{
			string queryString = oldValue == ""
				? $"UPDATE Table2 SET[Шифр_изделия] = {newValue} WHERE([Шифр_изделия] IS NULL)"
				: $"UPDATE Table2 SET[Шифр_изделия] = {newValue} WHERE([Шифр_изделия] = {oldValue})";

			return queryString;
		}

		public string Table1()
		{
			const string queryString = "SELECT * FROM Table1 ORDER BY [Код_предприятия]";

			return queryString;
		}

		public string Table2()
		{
			const string queryString = "SELECT * FROM Table2 ORDER BY [Код_предприятия]";

			return queryString;
		}
	}
}
