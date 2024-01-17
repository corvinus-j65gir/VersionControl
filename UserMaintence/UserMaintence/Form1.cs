using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintence.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserMaintence
{
    public partial class Form1 : Form
    {
        
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource1.FullName; // label1
            btnAdd.Text = Resource1.Add; // button1
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text,
            };
            users.Add(u);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
