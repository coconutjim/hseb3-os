namespace gettingProcesses
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listBoxProcessesSharp = new System.Windows.Forms.ListBox();
            this.labelInfoSharp = new System.Windows.Forms.Label();
            this.labelISC = new System.Windows.Forms.Label();
            this.listBoxProcessesPlusPlus = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelICPP = new System.Windows.Forms.Label();
            this.labelInfoPlusPlus = new System.Windows.Forms.Label();
            this.labelProcessCountCS = new System.Windows.Forms.Label();
            this.labelProcessCountCPP = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTimeCS = new System.Windows.Forms.Label();
            this.labelTimeCPP = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(150, 27);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listBoxProcessesSharp
            // 
            this.listBoxProcessesSharp.FormattingEnabled = true;
            this.listBoxProcessesSharp.Location = new System.Drawing.Point(12, 73);
            this.listBoxProcessesSharp.Name = "listBoxProcessesSharp";
            this.listBoxProcessesSharp.Size = new System.Drawing.Size(169, 225);
            this.listBoxProcessesSharp.TabIndex = 2;
            this.listBoxProcessesSharp.SelectedIndexChanged += new System.EventHandler(this.listBoxProcessesCSharp_SelectedIndexChanged);
            // 
            // labelInfoSharp
            // 
            this.labelInfoSharp.AutoSize = true;
            this.labelInfoSharp.Location = new System.Drawing.Point(9, 356);
            this.labelInfoSharp.Name = "labelInfoSharp";
            this.labelInfoSharp.Size = new System.Drawing.Size(75, 13);
            this.labelInfoSharp.TabIndex = 4;
            this.labelInfoSharp.Text = "labelInfoSharp";
            // 
            // labelISC
            // 
            this.labelISC.AutoSize = true;
            this.labelISC.Location = new System.Drawing.Point(9, 343);
            this.labelISC.Name = "labelISC";
            this.labelISC.Size = new System.Drawing.Size(76, 13);
            this.labelISC.TabIndex = 5;
            this.labelISC.Text = "Информация:";
            // 
            // listBoxProcessesPlusPlus
            // 
            this.listBoxProcessesPlusPlus.FormattingEnabled = true;
            this.listBoxProcessesPlusPlus.Location = new System.Drawing.Point(238, 73);
            this.listBoxProcessesPlusPlus.Name = "listBoxProcessesPlusPlus";
            this.listBoxProcessesPlusPlus.Size = new System.Drawing.Size(178, 225);
            this.listBoxProcessesPlusPlus.TabIndex = 6;
            this.listBoxProcessesPlusPlus.SelectedIndexChanged += new System.EventHandler(this.listBoxProcessesPlusPlus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Средствами C#:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Средствами WinAPI (C++)";
            // 
            // labelICPP
            // 
            this.labelICPP.AutoSize = true;
            this.labelICPP.Location = new System.Drawing.Point(235, 343);
            this.labelICPP.Name = "labelICPP";
            this.labelICPP.Size = new System.Drawing.Size(76, 13);
            this.labelICPP.TabIndex = 9;
            this.labelICPP.Text = "Информация:";
            // 
            // labelInfoPlusPlus
            // 
            this.labelInfoPlusPlus.AutoSize = true;
            this.labelInfoPlusPlus.Location = new System.Drawing.Point(235, 356);
            this.labelInfoPlusPlus.Name = "labelInfoPlusPlus";
            this.labelInfoPlusPlus.Size = new System.Drawing.Size(91, 13);
            this.labelInfoPlusPlus.TabIndex = 10;
            this.labelInfoPlusPlus.Text = "labelInfoPlusPLus";
            // 
            // labelProcessCountCS
            // 
            this.labelProcessCountCS.AutoSize = true;
            this.labelProcessCountCS.Location = new System.Drawing.Point(9, 301);
            this.labelProcessCountCS.Name = "labelProcessCountCS";
            this.labelProcessCountCS.Size = new System.Drawing.Size(109, 13);
            this.labelProcessCountCS.TabIndex = 11;
            this.labelProcessCountCS.Text = "labelProcessCountCS";
            // 
            // labelProcessCountCPP
            // 
            this.labelProcessCountCPP.AutoSize = true;
            this.labelProcessCountCPP.Location = new System.Drawing.Point(235, 301);
            this.labelProcessCountCPP.Name = "labelProcessCountCPP";
            this.labelProcessCountCPP.Size = new System.Drawing.Size(116, 13);
            this.labelProcessCountCPP.TabIndex = 12;
            this.labelProcessCountCPP.Text = "labelProcessCountCPP";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelTimeCS
            // 
            this.labelTimeCS.AutoSize = true;
            this.labelTimeCS.Location = new System.Drawing.Point(9, 314);
            this.labelTimeCS.Name = "labelTimeCS";
            this.labelTimeCS.Size = new System.Drawing.Size(66, 13);
            this.labelTimeCS.TabIndex = 14;
            this.labelTimeCS.Text = "labelTimeCS";
            // 
            // labelTimeCPP
            // 
            this.labelTimeCPP.AutoSize = true;
            this.labelTimeCPP.Location = new System.Drawing.Point(235, 314);
            this.labelTimeCPP.Name = "labelTimeCPP";
            this.labelTimeCPP.Size = new System.Drawing.Size(73, 13);
            this.labelTimeCPP.TabIndex = 15;
            this.labelTimeCPP.Text = "labelTimeCPP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 429);
            this.Controls.Add(this.labelTimeCPP);
            this.Controls.Add(this.labelTimeCS);
            this.Controls.Add(this.labelProcessCountCPP);
            this.Controls.Add(this.labelProcessCountCS);
            this.Controls.Add(this.labelInfoPlusPlus);
            this.Controls.Add(this.labelICPP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxProcessesPlusPlus);
            this.Controls.Add(this.labelISC);
            this.Controls.Add(this.labelInfoSharp);
            this.Controls.Add(this.listBoxProcessesSharp);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Информация о процессах";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListBox listBoxProcessesSharp;
        private System.Windows.Forms.Label labelInfoSharp;
        private System.Windows.Forms.Label labelISC;
        private System.Windows.Forms.ListBox listBoxProcessesPlusPlus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelICPP;
        private System.Windows.Forms.Label labelInfoPlusPlus;
        private System.Windows.Forms.Label labelProcessCountCS;
        private System.Windows.Forms.Label labelProcessCountCPP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelTimeCS;
        private System.Windows.Forms.Label labelTimeCPP;
    }
}

