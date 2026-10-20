namespace Assignment_3;

public partial class LagoonDetailPage : ContentPage
{
    string ProductName = "Kobe 10 Blue Lagoons";
    double ProductPrice = 549.99;
    public LagoonDetailPage()
    {
        InitializeComponent();
    }
    void AddToCartClicked(object sender, EventArgs e)
    {
        Cart.Items.Add(ProductName);
        Cart.Quantity.Add(quantityEntry.Text);
        Cart.Prices.Add(ProductPrice);
        if (string.IsNullOrWhiteSpace(quantityEntry.Text))
        {
            resultLabel.Text = "Please enter the amount of the item.";
            return;
        }


        if (double.TryParse(quantityEntry.Text, out double parsedNumber))
        {
            resultLabel.Text = $"Added {quantityEntry.Text} {ProductName} to cart.";
        }
        else
        {
            resultLabel.Text = "Please enter a valid number.";
        }
        
    }

}