﻿
namespace UserMaintenance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_Users = new System.Windows.Forms.ListBox();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_Users
            // 
            this.list_Users.FormattingEnabled = true;
            this.list_Users.Location = new System.Drawing.Point(12, 12);
            this.list_Users.Name = "list_Users";
            this.list_Users.Size = new System.Drawing.Size(120, 95);
            this.list_Users.TabIndex = 0;
            // 
            // txt_FullName
            // 
            this.txt_FullName.Location = new System.Drawing.Point(209, 12);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(100, 20);
            this.txt_FullName.TabIndex = 1;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Location = new System.Drawing.Point(168, 15);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(35, 13);
            this.lbl_FullName.TabIndex = 2;
            this.lbl_FullName.Text = "label1";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(138, 84);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "button1";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 146);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.list_Users);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Users;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Button btn_Add;
    }
}

