namespace OOP1
{
	partial class OOP1
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
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Sıralı = new System.Windows.Forms.ListBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaksimum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMin.Location = new System.Drawing.Point(359, 9);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 22);
            this.txtMin.TabIndex = 0;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMax.Location = new System.Drawing.Point(359, 58);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 22);
            this.txtMax.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(327, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Sıralı
            // 
            this.Sıralı.Font = new System.Drawing.Font("Minion Pro Med", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sıralı.FormattingEnabled = true;
            this.Sıralı.ItemHeight = 18;
            this.Sıralı.Location = new System.Drawing.Point(117, 164);
            this.Sıralı.Name = "Sıralı";
            this.Sıralı.Size = new System.Drawing.Size(551, 274);
            this.Sıralı.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConvert.Location = new System.Drawing.Point(417, 117);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Dönüştür";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinimum.Location = new System.Drawing.Point(284, 16);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(38, 15);
            this.lblMinimum.TabIndex = 5;
            this.lblMinimum.Text = "Min. :\r\n";
            // 
            // lblMaksimum
            // 
            this.lblMaksimum.AutoSize = true;
            this.lblMaksimum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaksimum.Location = new System.Drawing.Point(284, 61);
            this.lblMaksimum.Name = "lblMaksimum";
            this.lblMaksimum.Size = new System.Drawing.Size(43, 15);
            this.lblMaksimum.TabIndex = 6;
            this.lblMaksimum.Text = "Maks :";
            // 
            // OOP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaksimum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.Sıralı);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Name = "OOP1";
            this.Text = "Minmax Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMin;
		private System.Windows.Forms.TextBox txtMax;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ListBox Sıralı;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Label lblMinimum;
		private System.Windows.Forms.Label lblMaksimum;
	}
}

