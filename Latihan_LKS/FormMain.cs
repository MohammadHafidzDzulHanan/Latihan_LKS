using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_LKS
{
    public partial class FormMain : Form
    {
        string name;
        public FormMain(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {name}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void btnMT_Click(object sender, EventArgs e)
        {
            new FormMasterTeacher().Show();
            Hide();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            new FormMasterStudent().Show();
            Hide();
        }
    }
}
