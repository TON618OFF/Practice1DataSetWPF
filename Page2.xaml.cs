using practice_1.BookSystemDataSetTableAdapters;
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

namespace practice_1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {

        AuthorsTableAdapter author = new AuthorsTableAdapter();
        public Page2()
        {
            InitializeComponent();
            dg_BD_authors.ItemsSource = author.GetData();
            dg_BD_authors.DisplayMemberPath = "AuthorName";
        }

        private void next_page_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page3();
            next_page.Visibility = Visibility.Hidden;
        }
    }
}
