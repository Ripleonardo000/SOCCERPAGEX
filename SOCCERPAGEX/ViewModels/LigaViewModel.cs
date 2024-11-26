using System.Collections.ObjectModel;
using System.ComponentModel;
using SOCCERPAGEX.Services;
using SOCCERPAGEX.Models;

namespace SOCCERPAGEX.ViewModels
{
    public class LigaViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Liga> Ligas { get; set; }

        public LigaViewModel()
        {
            // Carga inicial de datos
            Ligas = new ObservableCollection<Liga>(DataService.ObtenerLigas());
        }

        // Implementación de INotifyPropertyChanged para notificar cambios a la vista
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
