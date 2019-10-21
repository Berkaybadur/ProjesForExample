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
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
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
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(25, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(356, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(190, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 45);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblPhoneNumber);
            this.gbCustomer.Controls.Add(this.btnUpdate);
            this.gbCustomer.Controls.Add(this.txtPhoneNumber);
            this.gbCustomer.Controls.Add(this.btnDelete);
            this.gbCustomer.Controls.Add(this.lblIdentityNumber);
            this.gbCustomer.Controls.Add(this.btnAdd);
            this.gbCustomer.Controls.Add(this.txtIdentityNumber);
            this.gbCustomer.Controls.Add(this.lblEmail);
            this.gbCustomer.Controls.Add(this.txtEMail);
            this.gbCustomer.Controls.Add(this.lblCustomerLastName);
            this.gbCustomer.Controls.Add(this.txtCustomerLastName);
            this.gbCustomer.Controls.Add(this.lblCustomerName);
            this.gbCustomer.Controls.Add(this.txtCustomerFirstName);
            this.gbCustomer.Controls.Add(this.lblCustomerId);
            this.gbCustomer.Controls.Add(this.txtCustomerId);
            this.gbCustomer.Font = new System.Drawing.Font("Arial", 12F);
            this.gbCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(563, 215);
            this.gbCustomer.TabIndex = 5;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Müşteri";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(271, 116);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(126, 17);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Telefon Numarası :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(442, 113);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(271, 80);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(138, 17);
            this.lblIdentityNumber.TabIndex = 9;
            this.lblIdentityNumber.Text = "TC Kimlik Numarası :";
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityNumber.Location = new System.Drawing.Point(442, 77);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(100, 23);
            this.txtIdentityNumber.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(271, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-Mail :";
            // 
            // txtEMail
            // 
            this.txtEMail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMail.Location = new System.Drawing.Point(442, 30);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(100, 23);
            this.txtEMail.TabIndex = 6;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLastName.Location = new System.Drawing.Point(22, 119);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(106, 17);
            this.lblCustomerLastName.TabIndex = 5;
            this.lblCustomerLastName.Text = "Müşteri Soyadı :";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLastName.Location = new System.Drawing.Point(147, 116);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerLastName.TabIndex = 4;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(44, 74);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 17);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Müşteri Adı :";
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFirstName.Location = new System.Drawing.Point(147, 71);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerFirstName.TabIndex = 2;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(44, 30);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(68, 17);
            this.lblCustomerId.TabIndex = 1;
            this.lblCustomerId.Text = "Müşteri Id";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(147, 30);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 23);
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
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
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
	}
}

