using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TixMix.Views;

namespace TixMix
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                // Instantiate HomePageView
                MainWindow = new HomePageView();

                // Show MainWindow
                MainWindow.Show();

                // Log message to confirm MainWindow is shown
                Console.WriteLine("MainWindow shown successfully.");
            }
            catch (Exception ex)
            {
                // Log any exceptions that occur during instantiation or showing of MainWindow
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            base.OnStartup(e);
        }
    }
}
