using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
	public partial class OOP1 : Form
	{
		public OOP1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			 
		}
		MinMax mmn = new MinMax();
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			int min = Convert.ToInt32(txtMin.Text);
			int max = Convert.ToInt32(txtMax.Text);
			mmn.ProduceValue(min, max);
			foreach (var item in mmn.Dataset)
			{
				Sıralı.Items.Add(item);
			}
		}

		private void BtnConvert_Click(object sender, EventArgs e)
		{
			if (Sıralı.Items.Count == 0)
			{
				MessageBox.Show("Değeri girin...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int i = 0;
				Sıralı.Items.Clear();
				mmn.Calculate();
				foreach (KeyValuePair<int, double> item in mmn.normalization)
				{
					Sıralı.Items.Add(string.Format("{0}.İlk Hali: {1}  - Normalize Olmuş Hali : {2}", i++, item.Key, item.Value));
				}
			}
		}
	}
}
