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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {

        BookLoansTableAdapter bookloans = new BookLoansTableAdapter();
        public Page3()
        {
            InitializeComponent();
            dg_BD_bookloans.ItemsSource = bookloans.GetData();
            dg_BD_bookloans.DisplayMemberPath = "LoanDate";
        }
    }
}
