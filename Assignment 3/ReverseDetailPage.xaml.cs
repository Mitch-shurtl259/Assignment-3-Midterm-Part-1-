using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3;

public partial class ReverseDetailPage : ContentPage
{
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
            resultLabel.Text = "Added To Cart";
        }
        else
        {
            resultLabel.Text = "Please enter a valid number.";
        }
    }
}