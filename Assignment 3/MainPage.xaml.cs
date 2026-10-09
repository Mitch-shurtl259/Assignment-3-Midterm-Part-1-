namespace Assignment_3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            itemList.ItemsSource = items;
        }

        List<string> items =
        [
        "Wilson Basketball",
            "Kobe 6 Grinches",
            "Kobe 6 Reverse Grinches",
            "Kobe 10 Proto Blue Lagoons"
        ];



        private async void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0) // How we check if the input is null or not
            {
                string picked = e.CurrentSelection[0].ToString();
                //get the first and only element from the selection list 

                itemList.SelectedItem = null;
                // Clear the selection so that the user can select the same item again if they want to
                if (picked == "Wilson Basketball")
                {
                    await Shell.Current.GoToAsync("Wilson Basketball");
                }
                else if (picked == "Kobe 6 Grinches")
                {
                    await Shell.Current.GoToAsync("Grinches");
                }
                else if (picked == "Kobe 6 Reverse Grinches")
                {
                    await Shell.Current.GoToAsync("Reverse Grinches");
                }
                else if (picked == "Kobe 10 Proto Blue Lagoons")
                {
                    await Shell.Current.GoToAsync("Blue Lagoon");
                }
            }
        }
    }
}

