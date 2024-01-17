﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintence.Entities;

namespace UserMaintence
{
    public partial class Form1 : Form
    {
        
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.LastName; // label1
            lblFirstName.Text = Resource1.FirstName; // label2
            btnAdd.Text = Resource1.Add; // button1
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            var u = new User()
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text
            };
            users.Add(u);
        }
    }
}
