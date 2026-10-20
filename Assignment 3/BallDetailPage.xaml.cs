namespace Assignment_3;

public partial class BallDetailPage : ContentPage
{
    string ProductName = "Basketball";
    double ProductPrice = 59.99;
	public BallDetailPage()
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