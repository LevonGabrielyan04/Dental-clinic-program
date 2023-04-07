using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for NewAnketa.xaml
    /// </summary>
    public partial class NewAnketa : Page
    {
        bool flag;
        ApplicationContext db;
        string teeth;
        UserPage page;
        public NewAnketa()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Database.EnsureCreated();
            flag = false;
            teeth = new string('0',49);
            page = new UserPage();
        }

        private void t_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string name = checkBox.Name;
            int indexToChange = Convert.ToInt32(name.Substring(1));
            StringBuilder stringBuilder = new StringBuilder(teeth);
            stringBuilder[indexToChange] = '1';
            teeth = stringBuilder.ToString();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            Anketa anketa = new Anketa();
            anketa.BirthDate = DateTime.Parse(birthDateBox.Text);
            anketa.FirstName = nameBox.Text;
            anketa.Surname = surnameBox.Text;
            anketa.Patronymic = patronymicBox.Text;
            anketa.MarkedTeeth = teeth;
            anketa.PhoneNumber = phoneNumberBox.Text;
            anketa.Notes = notesBox.Text;
            anketa.Address = addressBox.Text;
            db.Anketaner.Add(anketa);
            db.SaveChanges();
            Content = new Frame(){Content=page };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content = new Frame(){Content=page };
        }

        private void t_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string name = checkBox.Name;
            int indexToChange = Convert.ToInt32(name.Substring(1));
            StringBuilder stringBuilder = new StringBuilder(teeth);
            stringBuilder[indexToChange] = '0';
            teeth = stringBuilder.ToString();
        }
    }
}
