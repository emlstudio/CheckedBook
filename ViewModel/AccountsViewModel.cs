using System;
using CheckedBook.View;
using Microsoft.Toolkit.Mvvm.Input;

namespace CheckedBook.ViewModel
{
	public partial class AccountsViewModel : BaseViewModel
	{
		public ObservableCollection<Account> Accounts { get; } = new();

		public AccountsViewModel()
		{
			Title = "Accounts";
			GetAccountsAsync();
		}

		//[ICommand]
		private void GetAccountsAsync()
		{
			if (IsBusy)
				return;
			try
			{
				IsBusy = true;
				Accounts.Add(new Account("USAA", 5182.86m));
				Accounts.Add(new Account("Capital One", 289012.87m));
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				Shell.Current.DisplayAlert("Error!",
					$"Unable to load accounts: {ex}", "OK");
			}
			finally
			{
				IsBusy = false;
			}
		}

		[ICommand]
		async Task GoToTransactionsAsync(Transactions transactions)
		{
			if (transactions is null)
				return;

			await Shell.Current.GoToAsync($"{nameof(TransactionsPage)}", true,
				new Dictionary<string, object>
				{
					{nameof(transactions), transactions }
				});
		}
	}
}

