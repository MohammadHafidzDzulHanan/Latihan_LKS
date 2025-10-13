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
    public partial class Form1 : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbName.Text = "Masukkan Nama Anda";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new DataBaseDataContext();

            var user = db.Teacher_Tables.Where(x => x.Name == tbName.Text && x.Password == tbPassword.Text).FirstOrDefault();

            if (user != null)
            {
                Helper.id = user.id;
                Helper.password = user.Password;

                new FormMain(user.Name).Show();
            }
        }
    }
}
