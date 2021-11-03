
namespace ProgramDesignPattern
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_BallSelector = new System.Windows.Forms.Button();
            this.btn_CarSelector = new System.Windows.Forms.Button();
            this.lbl_NextItem = new System.Windows.Forms.Label();
            this.btn_BallColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 187);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(984, 139);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btn_BallSelector
            // 
            this.btn_BallSelector.Location = new System.Drawing.Point(12, 12);
            this.btn_BallSelector.Name = "btn_BallSelector";
            this.btn_BallSelector.Size = new System.Drawing.Size(100, 50);
            this.btn_BallSelector.TabIndex = 1;
            this.btn_BallSelector.Text = "BALL";
            this.btn_BallSelector.UseVisualStyleBackColor = true;
            this.btn_BallSelector.Click += new System.EventHandler(this.btn_BallSelector_Click);
            // 
            // btn_CarSelector
            // 
            this.btn_CarSelector.Location = new System.Drawing.Point(118, 12);
            this.btn_CarSelector.Name = "btn_CarSelector";
            this.btn_CarSelector.Size = new System.Drawing.Size(100, 50);
            this.btn_CarSelector.TabIndex = 2;
            this.btn_CarSelector.Text = "CAR";
            this.btn_CarSelector.UseVisualStyleBackColor = true;
            this.btn_CarSelector.Click += new System.EventHandler(this.btn_CarSelector_Click);
            // 
            // lbl_NextItem
            // 
            this.lbl_NextItem.AutoSize = true;
            this.lbl_NextItem.Location = new System.Drawing.Point(311, 36);
            this.lbl_NextItem.Name = "lbl_NextItem";
            this.lbl_NextItem.Size = new System.Drawing.Size(68, 13);
            this.lbl_NextItem.TabIndex = 3;
            this.lbl_NextItem.Text = "Coming next:";
            // 
            // btn_BallColor
            // 
            this.btn_BallColor.Location = new System.Drawing.Point(13, 69);
            this.btn_BallColor.Name = "btn_BallColor";
            this.btn_BallColor.Size = new System.Drawing.Size(99, 23);
            this.btn_BallColor.TabIndex = 4;
            this.btn_BallColor.UseVisualStyleBackColor = true;
            this.btn_BallColor.Click += new System.EventHandler(this.btn_BallColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 326);
            this.Controls.Add(this.btn_BallColor);
            this.Controls.Add(this.lbl_NextItem);
            this.Controls.Add(this.btn_CarSelector);
            this.Controls.Add(this.btn_BallSelector);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btn_BallSelector;
        private System.Windows.Forms.Button btn_CarSelector;
        private System.Windows.Forms.Label lbl_NextItem;
        private System.Windows.Forms.Button btn_BallColor;
    }
}

