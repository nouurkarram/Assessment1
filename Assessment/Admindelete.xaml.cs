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

namespace Assessment
{
    /// <summary>
    /// Interaction logic for Admindelete.xaml
    /// </summary>
    public partial class Admindelete : Page
    {
        UserEntities db=new UserEntities();
        public Admindelete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.usertables.Remove(db.usertables.FirstOrDefault(x => x.Phonenumber == phonenumberttxt.Text));
            db.SaveChanges();
          
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dgde.ItemsSource=db.usertables.ToList();
        }
    }
}
