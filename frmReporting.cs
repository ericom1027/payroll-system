using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class frmReporting : Form
    {
        public frmReporting()
        {
            InitializeComponent();
            fillReportDGV();
            cmbempload();
            btnPrint.Enabled = false;
            comboemp.Enabled = false;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           printReport();
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                P_Connection NewConnection = new P_Connection();
                NewConnection.Connection_P();

                SqlCommand comm = new SqlCommand();
                comm.Connection = P_Connection.conn;

                SqlDataAdapter da;
                da = new SqlDataAdapter("SELECT * FROM emp_payroll WHERE PDate BETWEEN @Dt1 AND @Dt2 ORDER BY emp_name ASC", P_Connection.conn);
                DataTable dt = new DataTable();

                // Adjust date parameters to cover the entire day
                da.SelectCommand.Parameters.AddWithValue("@Dt1", Dtpkfrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@Dt2", Dtpkto.Value.Date.AddDays(1).AddSeconds(-1));

                da.Fill(dt);
                DGVpayroll.DataSource = dt;
                btnPrint.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private void cmbempload()
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            comm.CommandText = "Select * From Employee";
            SqlDataReader dr;
            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                comboemp.Items.Add(dr["Employee_Name"]);
            }
            comboemp.SelectedIndex = -1;
        }


        private void fillReportDGV()
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

        private void comboemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterempname();
            btnSearch.Enabled = false;
        }

        public void filterempname()
        {
            try
            {
                P_Connection NewConnection = new P_Connection();
                 NewConnection.Connection_P();

                SqlCommand comm = new SqlCommand();
                comm.Connection = P_Connection.conn;

                comm.CommandText = "Select * From emp_payroll where emp_name ='" + comboemp.SelectedItem.ToString() + "' AND PDate>='" + Dtpkfrom.Value.ToShortDateString() + "' AND PDate<='" + Dtpkto.Value.ToShortDateString() + "'";
              //  comm.CommandText = "Select * From emp_payroll where emp_name ='" + comboemp.SelectedItem.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGVpayroll.DataSource = dt;
                
            }
            catch
            {

            }
    }

        public void printReport()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("empid", typeof(string));
            dt.Columns.Add("position", typeof(string));
            dt.Columns.Add("PDate", typeof(string));
            dt.Columns.Add("emp_name", typeof(string));
            dt.Columns.Add("no_of_days", typeof(string));
            dt.Columns.Add("rate", typeof(string));
            dt.Columns.Add("rateW", typeof(string));
            dt.Columns.Add("OT_hr", typeof(string));
            dt.Columns.Add("Reg_OT", typeof(string));
            dt.Columns.Add("gross_pay", typeof(string));
            dt.Columns.Add("gov_mandated", typeof(string));
            dt.Columns.Add("CA", typeof(string));
            dt.Columns.Add("totaldeduct", typeof(string));
            dt.Columns.Add("total_netpay", typeof(string));

            foreach (DataGridViewRow dgv in DGVpayroll.Rows)
            {
              
              dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value, dgv.Cells[10].Value, dgv.Cells[11].Value, dgv.Cells[12].Value, dgv.Cells[13].Value, dgv.Cells[14].Value);

            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("payroll.xml");
           
            frmReports frmRpt = new frmReports();
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            frmRpt.crystalReportViewer1.ReportSource = cr;
            frmRpt.crystalReportViewer1.Refresh();
            frmRpt.Show();
        }

        
        private void Dtpkfrom_ValueChanged(object sender, EventArgs e)
        {
            comboemp.Enabled = true;
        }

        private void Dtpkto_ValueChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = true;
        }
    }
}

