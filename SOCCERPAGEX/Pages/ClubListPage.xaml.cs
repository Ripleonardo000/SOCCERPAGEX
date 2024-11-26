using SOCCERPAGEX.Services;

namespace SOCCERPAGEX.Pages;

public partial class ClubListPage : ContentPage
{
    public ClubListPage()
    {
        InitializeComponent();
        BindingContext = new { Clubes = DataService.ObtenerLigas().FirstOrDefault().Clubes };
    }

}
