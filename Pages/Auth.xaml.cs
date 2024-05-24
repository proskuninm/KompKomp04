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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KompKomp04.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Voiti_Click(object sender, RoutedEventArgs e)
        {
            Users objUser = DataBaseEntities.GetContext().Users.FirstOrDefault(x => x.Login == TxtLogin.Text && x.Password == Pass.Password);

            if (objUser != null)
            {
                if (objUser.Secondname == "asda")
                {
                    MessageBox.Show("Вы уволены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                switch (objUser.Role)
                {
                    case 1:
                        Utils.Manager.MainFrame.Navigate(new Pages.AdminPage());
                        break;
                    case 2:
                        Utils.Manager.MainFrame.Navigate(new Pages.UserPage());
                        break;
                    case 3:
                        Utils.Manager.MainFrame.Navigate(new Pages.GuestPage());
                        break;
                }
            }
            
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
