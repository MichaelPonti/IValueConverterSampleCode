using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		public MainWindowViewModel()
		{
			foreach (EmployeeTypeEnum v in Enum.GetValues(typeof(EmployeeTypeEnum)))
				EmployeeTypes.Add(v);
		}




		public event PropertyChangedEventHandler PropertyChanged;


		protected bool SetProperty<T>(ref T v, T value, [CallerMemberName] string propName = null)
		{
			if (Equals(v, value))
				return false;

			v = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
			return true;
		}



		private bool _isAccounting = false;
		public bool IsAccounting
		{
			get => _isAccounting;
			set => SetProperty<bool>(ref _isAccounting, value);
		}


		private string _secretAccountCode = null;
		public string SecretAccountCode
		{
			get => _secretAccountCode;
			set => SetProperty<string>(ref _secretAccountCode, value);
		}



		public ObservableCollection<EmployeeTypeEnum> EmployeeTypes { get; private set; } =
			new ObservableCollection<EmployeeTypeEnum>();

		private EmployeeTypeEnum _selectedEmployeeType = EmployeeTypeEnum.CEO;
		public EmployeeTypeEnum SelectedEmployeeType
		{
			get => _selectedEmployeeType;
			set => SetProperty<EmployeeTypeEnum>(ref _selectedEmployeeType, value);
		}
	}
}
