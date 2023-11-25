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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для OrganizerWindow.xaml
    /// </summary>
    public partial class OrganizerWindow : Window
    {
        private organizator _currOrganisator = new organizator();
        public OrganizerWindow(organizator selectedUser)
        {
            InitializeComponent();
            if (_currOrganisator != null)
                _currOrganisator = selectedUser;

            DataContext = _currOrganisator;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Profil win = new Profil();
            win.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
