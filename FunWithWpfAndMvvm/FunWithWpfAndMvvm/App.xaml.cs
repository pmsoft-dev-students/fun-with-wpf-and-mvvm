﻿using System.Windows;

namespace FunWithWpfAndMvvm
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var shellView = new ShellView {DataContext = new ShellViewModel(new ConventionalDialogService())};
            shellView.Show();
        }
    }
}