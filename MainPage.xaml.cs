using System.Collections.ObjectModel;

namespace ShoppListMAUI
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Item> Products { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Products = new ObservableCollection<Item>();
            BindingContext = this;
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            //Products.Add(new Item { Name = EntryProduct.Text, Quantity = 1 });
            //EntryProduct.Text = string.Empty;
            await Navigation.PushAsync(new AddProductPage(Products));
            // await Shell.Current.GoToAsync(nameof(AddProductPage));

        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            Products.Remove((Item)ProductList.SelectedItem);
        }
    }
}
