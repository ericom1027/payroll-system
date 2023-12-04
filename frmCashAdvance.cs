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
    public partial class frmCashAdvance : Form
    {

        public frmCashAdvance()
        {
            InitializeComponent();
            cmbemployeeCA();
            filldgvCA();
            txtDisable();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbemployeeCA()
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            comm.CommandText = "Select  * from Employee";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            DataRow itemrow = table1.NewRow();
            itemrow[1] = "--Select Employee--";
            table1.Rows.InsertAt(itemrow, 0);

            cmbEmployee.DataSource = table1;
            cmbEmployee.DisplayMember = "Employee_Name";
            cmbEmployee.ValueMember = "id";
            cmbEmployee.SelectedIndex = 0;
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEnable();
        }


        private void txtLoanBal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total;

                if (txtLoanBal.Text == string.Empty)
                {
                    txtLoanBal.Text = "0";
                    txtLoanBal.Select(txtLoanBal.Text.Trim().Length, -1);
                }

                total = double.Parse(txtLoanBal.Text) - double.Parse(txtTotalDeduct.Text);
                txtPaidBal.Text = total.ToString("N2");
            }
            catch
            {

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtLoanAmount.Text == string.Empty || txtLoanAmount.Text == "0.00")
                {

                    txtLoanAmount.Focus();
                    MessageBox.Show("Loan Amount field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtDPS.Text == string.Empty || txtDPS.Text == "0.00")
                {
                    
                    txtDPS.Focus();
                    MessageBox.Show("Deduction per salary field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtdeductperSalary.Text == string.Empty || txtdeductperSalary.Text == "0.00")
                {

                    txtdeductperSalary.Focus();
                    MessageBox.Show("Deduction field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                P_Connection NewConnection = new P_Connection();
                NewConnection.Connection_P();

                SqlCommand comm = new SqlCommand();
                comm.Connection = P_Connection.conn;



                comm.CommandText = "Insert into E_CA VALUES (@empname,@dps,@D_deduct,@D_perSal,@A_deduct,@totdeduct,@Loan_Amount,@Loan_Bal,@tot_Paid)";
                comm.Parameters.AddWithValue("@empname", cmbEmployee.Text);
                comm.Parameters.AddWithValue("@dps", txtDPS.Text);
                comm.Parameters.AddWithValue("@D_deduct", DtpkIssue.Text);
                comm.Parameters.AddWithValue("@D_perSal", double.Parse(txtdeductperSalary.Text));
                comm.Parameters.AddWithValue("@A_deduct", double.Parse(txtdeduct.Text));
                comm.Parameters.AddWithValue("@totdeduct", double.Parse(txtTotalDeduct.Text));
                comm.Parameters.AddWithValue("@Loan_Amount", double.Parse(txtLoanAmount.Text));
                comm.Parameters.AddWithValue("@Loan_Bal", double.Parse(txtLoanBal.Text));
                comm.Parameters.AddWithValue("@tot_Paid", double.Parse(txtPaidBal.Text));


                comm.ExecuteNonQuery();

                MessageBox.Show("Data Save Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filldgvCA();
                txtClear();
            }
            catch
            {

            }
        }

        private void filldgvCA()
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            comm.CommandText = "Select * From E_CA";
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgGridCA.DataSource = dt;

        }

        private void dgGridCA_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtid.Text = dgGridCA.SelectedCells[0].Value.ToString();
            cmbEmployee.Text = dgGridCA.SelectedCells[1].Value.ToString();
            txtDPS.Text = dgGridCA.SelectedCells[2].Value.ToString();
            DtpkIssue.Text = dgGridCA.SelectedCells[3].Value.ToString();
            txtdeductperSalary.Text = dgGridCA.SelectedCells[4].Value.ToString();
            txtdeduct.Text = dgGridCA.SelectedCells[5].Value.ToString();
            txtTotalDeduct.Text = dgGridCA.SelectedCells[6].Value.ToString();
            txtLoanAmount.Text = dgGridCA.SelectedCells[7].Value.ToString();
            txtLoanBal.Text = dgGridCA.SelectedCells[8].Value.ToString();
            txtPaidBal.Text = dgGridCA.SelectedCells[9].Value.ToString();
            txtEnable();
           
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnPrint.Enabled = true;
            btnDelete.Visible = true;
        }

        private void frmCashAdvance_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            txtdeduct.Visible = false;
            txtdeduct.Text = "0";
            btnUpdate.Visible = false;
            btnPrint.Enabled = false;
            btnDelete.Visible = false;
        }

        public void txtDisable()
        {
            txtDPS.Enabled = false;
            txtLoanAmount.Enabled = false;
            DtpkIssue.Enabled = false;
            txtdeductperSalary.Enabled = false;
            txtdeduct.Enabled = false;
            txtLoanBal.Enabled = false;
            txtPaidBal.Enabled = false;
            txtTotalDeduct.Enabled = false;
        }


        public void txtEnable()
        {
            txtDPS.Enabled = true;
            txtLoanAmount.Enabled = true;
            DtpkIssue.Enabled = true;
            txtdeductperSalary.Enabled = true;
            txtdeduct.Enabled = true;
            txtLoanBal.Enabled = true;
            txtPaidBal.Enabled = true;
            txtTotalDeduct.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();
            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            comm.CommandText = "Update E_CA set empname = @empname, dps = @dps, D_deduct = @D_deduct, D_perSal = @D_perSal, A_deduct = @A_deduct, totdeduct = @totdeduct, Loan_Amount = @Loan_Amount, Loan_Bal = @Loan_Bal, tot_Paid = @tot_Paid WHERE id = @id";
            comm.Parameters.AddWithValue("@id", txtid.Text);
            comm.Parameters.AddWithValue("@empname", cmbEmployee.Text);
            comm.Parameters.AddWithValue("@dps", txtDPS.Text);
            comm.Parameters.AddWithValue("@D_deduct", DtpkIssue.Text);
            comm.Parameters.AddWithValue("@D_perSal", double.Parse(txtdeductperSalary.Text));
            comm.Parameters.AddWithValue("@A_deduct", double.Parse(txtdeduct.Text));
            comm.Parameters.AddWithValue("@totdeduct", double.Parse(txtTotalDeduct.Text));
            comm.Parameters.AddWithValue("@Loan_Amount", double.Parse(txtLoanAmount.Text));
            comm.Parameters.AddWithValue("@Loan_Bal", double.Parse(txtLoanBal.Text));
            comm.Parameters.AddWithValue("@tot_Paid", double.Parse(txtPaidBal.Text));


            comm.ExecuteNonQuery();

            MessageBox.Show("Data Updated Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filldgvCA();
            txtClear();
            btnSave.Visible = true;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }


        private void txtClear()
        {
            cmbEmployee.Text = string.Empty;
            txtDPS.Text = "0.00";
            txtLoanAmount.Text = "0.00";
            txtLoanBal.Text = "0.00";
            DtpkIssue.Text = string.Empty;
            txtdeductperSalary.Text = "0.00";
            txtdeduct.Text = "0.00";
            txtTotalDeduct.Text ="0.00";
            txtLoanBal.Text = "0.00";
            txtPaidBal.Text = "0.00";
        }

        private void txtdeductperSalary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double totaldeduction, totalLoanBal;

                if (txtdeductperSalary.Text == string.Empty)
                {
                    txtdeductperSalary.Text = "0";
                    txtdeductperSalary.Select(txtdeductperSalary.Text.Trim().Length, -1);
                }

                totaldeduction = double.Parse(txtdeductperSalary.Text) + double.Parse(txtdeduct.Text);
                txtTotalDeduct.Text = totaldeduction.ToString("N2");

                totalLoanBal = double.Parse(txtLoanAmount.Text) - double.Parse(txtTotalDeduct.Text);
                txtLoanBal.Text = totalLoanBal.ToString("N2");

                // totPaidBal = double.Parse(txtdeductperSalary.Text) + double.Parse(txtdeduct.Text);
                txtPaidBal.Text = totaldeduction.ToString("N2");
            }
            catch
            {

            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtClear();
            btnSave.Visible = true;
            btnPrint.Enabled = false;
            btnDelete.Visible = false;
         
        }

        public void printReportCA()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("empname", typeof(string));
            dt.Columns.Add("dps", typeof(double));
            dt.Columns.Add("D_Deduct", typeof(string));
            dt.Columns.Add("D_perSal", typeof(double));
            dt.Columns.Add("A_deduct", typeof(double));
            dt.Columns.Add("totdeduct", typeof(double));
            dt.Columns.Add("Loan_Amount", typeof(double));
            dt.Columns.Add("Loan_Bal", typeof(double));
            dt.Columns.Add("tot_Paid", typeof(double));



            foreach (DataGridViewRow dgv in dgGridCA.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("CA.xml");

            frmCAreports frmCA = new frmCAreports();
            CrystalReport2 cr = new CrystalReport2();
            cr.SetDataSource(ds);
            frmCA.crystalReportViewer2.ReportSource = cr;
            frmCA.crystalReportViewer2.Refresh();
            frmCA.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printReportCA();
            txtClear();
            btnPrint.Enabled = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                P_Connection NewConnection = new P_Connection();
                NewConnection.Connection_P();

                SqlCommand comm = new SqlCommand();
                comm.Connection = P_Connection.conn;

                DialogResult DR = MessageBox.Show("Are you sure you want to delete " + cmbEmployee.Text + "?",
               "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    comm.CommandText = "Delete From E_CA Where id=@id";
                    comm.Parameters.AddWithValue("@id", int.Parse(txtid.Text));

                    comm.ExecuteNonQuery();

                    MessageBox.Show("Data Delete Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldgvCA();
                    txtClear();
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                    btnSave.Visible = true;
                }

            }
            catch
            {

            }
        }
    }

}



