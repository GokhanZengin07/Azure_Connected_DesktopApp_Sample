
using System;

namespace Siemens_SSS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ControlBind = new System.Windows.Forms.TabControl();
            this.Anasayfa = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.LMS = new System.Windows.Forms.TabPage();
            this.dgvlms = new System.Windows.Forms.DataGridView();
            this.LMSTextBox = new System.Windows.Forms.TextBox();
            this.GuncelleLMS = new System.Windows.Forms.Button();
            this.RVS = new System.Windows.Forms.TabPage();
            this.guncelleRVS = new System.Windows.Forms.Button();
            this.dgvRVS = new System.Windows.Forms.DataGridView();
            this.LMV = new System.Windows.Forms.TabPage();
            this.LME = new System.Windows.Forms.TabPage();
            this.LFS = new System.Windows.Forms.TabPage();
            this.Help = new System.Windows.Forms.TabPage();
            this.ControlBind.SuspendLayout();
            this.Anasayfa.SuspendLayout();
            this.LMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlms)).BeginInit();
            this.RVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRVS)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlBind
            // 
            this.ControlBind.Controls.Add(this.Anasayfa);
            this.ControlBind.Controls.Add(this.LMS);
            this.ControlBind.Controls.Add(this.RVS);
            this.ControlBind.Controls.Add(this.LMV);
            this.ControlBind.Controls.Add(this.LME);
            this.ControlBind.Controls.Add(this.LFS);
            this.ControlBind.Controls.Add(this.Help);
            this.ControlBind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ControlBind.Location = new System.Drawing.Point(0, 0);
            this.ControlBind.Name = "ControlBind";
            this.ControlBind.SelectedIndex = 0;
            this.ControlBind.Size = new System.Drawing.Size(801, 448);
            this.ControlBind.TabIndex = 8;
            this.ControlBind.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Anasayfa
            // 
            this.Anasayfa.Controls.Add(this.label1);
            this.Anasayfa.Location = new System.Drawing.Point(4, 29);
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Size = new System.Drawing.Size(793, 415);
            this.Anasayfa.TabIndex = 8;
            this.Anasayfa.Text = "Anasayfa";
            this.Anasayfa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // LMS
            // 
            this.LMS.Controls.Add(this.dgvlms);
            this.LMS.Controls.Add(this.LMSTextBox);
            this.LMS.Controls.Add(this.GuncelleLMS);
            this.LMS.Location = new System.Drawing.Point(4, 29);
            this.LMS.Name = "LMS";
            this.LMS.Padding = new System.Windows.Forms.Padding(3);
            this.LMS.Size = new System.Drawing.Size(793, 415);
            this.LMS.TabIndex = 3;
            this.LMS.Text = "LMS";
            this.LMS.UseVisualStyleBackColor = true;
            // 
            // dgvlms
            // 
            this.dgvlms.AllowUserToAddRows = false;
            this.dgvlms.AllowUserToDeleteRows = false;
            this.dgvlms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvlms.ColumnHeadersHeight = 29;
            this.dgvlms.Location = new System.Drawing.Point(3, 35);
            this.dgvlms.Name = "dgvlms";
            this.dgvlms.ReadOnly = true;
            this.dgvlms.RowHeadersWidth = 200;
            this.dgvlms.RowTemplate.Height = 29;
            this.dgvlms.Size = new System.Drawing.Size(787, 377);
            this.dgvlms.TabIndex = 8;
            // 
            // LMSTextBox
            // 
            this.LMSTextBox.Location = new System.Drawing.Point(103, 4);
            this.LMSTextBox.Name = "LMSTextBox";
            this.LMSTextBox.Size = new System.Drawing.Size(687, 27);
            this.LMSTextBox.TabIndex = 6;
            this.LMSTextBox.TextChanged += new System.EventHandler(this.LMSTextBox_TextChanged);
            // 
            // GuncelleLMS
            // 
            this.GuncelleLMS.Location = new System.Drawing.Point(3, 3);
            this.GuncelleLMS.Name = "GuncelleLMS";
            this.GuncelleLMS.Size = new System.Drawing.Size(94, 29);
            this.GuncelleLMS.TabIndex = 4;
            this.GuncelleLMS.Text = "Güncelle";
            this.GuncelleLMS.UseVisualStyleBackColor = true;
            this.GuncelleLMS.Click += new System.EventHandler(this.GuncelleLMS_Click);
            // 
            // RVS
            // 
            this.RVS.Controls.Add(this.guncelleRVS);
            this.RVS.Controls.Add(this.dgvRVS);
            this.RVS.Location = new System.Drawing.Point(4, 29);
            this.RVS.Name = "RVS";
            this.RVS.Padding = new System.Windows.Forms.Padding(3);
            this.RVS.Size = new System.Drawing.Size(793, 415);
            this.RVS.TabIndex = 4;
            this.RVS.Text = "RVS";
            this.RVS.UseVisualStyleBackColor = true;
            // 
            // guncelleRVS
            // 
            this.guncelleRVS.Location = new System.Drawing.Point(3, 4);
            this.guncelleRVS.Name = "guncelleRVS";
            this.guncelleRVS.Size = new System.Drawing.Size(94, 29);
            this.guncelleRVS.TabIndex = 6;
            this.guncelleRVS.Text = "Güncelle";
            this.guncelleRVS.UseVisualStyleBackColor = true;
            // 
            // dgvRVS
            // 
            this.dgvRVS.AllowUserToAddRows = false;
            this.dgvRVS.AllowUserToDeleteRows = false;
            this.dgvRVS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRVS.ColumnHeadersHeight = 29;
            this.dgvRVS.Location = new System.Drawing.Point(3, 36);
            this.dgvRVS.Name = "dgvRVS";
            this.dgvRVS.ReadOnly = true;
            this.dgvRVS.RowHeadersWidth = 200;
            this.dgvRVS.RowTemplate.Height = 29;
            this.dgvRVS.Size = new System.Drawing.Size(787, 374);
            this.dgvRVS.TabIndex = 7;
            // 
            // LMV
            // 
            this.LMV.Location = new System.Drawing.Point(4, 29);
            this.LMV.Name = "LMV";
            this.LMV.Padding = new System.Windows.Forms.Padding(3);
            this.LMV.Size = new System.Drawing.Size(793, 415);
            this.LMV.TabIndex = 5;
            this.LMV.Text = "LMV";
            this.LMV.UseVisualStyleBackColor = true;
            // 
            // LME
            // 
            this.LME.Location = new System.Drawing.Point(4, 29);
            this.LME.Name = "LME";
            this.LME.Padding = new System.Windows.Forms.Padding(3);
            this.LME.Size = new System.Drawing.Size(793, 415);
            this.LME.TabIndex = 6;
            this.LME.Text = "LME";
            this.LME.UseVisualStyleBackColor = true;
            // 
            // LFS
            // 
            this.LFS.Location = new System.Drawing.Point(4, 29);
            this.LFS.Name = "LFS";
            this.LFS.Padding = new System.Windows.Forms.Padding(3);
            this.LFS.Size = new System.Drawing.Size(793, 415);
            this.LFS.TabIndex = 2;
            this.LFS.Text = "LFS";
            this.LFS.UseVisualStyleBackColor = true;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(4, 29);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(793, 415);
            this.Help.TabIndex = 7;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlBind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Siemens Sık Sorulan Sorular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlBind.ResumeLayout(false);
            this.Anasayfa.ResumeLayout(false);
            this.Anasayfa.PerformLayout();
            this.LMS.ResumeLayout(false);
            this.LMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlms)).EndInit();
            this.RVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRVS)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        
        private System.Windows.Forms.TabPage LMS;
        private System.Windows.Forms.TabPage RVS;
        private System.Windows.Forms.TabPage LMV;
        private System.Windows.Forms.TabPage LME;
        private System.Windows.Forms.TabPage LFS;
        private System.Windows.Forms.TabControl ControlBind;
        private System.Windows.Forms.Button GuncelleLMS;
        private System.Windows.Forms.TabPage Help;
        
        private System.Windows.Forms.DataGridView dgvRVS;
        private System.Windows.Forms.Button guncelleRVS;
        
        private System.Windows.Forms.TabPage Anasayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LMSTextBox;
        private System.Windows.Forms.DataGridView dgvlms;

        public object Button1 { get; private set; }
    }
}

