using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Ticketing.Views;

namespace Ticketing
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var login = new Login();
            login.Show();
            login.IsVisibleChanged += (s, ev) =>
            {
                if (login.IsVisible == false && login.IsLoaded)
                {
                    var mainView = new MainView();
                    mainView.Show();
                    login.Close();
                }
            };
        }
    }
}
