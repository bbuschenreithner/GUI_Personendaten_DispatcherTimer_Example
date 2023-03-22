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

namespace GUI_Personendaten_dispatcherTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> personen;
        public MainWindow()
        {
            InitializeComponent();
            personen = new List<Person>();
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            personen.Add(new Person(tbxFirstname.Text, tbxLastname.Text, (DateTime)datBirthday.SelectedDate));
            lbxPersons.Items.Clear();
            foreach (Person person in personen)
            {
                lbxPersons.Items.Add(person);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lbxPersons.Items.Clear();
            personen.Clear();
        }
    }
    public class Person
    {
        private string firstname;
        public string Firstname { get { return firstname; } set { firstname = value; } }
        private string lastname;
        public String Lastname { get { return lastname; } set { lastname = value; } }
        private DateTime birthday;
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }

        public Person(string firstname, string lastname, DateTime birthday)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthday = birthday;
        }
        public override string ToString()
        {
            return firstname + " " + lastname + " " + birthday.ToShortDateString();
        }
    }
}
