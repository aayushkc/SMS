using SMS.Bll;
using SMS.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SMS.Utils;



namespace SMS
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                s.Name = txtName.Text;
                s.Address = txtAddress.Text;
                s.Course = cmbCourse.Text;
                s.Fee = Convert.ToInt32(txtFee.Text);
                StudentDao sd = new StudentDao();
                sd.SaveStudent(s);
                MessageBox.Show("Record Saved!", "SMS");
                LoadData();
                ClearData();

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "SMS");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                s.SID = Gc.sid;
                s.Name = txtName.Text;
                s.Address = txtAddress.Text;
                s.Course = cmbCourse.Text;
                s.Fee = Convert.ToInt32(txtFee.Text);
                StudentDao sd = new StudentDao();
                sd.UpdateStudent(s);
                MessageBox.Show("Record Updated!", "SMS");
                LoadData();
                ClearData();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS");
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete?", "SMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Student s = new Student();
                    StudentDao sd = new StudentDao();
                    sd.DeleteStudent(Gc.sid);
                    MessageBox.Show("Record Deleted!", "SMS");
                    LoadData();
                    ClearData();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS");
            }
        }

        private void LoadData()
        {
            try
            {
                StudentDao sd = new StudentDao();
                DataTable dt = sd.GetAllStudents();
                dataGridView1.DataSource = dt;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SMS");
            }
        }

        private void ClearData()
        {
            txtName.Text  = "";
            txtAddress.Text = "";
            cmbCourse.SelectedIndex = 0;
            txtFee.Text = "0";
            txtName.Focus();
        }
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbCourse.SelectedIndex = 0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            Gc.sid = Convert.ToInt32(dataGridView1.Rows[i].Cells["SID"].Value);
            txtName.Text = dataGridView1.Rows[i].Cells["Name"].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[i].Cells["Address"].Value.ToString();
            cmbCourse.Text = dataGridView1.Rows[i].Cells["Course"].Value.ToString();
            txtFee.Text = dataGridView1.Rows[i].Cells["Fee"].Value.ToString();

        }
    }
}
