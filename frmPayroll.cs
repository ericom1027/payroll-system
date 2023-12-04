using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class frmPayroll : Form
    {
        
       public frmPayroll()
        {
            InitializeComponent();
            cmbload();
            fillPayrollDGV();
            labelDate.Text = DateTime.Now.ToShortDateString();
            txtReadOnly();
            btnEdit.Visible = false;
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cmbload()
        {

            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            comm.CommandText = "Select * From Employee";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            DataRow itemrow = table1.NewRow();
            itemrow[1] = "--Select Employee--";
            table1.Rows.InsertAt(itemrow, 0);
          
            cmbEmp.DataSource = table1;
            cmbEmp.DisplayMember = "Employee_Name";
            cmbEmp.ValueMember = "id";
            cmbEmp.SelectedIndex = 0;


            
        }
        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();

            comm = new SqlCommand("Select * From Employee WHERE Employee_Name=@Employee_Name", P_Connection.conn);
            comm.Parameters.AddWithValue("@Employee_Name", cmbEmp.Text);

            SqlDataReader dr;
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                string position = dr["Position"].ToString();
                string rate = dr["Rate"].ToString();
                string id = dr["id"].ToString();
                txtPosition.Text = position;
                txtRate.Text = rate;
                labelID.Text = id;
            }
            


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void txtClear()
        {
            txtPosition.Text = "";
            cmbEmp.Text = string.Empty;
            txtRate.Text = "0";
            txtRW.Text = "0";
            txtNoDays.Text = "0";
            txtOThr.Text = "0";
            txtGrossPay.Text = "0";
            txtManGov.Text = "0";
            txtCA.Text = "0";
            txttotaldeduct.Text = "0";
            txtOT.Text = "0";
            labelID.Text = "";
            txtNetPay.Text = "0";
            btnEdit.Visible = false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {


            if (txtNoDays.Text == string.Empty)
            {
                txtNoDays.Focus();
                MessageBox.Show("Number of Days field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            comm.CommandText = "Insert into emp_payroll VALUES (@empid,@position,@PDate,@emp_name,@no_of_days,@rate,@rateW,@OT_hr,@Reg_OT,@gross_pay,@gov_mandated,@CA,@totaldeduct,@total_netpay)";
            comm.Parameters.AddWithValue("@empid", labelID.Text);
            comm.Parameters.AddWithValue("@position", txtPosition.Text);
            comm.Parameters.AddWithValue("@PDate", labelDate.Text);
            comm.Parameters.AddWithValue("@emp_name", cmbEmp.Text);
            comm.Parameters.AddWithValue("@no_of_days", txtNoDays.Text);
            comm.Parameters.AddWithValue("@rate", txtRate.Text);
            comm.Parameters.AddWithValue("@rateW", txtRW.Text);
            comm.Parameters.AddWithValue("@OT_hr", txtOThr.Text);
            comm.Parameters.AddWithValue("@Reg_OT", txtOT.Text);
            comm.Parameters.AddWithValue("@gross_pay", txtGrossPay.Text);
            comm.Parameters.AddWithValue("@gov_mandated", txtManGov.Text);
            comm.Parameters.AddWithValue("@CA", txtCA.Text);
            comm.Parameters.AddWithValue("@totaldeduct", txttotaldeduct.Text);
            comm.Parameters.AddWithValue("@total_netpay", txtNetPay.Text);
            comm.ExecuteNonQuery();

            MessageBox.Show("Data Save Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillPayrollDGV();
            txtClear();

        }


        private void fillPayrollDGV()
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            comm.CommandText = "Select * From emp_payroll ORDER BY emp_name ASC";
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVpayroll.DataSource = dt;

          
        }

        private void DGVpayroll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 || e.ColumnIndex == 12)
            {
                e.CellStyle.Format = "N2";
            }
        }

        public void CalculateP()
        {
            try
            {
                double ca, spp, total_deduction, gross, total_net;

                ca = double.Parse(txtCA.Text);
                spp = double.Parse(txtManGov.Text);
                gross = double.Parse(txtRW.Text);

                total_deduction = ca + spp;
                txttotaldeduct.Text = total_deduction.ToString("N2");

                total_net = gross - total_deduction;
                txtNetPay.Text = total_net.ToString("N2");
            }
            catch
            {

            }
        }


        //No of Work Days
        private void txtNoDays_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double totalGross;
                if (txtNoDays.Text == string.Empty)
                {
                    txtNoDays.Text = "0";

                }
                else
                {
                    txtNoDays.Select(txtNoDays.Text.Length, -1);
                }

                totalGross = double.Parse(txtNoDays.Text) * double.Parse(txtRate.Text);

                txtRW.Text = totalGross.ToString("N2");
            }
            catch
            {

            }
        }

        private void txtCA_TextChanged(object sender, EventArgs e)
        {
            if (txtCA.Text == "")
            {
                txtCA.Text = "0";
                txtCA.Select(txtCA.Text.Trim().Length, -1);
            }
            CalculateP();
        }

        private void txtOThr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total, total_OT, grossincome, neticome, ot, rateWage;


                if (txtOThr.Text == "" || txtOThr.Text == "0")
                {
                    txtOT.Text = "0";
                }
                else
                {
                    total = Double.Parse(txtRate.Text) / 8;
                    total_OT = total * Double.Parse(txtOThr.Text);
                    txtOT.Text = total_OT.ToString("N2");

                }

                ot = double.Parse(txtOT.Text);
                rateWage = double.Parse(txtRW.Text);

                grossincome = rateWage + ot;
                txtGrossPay.Text = grossincome.ToString("N2");

                neticome = grossincome - double.Parse(txttotaldeduct.Text);
                txtNetPay.Text = neticome.ToString("N2");

            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        public void txtReadOnly()
        {
            txtPosition.ReadOnly = true;
            txtRW.ReadOnly = true;
            txtOT.ReadOnly = true;
            txtGrossPay.ReadOnly = true;
            txttotaldeduct.ReadOnly = true;
            txtNetPay.ReadOnly = true;
            txtid.Visible = false;
        }

        private void txtNoDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
               // txtNoDays.MaxLength = 2;
            }
        }

        private void txtOThr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
                
            }
            txtOThr.MaxLength = 2;
        }

        #region Textbox KeyPress
        private void txtManGov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtManGov.MaxLength = 3;
        }
        #endregion

        #region Textbox KeyPress
        private void txtCA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Update Payroll
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;
            comm.CommandText = "Update emp_payroll set emp_name = @emp_name, empid = @empid, PDate = @PDate, no_of_days = @no_of_days, position = @position, rate = @rate, rateW = @rateW, OT_hr = @OT_hr, Reg_OT = @Reg_OT, gross_pay = @gross_pay, gov_mandated = @gov_mandated, CA = @CA, totaldeduct = @totaldeduct, total_netpay = @total_netpay WHERE id = @id";
            comm.Parameters.AddWithValue("@id", txtid.Text);
            comm.Parameters.AddWithValue("@empid", labelID.Text);
            comm.Parameters.AddWithValue("@emp_name", cmbEmp.Text);
            comm.Parameters.AddWithValue("@no_of_days", txtNoDays.Text);
            comm.Parameters.AddWithValue("@PDate", labelDate.Text);
            comm.Parameters.AddWithValue("@position", txtPosition.Text);
            comm.Parameters.AddWithValue("@rate", txtRate.Text);
            comm.Parameters.AddWithValue("@rateW", txtRW.Text);
            comm.Parameters.AddWithValue("@OT_hr", txtOThr.Text);
            comm.Parameters.AddWithValue("@Reg_OT", txtOT.Text);
            comm.Parameters.AddWithValue("@gross_pay", txtGrossPay.Text);
            comm.Parameters.AddWithValue("@gov_mandated", txtManGov.Text);
            comm.Parameters.AddWithValue("@CA", txtCA.Text);
            comm.Parameters.AddWithValue("@totaldeduct", txttotaldeduct.Text);
            comm.Parameters.AddWithValue("@total_netpay", txtNetPay.Text);


            comm.ExecuteNonQuery();

            MessageBox.Show("Data Updated Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillPayrollDGV();
            txtClear();

        }
        #endregion

        #region Datagrid Cell Click
        private void DGVpayroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtid.Text = Convert.ToString(DGVpayroll[0, row].Value);
                labelID.Text = Convert.ToString(DGVpayroll[1, row].Value);
                txtPosition.Text = Convert.ToString(DGVpayroll[2, row].Value);
                labelDate.Text = Convert.ToString(DGVpayroll[3, row].Value);
                cmbEmp.Text = Convert.ToString(DGVpayroll[4, row].Value);
                txtNoDays.Text = Convert.ToString(DGVpayroll[5, row].Value);
                txtRate.Text = Convert.ToString(DGVpayroll[6, row].Value);
                txtRW.Text = Convert.ToString(DGVpayroll[7, row].Value);
                txtOThr.Text = Convert.ToString(DGVpayroll[8, row].Value);
                txtOT.Text = Convert.ToString(DGVpayroll[9, row].Value);
                txtGrossPay.Text = Convert.ToString(DGVpayroll[10, row].Value);
                txtManGov.Text = Convert.ToString(DGVpayroll[11, row].Value);
                txtCA.Text = Convert.ToString(DGVpayroll[12, row].Value);
                txttotaldeduct.Text = Convert.ToString(DGVpayroll[13, row].Value);
                txtNetPay.Text = Convert.ToString(DGVpayroll[14, row].Value);
                btnEdit.Visible = true;
            }
            catch
            {

            }
            
          
        }

        #endregion
    }
}










