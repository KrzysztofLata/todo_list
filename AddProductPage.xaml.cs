using System.Collections.ObjectModel;

namespace ShoppListMAUI;

public partial class AddProductPage : ContentPage
{
	private ObservableCollection<Item> _products;

    public AddProductPage(ObservableCollection<Item> products)
	{
		InitializeComponent();
		_products = products;
	}

    private async void AddButton_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrWhiteSpace(EntryProduct.Text))
		{
			_products.Add(new Item { Name = EntryProduct.Text, Quantity = 1 });
			await Navigation.PopAsync();
		}
    }
}