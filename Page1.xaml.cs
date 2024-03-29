using practice_1.BookSystemDataSetTableAdapters;
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
using static MaterialDesignThemes.Wpf.Theme;

namespace practice_1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {

        BooksTableAdapter book = new BooksTableAdapter();

        public Page1()
        {
            InitializeComponent();
            dg_BD_books.ItemsSource = book.GetData();
            dg_BD_books.DisplayMemberPath = "Title";

        }

        private void dg_BD_books_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var books = (dg_BD_books.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(books.ToString());
        }

        private void next_page_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page2();
        }

        private void prev_page_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {

                this.NavigationService.GoBack();

            }
        }
    }
}
