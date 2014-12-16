﻿using Examiner_Pro.Examiner.GUI;
using Examiner_Pro.Examiner;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Examiner_Pro.DataLayer;
using Examiner_Pro.Utils;

namespace Examiner_Pro
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public  void ApplicationStart(object sender, StartupEventArgs e)
        {
            //Disable shutdown when the dialog closes
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            var dialog = new LoginWindow();

            
            if (dialog.ShowDialog() == true)
            {
                var mainWindow = new Main();
                //Re-enable normal shutdown mode.
                Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                Current.MainWindow = mainWindow;
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Unable to load data.", "Error", MessageBoxButton.OK);
                Current.Shutdown(-1);
            }
        }
    }
}
