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
using System.IO;

namespace ContactsV2
{
    public class Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }        
        public string Email { get; set; }
        public string Comments { get; set; }
        public DateTime LastContacted { get; set; }    

        public Customer (string name, string phoneNumber, string address, string emailAddress, string comments, DateTime lastContact)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = emailAddress;
            Comments = comments;
            LastContacted = lastContact;
        }
       
    }
    
    public static IEnumerable<Customer> ReadCSV(string filename)
    {
        string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(filename, ".csv"));

        return lines.Select(line =>
        {
            string[] data = line.Split(',');
            return new Customer(data[0], data[1], data[2], data[3], data[4], Convert.ToDateTime(data[5]));
        });
    }
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            CustomerContact.ItemsSource = LoadCollectionData();
        }
        
    }
}
