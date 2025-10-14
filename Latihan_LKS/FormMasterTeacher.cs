using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_LKS
{
    public partial class FormMasterTeacher : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int selectedId = -1;

        public FormMasterTeacher()
        {
            InitializeComponent();
        }

        private void cbogender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void showDataCbo()
        {
            var data = new List<string>();
            data.Add("Male");
            data.Add("Female");

            cbogender.DataSource = data;
        }

        void showData()
        {
            dgvData.Columns.Clear();

            var teacher = db.Teacher_Tables.Where(x => x.Name.StartsWith(tbSearch.Text)).Select(x => new
            {
                x.id,
                x.Name,
                x.Gender,
                x.Address,
                x.Phone,
                x.Subject,
                x.Password
            });

            dgvData.DataSource = teacher;
        }

        private void FormMasterTeacher_Load(object sender, EventArgs e)
        {
            showData();
            showDataCbo();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        void clearFields()
        {
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbSubject.Text = "";
            tbPassword.Text = "";
            cbogender.Text = "Male";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || tbSubject.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            var teacher = new Teacher_Table();
            teacher.Name = tbName.Text;
            teacher.Address = tbAddress.Text;
            teacher.Phone = tbPhone.Text;
            teacher.Subject = tbSubject.Text;
            teacher.Password = tbPassword.Text;
            teacher.Gender = cbogender.Text;

            db.Teacher_Tables.InsertOnSubmit(teacher);
            db.SubmitChanges();
            clearFields();
            showData();
            MessageBox.Show("Data successfully added");
            selectedId = -1;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedId = (int)dgvData.Rows[e.RowIndex].Cells["id"].Value;
                tbName.Text = dgvData.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbAddress.Text = dgvData.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                tbPhone.Text = dgvData.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                tbSubject.Text = dgvData.Rows[e.RowIndex].Cells["Subject"].Value.ToString();
                tbPassword.Text = dgvData.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                cbogender.Text = dgvData.Rows[e.RowIndex].Cells["gender"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(selectedId == -1)
            {
                MessageBox.Show("Please select a row to update");
                return;
            }

            if (tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || tbSubject.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            var teacher = db.Teacher_Tables.Where(x => x.id == selectedId).FirstOrDefault();
            teacher.Name = tbName.Text;
            teacher.Address = tbAddress.Text;
            teacher.Address = tbAddress.Text;
            teacher.Phone = tbPhone.Text;
            teacher.Subject = tbSubject.Text;
            teacher.Password = tbPassword.Text;
            teacher.Gender = cbogender.Text;

            db.SubmitChanges();
            clearFields();
            showData();
            MessageBox.Show("Data successfully updated");
            selectedId = -1;
        }

        private void button2_Click(object sender, EventArgs e)  //delete
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }

            var teacher = db.Teacher_Tables.Where(x => x.id == selectedId).FirstOrDefault();
            db.Teacher_Tables.DeleteOnSubmit(teacher);
            db.SubmitChanges();
            clearFields();
            showData();
            MessageBox.Show("Data successfully deleted");
            selectedId = -1;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }
    }
}
