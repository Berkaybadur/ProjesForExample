using BusinessLayer;
using DataLayer;
using System;

namespace PresentationLayer
{
    partial class urunler
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
            this.Ürünİşlemleri = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpbxUrun = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ürünİşlemleri.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpbxUrun.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // Ürünİşlemleri
            // 
            this.Ürünİşlemleri.Controls.Add(this.tabPage1);
            this.Ürünİşlemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ürünİşlemleri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ürünİşlemleri.Location = new System.Drawing.Point(0, 0);
            this.Ürünİşlemleri.Multiline = true;
            this.Ürünİşlemleri.Name = "Ürünİşlemleri";
            this.Ürünİşlemleri.SelectedIndex = 0;
            this.Ürünİşlemleri.Size = new System.Drawing.Size(582, 464);
            this.Ürünİşlemleri.TabIndex = 1;
            this.Ürünİşlemleri.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpbxUrun);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpbxUrun
            // 
            this.grpbxUrun.Controls.Add(this.btnUpdate);
            this.grpbxUrun.Controls.Add(this.btnDelete);
            this.grpbxUrun.Controls.Add(this.btnCreate);
            this.grpbxUrun.Controls.Add(this.cmbCategory);
            this.grpbxUrun.Controls.Add(this.cmbSupplier);
            this.grpbxUrun.Controls.Add(this.txtbxPrice);
            this.grpbxUrun.Controls.Add(this.txtStock);
            this.grpbxUrun.Controls.Add(this.txtproductname);
            this.grpbxUrun.Controls.Add(this.txtproductid);
            this.grpbxUrun.Controls.Add(this.label6);
            this.grpbxUrun.Controls.Add(this.label5);
            this.grpbxUrun.Controls.Add(this.label4);
            this.grpbxUrun.Controls.Add(this.label3);
            this.grpbxUrun.Controls.Add(this.label2);
            this.grpbxUrun.Controls.Add(this.label1);
            this.grpbxUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbxUrun.Location = new System.Drawing.Point(3, 3);
            this.grpbxUrun.Name = "grpbxUrun";
            this.grpbxUrun.Size = new System.Drawing.Size(568, 211);
            this.grpbxUrun.TabIndex = 10;
            this.grpbxUrun.TabStop = false;
            this.grpbxUrun.Text = "Form";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(472, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(391, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreate.Location = new System.Drawing.Point(310, 142);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Ekle";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(120, 150);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbCategory.TabIndex = 16;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(120, 112);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(121, 23);
            this.cmbSupplier.TabIndex = 17;
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(407, 78);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(100, 22);
            this.txtbxPrice.TabIndex = 12;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(407, 38);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 22);
            this.txtStock.TabIndex = 13;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(121, 75);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(120, 22);
            this.txtproductname.TabIndex = 14;
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(121, 42);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(120, 22);
            this.txtproductid.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fiyat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stok :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tedarikçi Firma :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün No :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwProduct);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 213);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AllowUserToAddRows = false;
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunId,
            this.KategAd,
            this.urunAd,
            this.Miktar,
            this.Fiyat});
            this.dgwProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwProduct.Location = new System.Drawing.Point(3, 21);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.RowHeadersVisible = false;
            this.dgwProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProduct.Size = new System.Drawing.Size(562, 189);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellContentClick);
            // 
            // UrunId
            // 
            this.UrunId.DataPropertyName = "UrunId";
            this.UrunId.HeaderText = "ÜrünNo";
            this.UrunId.Name = "UrunId";
            this.UrunId.ReadOnly = true;
            // 
            // KategAd
            // 
            this.KategAd.HeaderText = "Kategori";
            this.KategAd.Name = "KategAd";
            this.KategAd.ReadOnly = true;
            // 
            // urunAd
            // 
            this.urunAd.DataPropertyName = "urunAd";
            this.urunAd.HeaderText = "Ürün Ad";
            this.urunAd.Name = "urunAd";
            this.urunAd.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Stok";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            // 
            // urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 464);
            this.Controls.Add(this.Ürünİşlemleri);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "urunler";
            this.Text = "urunlerForm";
            this.Load += new System.EventHandler(this.urunler_Load);
            this.Ürünİşlemleri.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpbxUrun.ResumeLayout(false);
            this.grpbxUrun.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        private void urunler_Load(object sender, EventArgs e)
        {
            cmbCategory.SetDataSource(cb.List(), "KategAd", "Id");
        }

        #endregion

        private System.Windows.Forms.TabControl Ürünİşlemleri;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpbxUrun;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}

