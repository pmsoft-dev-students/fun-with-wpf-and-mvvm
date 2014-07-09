using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace FunWithWpfAndMvvm
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly IDialogService _dialogService;

        public ShellViewModel(IDialogService dialogService)
        {
            if (dialogService == null)
                throw new ArgumentNullException("dialogService");

            _dialogService = dialogService;

            OpenChildViewCommand = new RelayCommand(OpenChildView);
        }

        public ICommand OpenChildViewCommand { get; private set; }

        public void OpenChildView()
        {
            _dialogService.OpenInNewWindow(new ChildViewModel(), WindowMode.NonModal);
        }
    }
}