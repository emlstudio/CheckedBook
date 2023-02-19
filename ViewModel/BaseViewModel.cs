using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace CheckedBook.ViewModel
{
	public partial class BaseViewModel : ObservableObject
	{
		[ObservableProperty]
		[AlsoNotifyChangeFor(nameof(IsNotBusy))]
		bool isBusy;

		[ObservableProperty]
		string title;

		public bool IsNotBusy => !IsBusy;

		public BaseViewModel()
		{

		}
	}
}

