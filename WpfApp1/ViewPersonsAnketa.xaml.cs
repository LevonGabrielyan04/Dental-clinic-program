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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ViewPersonsAnketa.xaml
    /// </summary>
    public partial class ViewPersonsAnketa : Page
    {
        string name;
        ApplicationContext db;
        Anketa person;
        public ViewPersonsAnketa()
        {
            InitializeComponent();
            name = UserPage.FullName;
            db = new ApplicationContext();
            string[] split = name.Split(' ');
            person = db.Anketaner.First(m => m.FirstName == split[0] && m.Surname == split[1] && m.Patronymic == split[2]);
            firstName.Text = "  " + person.FirstName;
            surname.Text = "  " + person.Surname;
            patronymic.Text = "  " + person.Patronymic;
            birthDate.Text = "  " + person.BirthDate.ToShortDateString();
            address.Text = "  " + person.Address;
            notes.Text = "  " + person.Notes;
            phoneNumber.Text = "  " + person.PhoneNumber.ToString();
            if (person.MarkedTeeth[11] == '1')
                t11.IsChecked = true;
            if (person.MarkedTeeth[12] == '1')
                t12.IsChecked = true;
            if (person.MarkedTeeth[13] == '1')
                t13.IsChecked = true;
            if (person.MarkedTeeth[14] == '1')
                t14.IsChecked = true;
            if (person.MarkedTeeth[15] == '1')
                t15.IsChecked = true;
            if (person.MarkedTeeth[16] == '1')
                t16.IsChecked = true;
            if (person.MarkedTeeth[17] == '1')
                t17.IsChecked = true;
            if (person.MarkedTeeth[18] == '1')
                t18.IsChecked = true;

            if (person.MarkedTeeth[21] == '1')
                t21.IsChecked = true;
            if (person.MarkedTeeth[22] == '1')
                t22.IsChecked = true;
            if (person.MarkedTeeth[23] == '1')
                t23.IsChecked = true;
            if (person.MarkedTeeth[24] == '1')
                t24.IsChecked = true;
            if (person.MarkedTeeth[25] == '1')
                t25.IsChecked = true;
            if (person.MarkedTeeth[26] == '1')
                t26.IsChecked = true;
            if (person.MarkedTeeth[27] == '1')
                t27.IsChecked = true;
            if (person.MarkedTeeth[28] == '1')
                t28.IsChecked = true;

            if (person.MarkedTeeth[31] == '1')
                t31.IsChecked = true;
            if (person.MarkedTeeth[32] == '1')
                t32.IsChecked = true;
            if (person.MarkedTeeth[33] == '1')
                t33.IsChecked = true;
            if (person.MarkedTeeth[34] == '1')
                t34.IsChecked = true;
            if (person.MarkedTeeth[35] == '1')
                t35.IsChecked = true;
            if (person.MarkedTeeth[36] == '1')
                t36.IsChecked = true;
            if (person.MarkedTeeth[37] == '1')
                t37.IsChecked = true;
            if (person.MarkedTeeth[38] == '1')
                t38.IsChecked = true;

            if (person.MarkedTeeth[41] == '1')
                t41.IsChecked = true;
            if (person.MarkedTeeth[42] == '1')
                t42.IsChecked = true;
            if (person.MarkedTeeth[43] == '1')
                t43.IsChecked = true;
            if (person.MarkedTeeth[44] == '1')
                t44.IsChecked = true;
            if (person.MarkedTeeth[45] == '1')
                t45.IsChecked = true;
            if (person.MarkedTeeth[46] == '1')
                t46.IsChecked = true;
            if (person.MarkedTeeth[47] == '1')
                t47.IsChecked = true;
            if (person.MarkedTeeth[48] == '1')
                t48.IsChecked = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserPage page = new UserPage();
            Content = new Frame() { Content = page };
        }

        private void t_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string name = checkBox.Name;
            int indexToChange = Convert.ToInt32(name.Substring(1));
            StringBuilder stringBuilder = new StringBuilder(person.MarkedTeeth);
            stringBuilder[indexToChange] = '1';
            person.MarkedTeeth = stringBuilder.ToString();
            db.Update(person);
            db.SaveChanges();
        }

        private void t_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string name = checkBox.Name;
            int indexToChange = Convert.ToInt32(name.Substring(1));
            StringBuilder stringBuilder = new StringBuilder(person.MarkedTeeth);
            stringBuilder[indexToChange] = '0';
            person.MarkedTeeth = stringBuilder.ToString();
            db.Update(person);
            db.SaveChanges();
        }

        private void notesBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            person.Notes = notesBox.Text;
            db.Update(person);
            db.SaveChanges();
        }

        private void phoneNumberBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            person.PhoneNumber = phoneNumberBox.Text;
            db.Update(person);
            db.SaveChanges();
        }
    }
}