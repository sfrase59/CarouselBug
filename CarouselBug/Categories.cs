using CommunityToolkit.Mvvm.ComponentModel;

namespace CarouselBug
{
    public partial class Categories : ObservableObject
    {
        public Categories() 
        {
            
        }
        [ObservableProperty]
        private string categoryName;
        [ObservableProperty]
        private string imageName;
    }
}
