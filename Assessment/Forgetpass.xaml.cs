using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Forgetpass.xaml
    /// </summary>
    public partial class Forgetpass : Page
    {
        UserEntities db = new UserEntities();
        public Forgetpass()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (phonetxt.Text != null && newpasstxt.Text != "" && confirmtxt.Text != null) ;
            {
                if (Isvailed(newpasstxt.Text))
                {
                    if (confirmtxt.Text == newpasstxt.Text)
                    {
                        usertable u = new usertable();
                        u = db.usertables.FirstOrDefault(x => x.Phonenumber == phonetxt.Text);
                        db.usertables.AddOrUpdate(u);
                        db.SaveChanges();


                    }
                    else
                        MessageBox.Show("enter correct password");
                }
                else
                    MessageBox.Show("Enter passwprd contain number and char and spetail");
               


            }
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
            return Upper && lower&& num && Symbol;



        }

    }
}


    
    


