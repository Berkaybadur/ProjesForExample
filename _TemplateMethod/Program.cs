using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseObject c = new Categories();
            c.Run();

            DatabaseObject p = new Products();
            p.Run();

        }
    }

    public abstract class DatabaseObject
    {

        protected string _connectionString;
        protected DataSet _dataSet;
        public virtual void Connect()
        {
            _connectionString = "";

        }

        public abstract void Select();
        public abstract void Process();
        public virtual void Disconnect()
        {
            _connectionString = "";
        }

        public void Run()
        {
            Select();
            Process();
            Disconnect();
        }
    }

    public class Categories : DatabaseObject
    {

        public override void Process()
        {
            throw new NotImplementedException();
        }

        public override void Select()
        {
            throw new NotImplementedException();
        }
    }

    public class Products : DatabaseObject
    {
        public override void Process()
        {
            throw new NotImplementedException();
        }

        public override void Select()
        {
            throw new NotImplementedException();
        }
    }
}
