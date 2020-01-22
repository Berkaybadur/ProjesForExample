namespace Airport.PresentationLayer
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pctrMail = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pctrPassword = new System.Windows.Forms.PictureBox();
            this.pctrUser = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pctrName = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(255, 354);
            this.txtMail.Name = "txtMail";
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMail.Size = new System.Drawing.Size(173, 19);
            this.txtMail.TabIndex = 50;
            this.txtMail.Text = "E Posta Giriniz..";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(254, 289);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPassword.Size = new System.Drawing.Size(157, 19);
            this.txtPassword.TabIndex = 49;
            this.txtPassword.Text = "Şifre Giriniz";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // pctrMail
            // 
            this.pctrMail.Image = ((System.Drawing.Image)(resources.GetObject("pctrMail.Image")));
            this.pctrMail.Location = new System.Drawing.Point(195, 337);
            this.pctrMail.Name = "pctrMail";
            this.pctrMail.Size = new System.Drawing.Size(343, 50);
            this.pctrMail.TabIndex = 51;
            this.pctrMail.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(252, 234);
            this.txtUser.Name = "txtUser";
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtUser.Size = new System.Drawing.Size(173, 19);
            this.txtUser.TabIndex = 48;
            this.txtUser.Text = "Kullanıcı Adı Giriniz...";
            // 
            // pctrPassword
            // 
            this.pctrPassword.Image = ((System.Drawing.Image)(resources.GetObject("pctrPassword.Image")));
            this.pctrPassword.Location = new System.Drawing.Point(195, 277);
            this.pctrPassword.Name = "pctrPassword";
            this.pctrPassword.Size = new System.Drawing.Size(343, 50);
            this.pctrPassword.TabIndex = 52;
            this.pctrPassword.TabStop = false;
            // 
            // pctrUser
            // 
            this.pctrUser.Image = ((System.Drawing.Image)(resources.GetObject("pctrUser.Image")));
            this.pctrUser.Location = new System.Drawing.Point(195, 218);
            this.pctrUser.Name = "pctrUser";
            this.pctrUser.Size = new System.Drawing.Size(343, 50);
            this.pctrUser.TabIndex = 53;
            this.pctrUser.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(252, 170);
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtName.Size = new System.Drawing.Size(173, 19);
            this.txtName.TabIndex = 47;
            this.txtName.Text = "Adınızı Giriniz..";
            // 
            // pctrName
            // 
            this.pctrName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctrName.Image = ((System.Drawing.Image)(resources.GetObject("pctrName.Image")));
            this.pctrName.Location = new System.Drawing.Point(197, 153);
            this.pctrName.Name = "pctrName";
            this.pctrName.Size = new System.Drawing.Size(343, 50);
            this.pctrName.TabIndex = 54;
            this.pctrName.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(716, 546);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pctrMail);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pctrPassword);
            this.Controls.Add(this.pctrUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pctrName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pctrMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pctrMail;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pctrPassword;
        private System.Windows.Forms.PictureBox pctrUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pctrName;
    }
}