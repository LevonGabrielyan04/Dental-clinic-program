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
    /// Interaction logic for ViewAnketa.xaml
    /// </summary>
    public partial class ViewAnketa : Page
    {
        public ViewAnketa()
        {
            InitializeComponent();
            anketaName.Text = UserPage.FullName;
            string[] split = anketaName.Text.Split(' ');
            ApplicationContext db = new ApplicationContext();
            List<TodoItem> items = new List<TodoItem>();
            foreach (var item in db.Visits.Where(m => m.AnketaId == db.Anketaner.FirstOrDefault(m => m.FirstName == split[0] && m.Surname == split[1] && m.Patronymic == split[2]).Id))
            {
                items.Add(new TodoItem() { Comment = item.Comment, Links = item.Files, Date = item.Time.ToShortDateString()});
            }
			icTodoList.ItemsSource = items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserPage page = new UserPage();
            Content = new Frame() { Content = page };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewPersonsAnketa page = new ViewPersonsAnketa();
            Content = new Frame() { Content = page };
        }
    }
    class TodoItem
    {
        public string Comment { get; set;}
        public string Links { get; set;}
        public string Date { get; set;}
    }
}
