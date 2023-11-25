using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DGridМероприятия.ItemsSource = RegistrMeetingEntities1.getContext().activ.ToList();
            //DGridМероприятия.ItemsSource = RegistrMeetingEntities1.getContext().meet.ToList();
        }


        private void Button_LogClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Auth win = new Auth();
            win.Show();
        }
    }
}
