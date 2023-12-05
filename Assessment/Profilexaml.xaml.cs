using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Interaction logic for Profilexaml.xaml
    /// </summary>
    public partial class Profilexaml : Page
    {
        UserEntities db = new UserEntities();
        public Profilexaml()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            usertable usertable= new usertable();
            usertable = db.usertables.FirstOrDefault(x => x.Phonenumber == phonetxt.Text);
            

        }
    }
}
