using System;
using System.Collections.ObjectModel;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page_author.xaml
    /// </summary>
    public partial class Page_author : Page
    {
        public static ObservableCollection<Users> users { get; set; }
        public Page_author()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<Users>(bd_connection.conection.Users.ToList());
            var z = users.Where(s => s.login == txt_login.Text && s.password == txt_passwors.Password).FirstOrDefault();
            if (z != null)
            {
                MessageBox.Show(z.Fullname);
            }
            else
            {
                MessageBox.Show("логин или пароль не верные" , "error" , MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new page_reg());
        }
    }
}
