using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities.Models;
using Entities.Repository;
    

namespace Register
{
    public partial class RegisterForm : Form
    {

        RegisterRepository _repo { get; set; }

        public RegisterForm()
        {

            _repo = new RegisterRepository();
            var result = _repo.SelectAllRegister();


            InitializeComponent();

         

        }
    }
}
