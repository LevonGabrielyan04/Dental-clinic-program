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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            
            db = new ApplicationContext();
            db.Database.EnsureCreated();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login =textBoxLogin.Text.Trim();
            string pass =passBox.Password.Trim();
            string pass_2 =passBox_2.Password.Trim();
            string email =textBoxEmail.Text.Trim();

            //if (login.Length < 5)
            //{
            //    textBoxLogin.ToolTip = "Это поле введено не корректно";
            //    textBoxLogin.Background = Brushes.DarkRed;
            //}
            //else if (pass.Length < 5)
            //{
            //    passBox.ToolTip = "Это поле введено не корректно";
            //    passBox.Background = Brushes.DarkRed;
            //}
            //else 
            if (pass != pass_2)
            {
                passBox_2.ToolTip = "Это поле введено не корректно";
                passBox_2.Background = Brushes.DarkRed;
            }
            else if(email.Length < 5 || !email.Contains('@') || !email.Contains('.'))
            {
                textBoxEmail.ToolTip = "Это поле введено не корректно";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                User user = new User(login,pass,email);
                db.Users.Add(user);
                db.SaveChanges();

                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Close();
            }
        }

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Close();
        }
    }
}
