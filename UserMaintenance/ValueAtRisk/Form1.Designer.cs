﻿
namespace ValueAtRisk
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
            this.dgv_Ticks = new System.Windows.Forms.DataGridView();
            this.dgv_Portfolio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ticks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Portfolio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Ticks
            // 
            this.dgv_Ticks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ticks.Location = new System.Drawing.Point(12, 12);
            this.dgv_Ticks.Name = "dgv_Ticks";
            this.dgv_Ticks.Size = new System.Drawing.Size(568, 426);
            this.dgv_Ticks.TabIndex = 0;
            // 
            // dgv_Portfolio
            // 
            this.dgv_Portfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Portfolio.Location = new System.Drawing.Point(590, 12);
            this.dgv_Portfolio.Name = "dgv_Portfolio";
            this.dgv_Portfolio.Size = new System.Drawing.Size(257, 426);
            this.dgv_Portfolio.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 498);
            this.Controls.Add(this.dgv_Portfolio);
            this.Controls.Add(this.dgv_Ticks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ticks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Portfolio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Ticks;
        private System.Windows.Forms.DataGridView dgv_Portfolio;
    }
}

