using System;
using PropertyChanged;
namespace TestListViewMultiSelectItems
{
	[ImplementPropertyChanged]
	public class Model
	{
		public string DisplayName { get; set; }
		public bool Selected { get; set; }

		public Model()
		{
		}
	}
}
