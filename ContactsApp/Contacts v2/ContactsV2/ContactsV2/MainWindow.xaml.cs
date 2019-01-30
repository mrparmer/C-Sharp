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

namespace ContactsV2
{
    public class Customer
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }        
        public string emailAddress { get; set; }
        public string comments { get; set; }
        public DateTime lastContact { get; set; }    
       
    }

 

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            CustomerContact.ItemsSource = LoadCollectionData();
        }
        private List<Customer> LoadCollectionData()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer()
            {
                name = "Matt",
                phoneNumber = "4704308289",
                address = "6468 Pisgah Rd SW, Austell, GA 30168",
                emailAddress = "m.r.parmer@gmail.com",
                comments = "Funny guy",
                lastContact = new DateTime(2019, 1, 29),
            });

            return customers;

        }
    }
}
