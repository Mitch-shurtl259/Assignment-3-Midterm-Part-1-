using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3;

public partial class ReverseDetailPage : ContentPage
{
    string ProductName = "Kobe 6 ReverseGrinches";
    double ProductPrice = 499.99;
    public ReverseDetailPage()
	{
		InitializeComponent();
        Cart.IsEnabled = false;

    }
    void AddToCartClicked(object sender, EventArgs e)
    {

        if (string.IsNullOrWhiteSpace(quantityEntry.Text))
        {
            resultLabel.Text = "Please enter the amount of the item.";
            return;
        }


        if (double.TryParse(quantityEntry.Text, out double parsedNumber))
        {
            resultLabel.Text = $"Added {quantityEntry.Text} of this item.";
        }
        else
        {
            resultLabel.Text = "Please enter a valid number.";
        }
    }
}