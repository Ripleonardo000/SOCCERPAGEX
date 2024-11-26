using SOCCERPAGEX.Services;
using SOCCERPAGEX.ViewModels;
namespace SOCCERPAGEX.Pages
{
    public partial class LigaPage : ContentPage
    {
        public LigaPage()
        {

            InitializeComponent();

            BindingContext = new { Ligas = DataService.ObtenerLigas() };
        }
    }
}