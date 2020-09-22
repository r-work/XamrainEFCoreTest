using System.ComponentModel;
using Xamarin.Forms;
using XamrainEFCoreTest.ViewModels;

namespace XamrainEFCoreTest.Views
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