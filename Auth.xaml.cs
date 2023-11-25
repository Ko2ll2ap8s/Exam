using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public static student currUser;
        public static organizator currOrganisatorUser;
        public static string authCode;

        public Auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow win = new MainWindow();
            win.Show();
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            try
            {
                var login = int.Parse(logBox.Text);
                var password = passBox.Text;
                currUser = RegistrMeetingEntities1.getContext().student.ToList().
                    Where((u) => u.ID_student == login && u.пароль == password).Single();
                if (currUser != null)
                {
                    authCode = random.Next(1111, 9999).ToString();
                    MessageBox.Show(authCode);
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность логина и пароля.");
            }

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var code = codeBox.Text;
            if(currUser != null)
            {
                MessageBox.Show("Успешно!", $"Привет, {currUser.ФИО}");
            }
            else if (currOrganisatorUser != null)
            {
                MessageBox.Show("Успешно!", $"Привет, {currOrganisatorUser.ФИО}");
                OrganizerWindow.GetWindow(this).Show();
            }

        }
    }
}
