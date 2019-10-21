namespace Deneme
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.grpRegisterForm = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.rchAdress = new System.Windows.Forms.RichTextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.chkNotRegistered = new System.Windows.Forms.CheckBox();
            this.grpKayitEkran = new System.Windows.Forms.GroupBox();
            this.dgwRegister = new System.Windows.Forms.DataGridView();
            this.btnGoLogin = new System.Windows.Forms.Button();
            this.grpRegisterForm.SuspendLayout();
            this.grpKayitEkran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRegisterForm
            // 
            this.grpRegisterForm.BackColor = System.Drawing.Color.Silver;
            this.grpRegisterForm.Controls.Add(this.btnBack);
            this.grpRegisterForm.Controls.Add(this.btnDelete);
            this.grpRegisterForm.Controls.Add(this.btnRegister);
            this.grpRegisterForm.Controls.Add(this.btnClean);
            this.grpRegisterForm.Controls.Add(this.rchAdress);
            this.grpRegisterForm.Controls.Add(this.lblAdress);
            this.grpRegisterForm.Controls.Add(this.txtPhoneNumber);
            this.grpRegisterForm.Controls.Add(this.lblPhoneNumber);
            this.grpRegisterForm.Controls.Add(this.txtSurName);
            this.grpRegisterForm.Controls.Add(this.txtName);
            this.grpRegisterForm.Controls.Add(this.txtPassword);
            this.grpRegisterForm.Controls.Add(this.txtUserName);
            this.grpRegisterForm.Controls.Add(this.lblSurName);
            this.grpRegisterForm.Controls.Add(this.lblName);
            this.grpRegisterForm.Controls.Add(this.lblPassword);
            this.grpRegisterForm.Controls.Add(this.lblUserName);
            this.grpRegisterForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpRegisterForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpRegisterForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpRegisterForm.Location = new System.Drawing.Point(0, 0);
            this.grpRegisterForm.Name = "grpRegisterForm";
            this.grpRegisterForm.Size = new System.Drawing.Size(369, 450);
            this.grpRegisterForm.TabIndex = 2;
            this.grpRegisterForm.TabStop = false;
            this.grpRegisterForm.Text = "Kayıt Formu";
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(12, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 42);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(234, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.Location = new System.Drawing.Point(126, 386);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 28);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "KAYDET";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(24, 386);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(96, 28);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "TEMİZLE";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // rchAdress
            // 
            this.rchAdress.Location = new System.Drawing.Point(150, 216);
            this.rchAdress.Name = "rchAdress";
            this.rchAdress.Size = new System.Drawing.Size(159, 102);
            this.rchAdress.TabIndex = 5;
            this.rchAdress.Text = "";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdress.Location = new System.Drawing.Point(20, 215);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(64, 21);
            this.lblAdress.TabIndex = 18;
            this.lblAdress.Text = "Adres :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 185);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(159, 26);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 187);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(75, 21);
            this.lblPhoneNumber.TabIndex = 16;
            this.lblPhoneNumber.Text = "Telefon :";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(150, 155);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(159, 26);
            this.txtSurName.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(159, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(150, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(159, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurName.Location = new System.Drawing.Point(20, 157);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(67, 21);
            this.lblSurName.TabIndex = 8;
            this.lblSurName.Text = "Soyad :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(20, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 21);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Ad :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(20, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 21);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Şifre :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(20, 70);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(120, 21);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Kullanıcı Adı :";
            // 
            // chkNotRegistered
            // 
            this.chkNotRegistered.AutoSize = true;
            this.chkNotRegistered.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkNotRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkNotRegistered.Location = new System.Drawing.Point(379, 389);
            this.chkNotRegistered.Name = "chkNotRegistered";
            this.chkNotRegistered.Size = new System.Drawing.Size(114, 24);
            this.chkNotRegistered.TabIndex = 10;
            this.chkNotRegistered.Text = "Silinmiş mi ?";
            this.chkNotRegistered.UseVisualStyleBackColor = false;
            this.chkNotRegistered.CheckedChanged += new System.EventHandler(this.chkNotRegistered_CheckedChanged);
            // 
            // grpKayitEkran
            // 
            this.grpKayitEkran.Controls.Add(this.dgwRegister);
            this.grpKayitEkran.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKayitEkran.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpKayitEkran.Location = new System.Drawing.Point(376, 8);
            this.grpKayitEkran.Name = "grpKayitEkran";
            this.grpKayitEkran.Size = new System.Drawing.Size(498, 351);
            this.grpKayitEkran.TabIndex = 11;
            this.grpKayitEkran.TabStop = false;
            this.grpKayitEkran.Text = "Kayıt Ekranı ";
            // 
            // dgwRegister
            // 
            this.dgwRegister.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRegister.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgwRegister.Location = new System.Drawing.Point(3, 25);
            this.dgwRegister.Name = "dgwRegister";
            this.dgwRegister.Size = new System.Drawing.Size(492, 323);
            this.dgwRegister.TabIndex = 0;
            this.dgwRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRegister_CellContentClick);
            // 
            // btnGoLogin
            // 
            this.btnGoLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGoLogin.Location = new System.Drawing.Point(743, 386);
            this.btnGoLogin.Name = "btnGoLogin";
            this.btnGoLogin.Size = new System.Drawing.Size(100, 28);
            this.btnGoLogin.TabIndex = 7;
            this.btnGoLogin.Text = "Giriş Yap";
            this.btnGoLogin.UseVisualStyleBackColor = false;
            this.btnGoLogin.Click += new System.EventHandler(this.btnGoLogin_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.chkNotRegistered);
            this.Controls.Add(this.grpKayitEkran);
            this.Controls.Add(this.btnGoLogin);
            this.Controls.Add(this.grpRegisterForm);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseClick);
            this.grpRegisterForm.ResumeLayout(false);
            this.grpRegisterForm.PerformLayout();
            this.grpKayitEkran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegisterForm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.RichTextBox rchAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox chkNotRegistered;
        private System.Windows.Forms.GroupBox grpKayitEkran;
        private System.Windows.Forms.DataGridView dgwRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGoLogin;
    }
}

