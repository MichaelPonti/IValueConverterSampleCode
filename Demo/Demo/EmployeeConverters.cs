using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Demo
{
	public class EmployeeColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			EmployeeTypeEnum empType = (EmployeeTypeEnum) value;
			switch(empType)
			{
				case EmployeeTypeEnum.CEO:
					return Brushes.Aqua;
				case EmployeeTypeEnum.EngDirector:
					return Brushes.Green;
				case EmployeeTypeEnum.Engineer:
					return Brushes.Red;
				case EmployeeTypeEnum.VicePres:
					return Brushes.Blue;
				default:
					return Brushes.Black;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
