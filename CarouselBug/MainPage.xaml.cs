using System.Collections.ObjectModel;

namespace CarouselBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ObservableCollection<Categories> _categories = new ObservableCollection<Categories>();

            _categories.Add(new Categories() { CategoryName = "Beverages", ImageName = "dotnet_bot.png" });
            _categories.Add(new Categories() { CategoryName = "Appetizers", ImageName = "dotnet_bot.png" });
            _categories.Add(new Categories() { CategoryName = "Entrees", ImageName = "dotnet_bot.png" });
            _categories.Add(new Categories() { CategoryName = "Deserts", ImageName = "dotnet_bot.png" });

            this.CategoryCarousel.ItemsSource = _categories;

        }

        private void CategoryCarousel_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            
        }
    }
}
