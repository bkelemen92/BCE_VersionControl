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
        #region LISTA
        BindingList<User> users = new BindingList<User>();
        #endregion


        #region CONSTRUKTOR
        public Form1()
        {
            InitializeComponent();
            lbl_FullName.Text = Resource1.FullName;
            btn_Add.Text = Resource1.Add;
            btn_WriteToFile.Text = Resource1.WriteToFile;
            btn_Remove.Text = Resource1.Remove;

            list_Users.DataSource = users;
            list_Users.ValueMember = "ID";
            list_Users.DisplayMember = "FullName";

            btn_Add.Click += Btn_Add_Click;
            btn_WriteToFile.Click += Btn_WriteToFile_Click;
            btn_Remove.Click += Btn_Remove_Click;
        }
        #endregion



        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            RemoveFromList((User)list_Users.SelectedItem);
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
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Text files | *.txt |Excel files | *.xlsx", DefaultExt = "txt" };
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                /*
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (User u in list_Users.Items)
                {
                    sw.WriteLine(u.ID + "," + u.FullName);
                }
                sw.Close();
                */
            }
        }

        private void RemoveFromList(User selectedItem)
        {
            if (list_Users.SelectedItem != null) users.Remove(selectedItem);
        }
        



    }
}
