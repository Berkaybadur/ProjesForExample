namespace _PresentationLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.gbCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwCustomer.Location = new System.Drawing.Point(0, 262);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.Size = new System.Drawing.Size(698, 188);
            this.dgwCustomer.TabIndex = 1;
            this.dgwCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwCustomer_CellClick);
            this.dgwCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomer_CellContentClick);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.BtnUpdate);
            this.gbCustomer.Controls.Add(this.BtnDelete);
            this.gbCustomer.Controls.Add(this.BtnAdd);
            this.gbCustomer.Controls.Add(this.lblPhoneNumber);
            this.gbCustomer.Controls.Add(this.txtPhoneNumber);
            this.gbCustomer.Controls.Add(this.lblIdentityNumber);
            this.gbCustomer.Controls.Add(this.txtIdentityNumber);
            this.gbCustomer.Controls.Add(this.lblEmail);
            this.gbCustomer.Controls.Add(this.txtEMail);
            this.gbCustomer.Controls.Add(this.lblCustomerLastName);
            this.gbCustomer.Controls.Add(this.txtCustomerLastName);
            this.gbCustomer.Controls.Add(this.lblCustomerName);
            this.gbCustomer.Controls.Add(this.txtCustomerFirstName);
            this.gbCustomer.Controls.Add(this.lblCustomerId);
            this.gbCustomer.Controls.Add(this.txtCustomerId);
            this.gbCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(563, 215);
            this.gbCustomer.TabIndex = 5;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Müşteri Bilgileri";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.Location = new System.Drawing.Point(328, 160);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(121, 40);
            this.BtnUpdate.TabIndex = 54;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(215, 160);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(91, 40);
            this.BtnDelete.TabIndex = 55;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(94, 160);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 40);
            this.BtnAdd.TabIndex = 56;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(271, 116);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(140, 20);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Telefon Numarası :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(442, 113);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 26);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(271, 80);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(148, 20);
            this.lblIdentityNumber.TabIndex = 9;
            this.lblIdentityNumber.Text = "TC Kimlik Numarası :";
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityNumber.Location = new System.Drawing.Point(442, 77);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(100, 26);
            this.txtIdentityNumber.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(271, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-Mail :";
            // 
            // txtEMail
            // 
            this.txtEMail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMail.Location = new System.Drawing.Point(442, 30);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(100, 26);
            this.txtEMail.TabIndex = 6;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLastName.Location = new System.Drawing.Point(22, 119);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(122, 20);
            this.lblCustomerLastName.TabIndex = 5;
            this.lblCustomerLastName.Text = "Müşteri Soyadı :";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLastName.Location = new System.Drawing.Point(147, 116);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(100, 26);
            this.txtCustomerLastName.TabIndex = 4;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(22, 71);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(98, 20);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Müşteri Adı :";
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFirstName.Location = new System.Drawing.Point(147, 71);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(100, 26);
            this.txtCustomerFirstName.TabIndex = 2;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(22, 38);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(89, 20);
            this.lblCustomerId.TabIndex = 1;
            this.lblCustomerId.Text = "Müşteri Id :";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(147, 30);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 26);
            this.txtCustomerId.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.dgwCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgwCustomer;
		private System.Windows.Forms.GroupBox gbCustomer;
		private System.Windows.Forms.Label lblPhoneNumber;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Label lblIdentityNumber;
		private System.Windows.Forms.TextBox txtIdentityNumber;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtEMail;
		private System.Windows.Forms.Label lblCustomerLastName;
		private System.Windows.Forms.TextBox txtCustomerLastName;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.TextBox txtCustomerFirstName;
		private System.Windows.Forms.Label lblCustomerId;
		private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
    }
}

