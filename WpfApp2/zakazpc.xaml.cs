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
    /// Логика взаимодействия для zakazpc.xaml
    /// </summary>
    public partial class zakazpc : Page
    {
        public static ObservableCollection<Tables> types { get; set; }
        int g { get; set; }
        public zakazpc()
        {
            InitializeComponent();
            types = new ObservableCollection<Tables>(bd_connection.conection.Tables.ToList());

            this.DataContext = this;
        }
        private void id_tables_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Tables;
            
        }
    }
}
