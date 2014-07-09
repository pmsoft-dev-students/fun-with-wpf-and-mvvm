using System;
using System.Reflection;
using System.Windows;

namespace FunWithWpfAndMvvm
{
    public class ConventionalDialogService : IDialogService
    {
        public void OpenInNewWindow<TViewModel>(TViewModel viewModel, WindowMode mode)
        {
            var viewName = typeof (TViewModel).Name.Replace("Model", "");
            var viewFullName = typeof (TViewModel).Namespace + "." + viewName;
            var viewType = Assembly.GetExecutingAssembly().GetType(viewFullName);

            if (viewType == null)
                throw new ArgumentException("Can't find view for " + typeof(TViewModel).FullName, "viewModel");

            var view = Activator.CreateInstance(viewType) as Window;

            if (view == null)
                throw new ArgumentException("Can't find view for " + typeof(TViewModel).FullName, "viewModel");

            view.DataContext = viewModel;

            if (mode == WindowMode.Modal)
                view.ShowDialog();
            else
                view.Show();
        }
    }
}