using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class AddLink : Form
    {
        private string _userName;
        private string _connectionString;

        public AddLink()
        {
            InitializeComponent();
        }

        public AddLink(string userName, string connectionString)
        {
            InitializeComponent();
            this._userName = userName;
            this._connectionString = connectionString;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
