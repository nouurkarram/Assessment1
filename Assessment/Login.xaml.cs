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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        UserEntities db = new UserEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                MessageBox.Show("please select Admin or user");
            }
            else if (combo != null)
            {
                string data = combo.Text.ToString().Split(' ').Last();
                if (data == "Admin")
                {
                    Admin at = new Admin();

                    at = db.Admins.First(x => x.Admin_name == nametxt.Text && x.Admin_pass == passtxt.Password);
                    Admin ap = new Admin();
                    this.NavigationService.Navigate(ap);




                    if (data == "user")
                    {
                        if (nametxt.Text != "" && passtxt.Password != "")
                        {
                            usertable u = new usertable();
                            u = db.usertables.First(x => x.Username == nametxt.Text);
                            if (u.passwordd == passtxt.Password)
                            {
                                Profilexaml p = new Profilexaml();
                                this.NavigationService.Navigate(p);
                            }
                            else
                                MessageBox.Show("un correct password");

                            if (nametxt.Text != "" && passtxt.Password != "")
                            {
                                usertable u1 = new usertable();
                                u1 = db.usertables.First(x => x.Username == nametxt.Text);
                                if (u1.passwordd == passtxt.Password)
                                {
                                    Profilexaml p = new Profilexaml();
                                    this.NavigationService.Navigate(p);
                                }
                                else
                                    MessageBox.Show("un correct password");


                            }







                        }
                    }
                }
            }
        }
    









        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Signup s = new Signup();
            this.NavigationService.Navigate(s);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Forgetpass f = new Forgetpass();
            this.NavigationService.Navigate(f);
        }
    }
}
    

