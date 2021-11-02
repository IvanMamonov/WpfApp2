using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для page_reg.xaml
    /// </summary>
    public partial class page_reg : Page
    {
        public static ObservableCollection<Type> types  { get; set; }
        int i { get; set; }
        public page_reg()
        {
            InitializeComponent();
            types = new ObservableCollection<Type>(bd_connection.conection.Type.ToList());
            
            //cnb_type.Items.Add(Type.);
            this.DataContext = this;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = new Users();
            a.Fullname = name_txt.Text;
            a.login = login_txt.Text;
            a.password = password_txt.Text;
            a.id_type = 1;
            bd_connection.conection.Users.Add(a);
            bd_connection.conection.SaveChanges();
            NavigationService.GoBack();
            NavigationService.Navigate(new bron());
        }
        private void cnb_position(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Type;
            i = a.id_type;
        }
        
    }
}
