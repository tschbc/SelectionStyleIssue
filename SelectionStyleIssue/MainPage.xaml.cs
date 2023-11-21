namespace SelectionStyleIssue
{
    public partial class MainPage : ContentPage
    {
        List<string> Items { get; set; } =
        [
            "First",
            "Second",
            "Third",
        ];

        public MainPage()
        {
            InitializeComponent();

            CollectionView.ItemsSource = Items;    
        }

        private void CollectionView_Loaded(object sender, EventArgs e)
        {
            CollectionView.SelectedItem = Items[1];
        }
    }
}
