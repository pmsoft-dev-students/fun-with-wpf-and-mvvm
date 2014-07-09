using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace FunWithWpfAndMvvm
{
    public class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            OpenChildViewCommand = new RelayCommand(OpenChildView);
        }

        public ICommand OpenChildViewCommand { get; private set; }

        public void OpenChildView() {}
    }
}