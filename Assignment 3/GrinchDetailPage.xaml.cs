namespace Assignment_3;

public partial class GrinchDetailPage : ContentPage
{
    string ProductName = "Kobe 6 Grinches";
    double ProductPrice = 599.99;
    public GrinchDetailPage()
    {
        InitializeComponent();
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
            resultLabel.Text = $"Added {quantityEntry.Text} {ProductName} to cart.";
        }
        else
        {
            resultLabel.Text = "Please enter a valid number.";
        }

    }
}