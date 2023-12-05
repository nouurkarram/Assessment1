using Microsoft.Win32;
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
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        UserEntities db = new UserEntities();
        public Signup()
        {
            InitializeComponent();
        }


        bool Isvailed(string pass)
        {
            bool Upper, lower, num, Symbol;
            Upper = lower = num = Symbol = false;
            string spetial = "!@#$%^&*()";
            foreach (char c in pass)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    Upper = true;
                }
                if (c >= 'a' && c <= 'z')
                {
                    lower = true;
                }
                if (c >= '1' && c <= '9')
                {
                    num = true;
                }
                if (spetial.Contains(c))
                {
                    Symbol = true;
                }





            }
            return Upper && lower && num && Symbol;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Isvailed(passtxt.Text)) ;
            {

                usertable u = new usertable();
                u.Username = nametxt.Text;
                u.passwordd = passtxt.Text;
                u.Phonenumber = passtxt.Text;
                int age = int.Parse(Agetxt.Text);
                u.Age = age;
                combocity.SelectedItem.ToString().Split(' ').Last();
                u.city = combocity.Text;
                db.usertables.Add(u);
                db.SaveChanges();
                MessageBox.Show("Added");
                Profilexaml p = new Profilexaml();
                this.NavigationService.Navigate(p);











            }


        }
    }
}
 



