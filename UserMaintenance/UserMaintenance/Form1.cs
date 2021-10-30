using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;
using System.IO;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            lbl_FullName.Text = Resource1.FullName;
            btn_Add.Text = Resource1.Add;
            btn_WriteToFile.Text = Resource1.WriteToFile;

            list_Users.DataSource = users;
            list_Users.ValueMember = "ID";
            list_Users.DisplayMember = "FullName";

            btn_Add.Click += Btn_Add_Click;
            btn_WriteToFile.Click += Btn_WriteToFile_Click;
        }

        private void Btn_WriteToFile_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddUserToList();
        }


        private void AddUserToList()
        {
            User u = new User { FullName = txt_FullName.Text };
            users.Add(u);
        }

        private void SaveToFile()
        {
            SaveFileDialog sfd = new SaveFileDialog {Filter="Text files | *.txt", DefaultExt = "txt" };
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (User item in list_Users.Items)
                {
                    sw.WriteLine(item.ID + " - " + item.FullName);
                }
                sw.Close();
            }
        }
    }
}
