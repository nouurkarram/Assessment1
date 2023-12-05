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
using System.Xml.Linq;

namespace Assessment
{
    /// <summary>
    /// Interaction logic for Adminsearch.xaml
    /// </summary>
    public partial class Adminsearch : Page
    {
        UserEntities db=new UserEntities();

        public Adminsearch()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           dgsearch.ItemsSource=db.usertables.Where(x=> x.city==citytxt.Text).ToList();
           


        }
    }
}
