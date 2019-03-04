using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleContacts
{
    public partial class AddressbBookV1 : Form
    {
        //global array
        private Contact[] addressBook = new Contact[1];
        public AddressbBookV1()
        {
            InitializeComponent();
        }

        private void Write(Contact obj)
        {
            //loads the file into memory for SW to write to. Also sets the different fields as objects so they can be written to the text file
                StreamWriter sw = new StreamWriter("contacts.txt", true);
                sw.WriteLine(addressBook.Length + 1);
                sw.WriteLine(obj.Name);
                sw.WriteLine(obj.Phone);
                sw.WriteLine(obj.Address);
                sw.WriteLine(obj.Email);
                sw.WriteLine(obj.Comment);
                sw.WriteLine(obj.LastContact);

                for (int x = 0; x < addressBook.Length; x++)
                {
                    sw.WriteLine(addressBook[x].Name);
                    sw.WriteLine(addressBook[x].Phone);
                    sw.WriteLine(addressBook[x].Address);
                    sw.WriteLine(addressBook[x].Email);
                    sw.WriteLine(addressBook[x].Comment);
                    sw.WriteLine(addressBook[x].LastContact);
                }
                sw.Close();
            
            
            }


        private void Read()
        {
            StreamReader sr = new StreamReader("Contacts.txt");
            addressBook = new Contact[Convert.ToInt32(sr.ReadLine())];
            
            for (int x = 0; x < addressBook.Length; x++)
            {
                addressBook[x] = new Contact
                {
                    Name = sr.ReadLine(),
                    Phone = sr.ReadLine(),
                    Address = sr.ReadLine(),
                    Email = sr.ReadLine(),
                    Comment = sr.ReadLine(),
                    LastContact = sr.ReadLine()
                };
            }

            sr.Close();
        }

        private void Display()
        {
            contactsList.Items.Clear();
            for (int x = 0; x < addressBook.Length; x++)
            {
                contactsList.Items.Add(addressBook[x].ToString()); 
            }
        }

        private void clearForm()
        {
            txtName.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtComment.Text = String.Empty;
            txtContacted.Text = String.Empty;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contact obj = new Contact
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Comment = txtComment.Text,
                LastContact = txtContacted.Text
            };

            Write(obj);
            Read();
            SortbyName();
            Display();
            clearForm();            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            SortbyName();
            Display();

        }

        private void SortbyName()
        {
            Contact temp;
            bool swap;

            do
            {
                swap = false;

                for(int x =0; x < (addressBook.Length - 1); x++)
                {
                    if(addressBook[x].Name.CompareTo(addressBook[x+1].Name) > 0)
                    {
                        temp = addressBook[x];
                        addressBook[x] = addressBook[x + 1];
                        addressBook[x + 1] = temp;
                        swap = true;
                    }
                }

            } while (swap == true);
            
        }
        private void SortbyDate()
        {
            Contact temp;
            bool swap;

            do
            {
                swap = false;

                for (int x = 0; x < (addressBook.Length - 1); x++)
                {
                    if (addressBook[x].LastContact.CompareTo(addressBook[x + 1].LastContact) > 0)
                    {
                        temp = addressBook[x];
                        addressBook[x] = addressBook[x + 1];
                        addressBook[x + 1] = temp;
                        swap = true;
                    }
                }

            } while (swap == true);

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortbyName();
            Display();
        }

        private void btnDateSort_Click(object sender, EventArgs e)
        {
            SortbyDate();
            Display();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contactsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
