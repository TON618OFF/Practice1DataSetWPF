using System;
using System.Collections.Generic;
using System.Data;
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
using practice_1.BookSystemDataSetTableAdapters;

namespace practice_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ReadersTableAdapter readers = new ReadersTableAdapter();

        BooksTableAdapter books = new BooksTableAdapter();

        AuthorsTableAdapter authors = new AuthorsTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            dg_BD_readers.ItemsSource = readers.GetData();
            dg_BD_readers.DisplayMemberPath = "ReaderName";
        }

        private void dg_BD_readers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var reader = (dg_BD_readers.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(reader.ToString());

        }

        private void next_page_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page1();
            dg_BD_readers.Visibility = Visibility.Hidden;
        }


    }
}
