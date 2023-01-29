using Caliburn.Micro;
using Playground.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Playground
{
    public class Bootstrapper: BootstrapperBase
    {
        public Bootstrapper() {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
