
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
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
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
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(209, 12);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 1;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(168, 15);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(35, 13);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "label1";
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
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(209, 38);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 4;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(168, 41);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(35, 13);
            this.lbl_FirstName.TabIndex = 5;
            this.lbl_FirstName.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 146);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.list_Users);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Users;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_FirstName;
    }
}

