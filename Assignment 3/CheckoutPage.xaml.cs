using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3;

public partial class CheckoutPage : ContentPage
{
	public CheckoutPage()
	{
		InitializeComponent();
        List<string> rows = new List<string>();

        for (int i = 0; i < Cart.Items.Count; i++)
        {
            rows.Add(
                $"{Cart.Items[i]} | Qty: {Cart.Quantity[i]} | ${Cart.Prices[i]}"
            );
        }

        cartList.ItemsSource = rows;
    }
    
    void CheckoutButtonClicked(object sender, EventArgs e)
    {
        // Implementation for checkout button click

        Cart.Items.Clear();
        Cart.Quantity.Clear();
        Cart.Prices.Clear();

        checkoutLabel.Text = "Checkout Completed";



    }
}