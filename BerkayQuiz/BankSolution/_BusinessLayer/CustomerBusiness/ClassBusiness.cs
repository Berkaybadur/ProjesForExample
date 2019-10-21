
using _DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BusinessLayer.Concrete
{
	public class ClassBusiness
	{
		public DataGridView dgwCustomer;

		public void Operation(IDatabaseBusiness databaseBusiness,OperationType operationType)
		{
			switch (operationType)
			{
				case OperationType.Create:
					databaseBusiness.Create();
					break;
				case OperationType.Update:
					databaseBusiness.Update();
					break;
				case OperationType.Delete:
					databaseBusiness.Delete();
					break;
				case OperationType.List:
					databaseBusiness.List(dgwCustomer);
					break;
			}				
		}
		public enum OperationType
		{
			Create,
			Update,
			Delete,
			List
		}
	}
}
