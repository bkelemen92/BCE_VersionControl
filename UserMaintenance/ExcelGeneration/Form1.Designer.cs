
namespace ExcelGeneration
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
            this.lbl_Magic = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_CloseExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Magic
            // 
            this.lbl_Magic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Magic.AutoSize = true;
            this.lbl_Magic.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Magic.Location = new System.Drawing.Point(39, 9);
            this.lbl_Magic.Name = "lbl_Magic";
            this.lbl_Magic.Size = new System.Drawing.Size(391, 86);
            this.lbl_Magic.TabIndex = 0;
            this.lbl_Magic.Text = "Excel Magic";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(54, 98);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "button1";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_CloseExcel
            // 
            this.btn_CloseExcel.Location = new System.Drawing.Point(135, 98);
            this.btn_CloseExcel.Name = "btn_CloseExcel";
            this.btn_CloseExcel.Size = new System.Drawing.Size(75, 23);
            this.btn_CloseExcel.TabIndex = 2;
            this.btn_CloseExcel.Text = "button1";
            this.btn_CloseExcel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 181);
            this.Controls.Add(this.btn_CloseExcel);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Magic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Magic;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_CloseExcel;
    }
}

