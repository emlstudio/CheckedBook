using System;
namespace CheckedBook.Model
{
	public class Account
	{
		public string Name { get; private set; }
		public string CurrentAmount
		{
			get
			{
				return "$" + _currentAmount.ToString("0.00");
			}
		}
		public Transactions Transactions { get; private set; }

		private Decimal _currentAmount;

		public Account(string name, Decimal startingAmount)
		{
			Name = name;
			_currentAmount = startingAmount;
			Transactions = new();
		}
	}
}

