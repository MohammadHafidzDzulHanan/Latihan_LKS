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
    public partial class FormMasterStudent : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int selectedId = -1;

        public FormMasterStudent()
        {
            InitializeComponent();
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

            var student = db.Student_Tables.Where(x => x.Name.StartsWith(tbSearch.Text)).Select(x => new
            {
                x.id,
                x.Name,
                x.Class,
                x.Gender,
                x.Address,
                x.Phone
            });

            dgvData.DataSource = student;
        }

        private void FormMasterStudent_Load(object sender, EventArgs e)
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
            tbClass.Text = "";
            cbogender.Text = "Male";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || tbClass.Text == "")
            {
                Helper.msw("All fields must be filled");
                return;
            }

            var student = new Student_Table();
            student.Name = tbName.Text;
            student.Address = tbAddress.Text;
            student.Phone = tbPhone.Text;
            student.Class = tbClass.Text;
            student.Gender = cbogender.Text;

            db.Student_Tables.InsertOnSubmit(student);
            db.SubmitChanges();
            showData();
            clearFields();
            Helper.msi("Data successfully added");
            selectedId = -1;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = (int)dgvData.Rows[e.RowIndex].Cells["id"].Value;
                tbName.Text = dgvData.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbAddress.Text = dgvData.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                tbPhone.Text = dgvData.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                tbClass.Text = dgvData.Rows[e.RowIndex].Cells["Class"].Value.ToString();
                cbogender.Text = dgvData.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                Helper.msw("Please select a row to update");
                return;
            }

            var student = db.Student_Tables.Where(x => x.id == selectedId).FirstOrDefault();
            student.Name = tbName.Text;
            student.Address = tbAddress.Text;
            student.Phone = tbPhone.Text;
            student.Class = tbClass.Text;
            student.Gender = cbogender.Text;

            db.SubmitChanges();
            showData();
            clearFields();
            Helper.msi("Data successfully updated");
            selectedId = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                Helper.msw("Please select a row to delete");
                return;
            }

            var student = db.Student_Tables.Where(x => x.id == selectedId).FirstOrDefault();
            db.Student_Tables.DeleteOnSubmit(student);
            db.SubmitChanges();
            clearFields();
            showData();
            Helper.msi("Data successfully deleted");
            selectedId = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)  //Logout button
        {
            new FormMain(Helper.name).Show();
            Hide();
        }
    }
}
