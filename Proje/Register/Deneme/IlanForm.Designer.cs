namespace Deneme
{
    partial class IlanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlanForm));
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.chkIsDeleted = new System.Windows.Forms.CheckBox();
            this.btnIlan = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblModelSec = new System.Windows.Forms.Label();
            this.lblArabaSec = new System.Windows.Forms.Label();
            this.lblUserSec = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbModels = new System.Windows.Forms.ComboBox();
            this.cmbArac = new System.Windows.Forms.ComboBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.grpİlan = new System.Windows.Forms.GroupBox();
            this.dgwIlan = new System.Windows.Forms.DataGridView();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpForm.SuspendLayout();
            this.grpİlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIlan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.btnBack);
            this.grpForm.Controls.Add(this.dtpBitis);
            this.grpForm.Controls.Add(this.dtpBaslangic);
            this.grpForm.Controls.Add(this.btnDelete);
            this.grpForm.Controls.Add(this.btnClean);
            this.grpForm.Controls.Add(this.chkIsDeleted);
            this.grpForm.Controls.Add(this.btnIlan);
            this.grpForm.Controls.Add(this.lblComment);
            this.grpForm.Controls.Add(this.lblBitis);
            this.grpForm.Controls.Add(this.lblBaslangic);
            this.grpForm.Controls.Add(this.lblModelSec);
            this.grpForm.Controls.Add(this.lblArabaSec);
            this.grpForm.Controls.Add(this.lblUserSec);
            this.grpForm.Controls.Add(this.txtComment);
            this.grpForm.Controls.Add(this.cmbModels);
            this.grpForm.Controls.Add(this.cmbArac);
            this.grpForm.Controls.Add(this.cmbUsers);
            this.grpForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpForm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpForm.Location = new System.Drawing.Point(0, 0);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(800, 378);
            this.grpForm.TabIndex = 3;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "İlan Formu ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(410, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClean.Location = new System.Drawing.Point(168, 329);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(96, 28);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "TEMİZLE";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // chkIsDeleted
            // 
            this.chkIsDeleted.AutoSize = true;
            this.chkIsDeleted.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkIsDeleted.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkIsDeleted.Location = new System.Drawing.Point(525, 336);
            this.chkIsDeleted.Name = "chkIsDeleted";
            this.chkIsDeleted.Size = new System.Drawing.Size(91, 23);
            this.chkIsDeleted.TabIndex = 9;
            this.chkIsDeleted.Text = "Silinmiş mi";
            this.chkIsDeleted.UseVisualStyleBackColor = false;
            this.chkIsDeleted.CheckedChanged += new System.EventHandler(this.chkIsDeleted_CheckedChanged);
            // 
            // btnIlan
            // 
            this.btnIlan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIlan.Location = new System.Drawing.Point(283, 329);
            this.btnIlan.Name = "btnIlan";
            this.btnIlan.Size = new System.Drawing.Size(110, 28);
            this.btnIlan.TabIndex = 6;
            this.btnIlan.Text = "İLAN VER ";
            this.btnIlan.UseVisualStyleBackColor = false;
            this.btnIlan.Click += new System.EventHandler(this.btnIlan_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(158, 249);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(64, 17);
            this.lblComment.TabIndex = 7;
            this.lblComment.Text = "Açıklama";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(158, 205);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(71, 17);
            this.lblBitis.TabIndex = 8;
            this.lblBitis.Text = "Bitiş Tarihi";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(155, 162);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(102, 17);
            this.lblBaslangic.TabIndex = 9;
            this.lblBaslangic.Text = "Başlangıç Tarihi";
            // 
            // lblModelSec
            // 
            this.lblModelSec.AutoSize = true;
            this.lblModelSec.Location = new System.Drawing.Point(155, 123);
            this.lblModelSec.Name = "lblModelSec";
            this.lblModelSec.Size = new System.Drawing.Size(71, 17);
            this.lblModelSec.TabIndex = 10;
            this.lblModelSec.Text = "Model Seç";
            // 
            // lblArabaSec
            // 
            this.lblArabaSec.AutoSize = true;
            this.lblArabaSec.Location = new System.Drawing.Point(155, 76);
            this.lblArabaSec.Name = "lblArabaSec";
            this.lblArabaSec.Size = new System.Drawing.Size(71, 17);
            this.lblArabaSec.TabIndex = 11;
            this.lblArabaSec.Text = "Araba Seç";
            // 
            // lblUserSec
            // 
            this.lblUserSec.AutoSize = true;
            this.lblUserSec.Location = new System.Drawing.Point(155, 32);
            this.lblUserSec.Name = "lblUserSec";
            this.lblUserSec.Size = new System.Drawing.Size(85, 17);
            this.lblUserSec.TabIndex = 12;
            this.lblUserSec.Text = "Kullanıcı Seç";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(288, 246);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(200, 25);
            this.txtComment.TabIndex = 5;
            // 
            // cmbModels
            // 
            this.cmbModels.FormattingEnabled = true;
            this.cmbModels.Location = new System.Drawing.Point(288, 120);
            this.cmbModels.Name = "cmbModels";
            this.cmbModels.Size = new System.Drawing.Size(200, 25);
            this.cmbModels.TabIndex = 2;
            this.cmbModels.Text = "Seçiniz...";
            // 
            // cmbArac
            // 
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(288, 73);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(200, 25);
            this.cmbArac.TabIndex = 1;
            this.cmbArac.Text = "Seçiniz...";
            this.cmbArac.SelectedIndexChanged += new System.EventHandler(this.cmbArac_SelectedIndexChanged);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(288, 29);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(200, 25);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.Text = "Seçiniz...";
            // 
            // grpİlan
            // 
            this.grpİlan.Controls.Add(this.dgwIlan);
            this.grpİlan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpİlan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpİlan.Location = new System.Drawing.Point(0, 384);
            this.grpİlan.Name = "grpİlan";
            this.grpİlan.Size = new System.Drawing.Size(800, 202);
            this.grpİlan.TabIndex = 4;
            this.grpİlan.TabStop = false;
            this.grpİlan.Text = "İlanlar";
            // 
            // dgwIlan
            // 
            this.dgwIlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwIlan.Location = new System.Drawing.Point(3, 21);
            this.dgwIlan.Name = "dgwIlan";
            this.dgwIlan.Size = new System.Drawing.Size(794, 178);
            this.dgwIlan.TabIndex = 0;
            this.dgwIlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIlan_CellContentClick);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(288, 162);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 25);
            this.dtpBaslangic.TabIndex = 13;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(288, 205);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 25);
            this.dtpBitis.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(12, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 40);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // IlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.grpİlan);
            this.Controls.Add(this.grpForm);
            this.Name = "IlanForm";
            this.Text = "Ilan";
            this.Load += new System.EventHandler(this.IlanForm_Load);
            this.grpForm.ResumeLayout(false);
            this.grpForm.PerformLayout();
            this.grpİlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblModelSec;
        private System.Windows.Forms.Label lblArabaSec;
        private System.Windows.Forms.Label lblUserSec;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbModels;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.GroupBox grpİlan;
        private System.Windows.Forms.DataGridView dgwIlan;
        private System.Windows.Forms.Button btnIlan;
        private System.Windows.Forms.CheckBox chkIsDeleted;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Button btnBack;
    }
}