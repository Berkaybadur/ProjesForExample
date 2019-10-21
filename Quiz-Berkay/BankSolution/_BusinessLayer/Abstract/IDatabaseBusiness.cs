using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BusinessLayer.Abstract
{
	public interface IDatabaseBusiness
	{
		void List(DataGridView dgw);
		void Create();
		void Update();
		void Delete();
	}
}
