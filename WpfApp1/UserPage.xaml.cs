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
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public static string FullName;
        ApplicationContext db;
        public UserPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            //db.Database.EnsureCreated();
        }

        private void Button_NewAnketa_Click(object sender, RoutedEventArgs e)
        {
            NewAnketa page = new NewAnketa();
            Content = new Frame() { Content = page };
        }

        private void Button_NewVisit_Click(object sender, RoutedEventArgs e)
        {
            NewVisit page = new NewVisit();
            Content = new Frame() { Content = page };
        }

        private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = "";
            string surname = "";
            string patronymic = "";
            var split = textBoxSearch.Text.Split(' ');
            try
            {
                name = split[0];
                surname = split[1];
                patronymic = split[2];
            }
            catch (Exception) { }
            if (name != "" && surname == "" && patronymic == "")
            {
                listOfUsers.ItemsSource = (from person in db.Anketaner
                                           where person.PhoneNumber.StartsWith(name)
                                           select person.FirstName + " " + person.Surname + " " + person.Patronymic).Take(5).ToList();
            }
            else if (name != "" && surname != "" && patronymic == "")
            {
                listOfUsers.ItemsSource = (from person in db.Anketaner
                                           where person.FirstName == name && person.Surname.StartsWith(surname)
                                           select person.FirstName + " " + person.Surname + " " + person.Patronymic).Take(5).ToList();
            }
            else if (name != "" && surname != "" && patronymic != "")
            {
                listOfUsers.ItemsSource = (from person in db.Anketaner
                                           where person.FirstName == name && person.Surname == surname && person.Patronymic.StartsWith(patronymic)
                                           select person.FirstName + " " + person.Surname + " " + person.Patronymic).Take(5).ToList();
            }
        }
        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                FullName = item.ToString().Substring(38);
                ViewAnketa page = new ViewAnketa();
                Content = new Frame() { Content = page };
            }
        }
    }
}