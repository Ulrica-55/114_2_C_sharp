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

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // Field to hold a list of PhoneBookEntry objects.
        private List<PhoneBookEntry> phoneList = 
            new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        // The ReadFile method reads the contents of the
        // PhoneList.txt file and stores it as PhoneBookEntry
        // objects in the phoneList.
        private void ReadFile()
        {
            try 
            {
                StreamReader inputFile;
                string line;
                char[] delim = { ',' };
                PhoneBookEntry entry = new PhoneBookEntry();
                using (inputFile = File.OpenText("PhoneList.txt"))
                {
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        string[] fields = line.Split(delim);
                        entry.name = fields[0].Trim();
                        entry.phone = fields[1];
                        phoneList.Add(entry);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        // The DisplayNames method displays the list of names
        // in the namesListBox control.
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            DisplayNames();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            if(index != -1)
            {
                string selectedName = nameListBox.SelectedItem.ToString();
                phoneLabel.Text = phoneList[index].phone;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void selectedPhoneDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
