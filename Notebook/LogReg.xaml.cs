using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notebook
{
    /// <summary>
    /// Логика взаимодействия для LogReg.xaml
    /// </summary>
    public partial class LogReg : Window
    {
        public LogReg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegistrNewAcc registrNewAcc = new RegistrNewAcc();
            
        }

    }
}
