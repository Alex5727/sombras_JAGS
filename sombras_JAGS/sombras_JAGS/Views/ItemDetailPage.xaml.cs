using sombras_JAGS.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace sombras_JAGS.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}