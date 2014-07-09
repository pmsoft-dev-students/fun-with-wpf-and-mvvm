namespace FunWithWpfAndMvvm
{
    public interface IDialogService
    {
        void OpenInNewWindow<TViewModel>(TViewModel viewModel, WindowMode mode);
    }
}