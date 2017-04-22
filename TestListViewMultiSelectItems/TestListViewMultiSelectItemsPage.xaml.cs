using TestListViewMultiSelectItems.ViewModels;
using Xamarin.Forms;

namespace TestListViewMultiSelectItems
{
	public partial class TestListViewMultiSelectItemsPage : ContentPage
	{
		public TestListViewMultiSelectItemsPage()
		{
			InitializeComponent();
			this.BindingContext = new TestListViewMultiSelectItemsViewModel();
		}
	}
}
