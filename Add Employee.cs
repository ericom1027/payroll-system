using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
            fillDGV();
            txtid.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmployee.Clear();
            txtPosition.Clear();
            txtRate.Clear();
            txtid.Clear();
            btnDelete.Visible = false;
        }

           private void fillDGV()
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;
           
            comm.CommandText = "Select * From Employee";
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EmpDGV.DataSource = dt;

            //EmpDGV.Columns["Employee_Name"].HeaderText = "Employee Name";
            //this.EmpDGV.Columns["id"].Visible = false;
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                P_Connection NewConnection = new P_Connection();
                NewConnection.Connection_P();

                SqlCommand comm = new SqlCommand();
                comm.Connection = P_Connection.conn;

                DialogResult DR = MessageBox.Show("Are you sure you want to delete this Employee " + txtEmployee.Text + "?",
               "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    comm.CommandText = "Delete From Employee Where id=@id";
                    comm.Parameters.AddWithValue("@id", int.Parse(txtid.Text));

                    comm.ExecuteNonQuery();

                    MessageBox.Show("Data Delete Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillDGV();
                    txtclear();
                }

            }
            catch
            {

            }
        }
       private void EmpDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = EmpDGV.SelectedCells[0].Value.ToString();
            txtEmployee.Text = EmpDGV.SelectedCells[1].Value.ToString();
            txtPosition.Text = EmpDGV.SelectedCells[2].Value.ToString();
            txtRate.Text = EmpDGV.SelectedCells[3].Value.ToString();
            btnDelete.Visible = true;
        }

        public void txtclear()
        {
            txtEmployee.Clear();
            txtPosition.Clear();
            txtRate.Clear();
            txtid.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployee.Text == string.Empty)
            {
                txtEmployee.Focus();
                MessageBox.Show("Employee Name field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (txtPosition.Text == string.Empty)
            {
                txtPosition.Focus();
                MessageBox.Show("Position field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtRate.Text == string.Empty)
            {
                txtRate.Focus();
                MessageBox.Show("Rate field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            SqlDataAdapter da = new SqlDataAdapter("Select Employee_Name from Employee where Employee_Name ='" + txtEmployee.Text + "'", P_Connection.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Employee Name is Already Exist", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtclear();
            }
            else
            {
                comm.CommandText = "Insert into Employee VALUES (@Employee_Name,@Position,@Rate)";
                comm.Parameters.AddWithValue("@Employee_Name", txtEmployee.Text);
                comm.Parameters.AddWithValue("@Position", (txtPosition.Text));
                comm.Parameters.AddWithValue("@Rate", (txtRate.Text));
            
                comm.ExecuteNonQuery();

                MessageBox.Show("Data Save Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillDGV();
                txtclear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();
            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            comm.CommandText = "Update Employee set Employee_Name = @Employee_Name, Position = @Position, Rate = @Rate WHERE id = @id";
            comm.Parameters.AddWithValue("@id", txtid.Text);
            comm.Parameters.AddWithValue("@Employee_Name", txtEmployee.Text);
            comm.Parameters.AddWithValue("@Position", (txtPosition.Text));
            comm.Parameters.AddWithValue("@Rate", (txtRate.Text));
           

            comm.ExecuteNonQuery();

            MessageBox.Show("Data Updated Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillDGV();
            txtclear();
        }

        private void EmpDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 3)
            {
                e.CellStyle.Format = "N2";
            }
        }

        
    }

  }
