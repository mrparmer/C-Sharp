﻿using System;
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
using System.Windows.;
using System.IO;

namespace Contacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataGrid dataGrid = new DataGrid(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void contactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Contacts_grid.Items.Add(new { Name = Cust_NameBox.Text, Address = Cust_AddressBox.Text, Phone = Cust_PhoneBox1.Text, Email = Cust_EmailBox.Text, Comments = Cust_CommentBox});
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
