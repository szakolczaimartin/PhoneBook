using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Contacts : Form
    {

        public Contacts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person member = new Person(textBox1.Text, textBox2.Text,Int32.Parse( textBox3.Text), textBox4.Text, comboBox1.Text);
            TelephoneDirectory telephoneDirectory = new TelephoneDirectory();

            telephoneDirectory.Extend(member);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var item in TelephoneDirectory.personsList)
            {
                listBox1.Items.Add(item);

            }


        }
    }
}
