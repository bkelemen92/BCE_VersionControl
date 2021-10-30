﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            lbl_FirstName.Text = Resource1.FirstName;
            lbl_LastName.Text = Resource1.LastName;
            btn_Add.Text = Resource1.Add;

            list_Users.DataSource = users;
            list_Users.ValueMember = "ID";
            list_Users.DisplayMember = "FullName";

            btn_Add.Click += Btn_Add_Click;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddUserToList();
        }

        private void AddUserToList()
        {
            User u = new User { LastName = txt_LastName.Text, FirstName = txt_FirstName.Text };
            users.Add(u);
        }
    }
}
