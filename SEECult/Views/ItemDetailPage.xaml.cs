using SEECult.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SEECult.Views
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