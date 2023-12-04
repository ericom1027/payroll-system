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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CryptoClass cl = new CryptoClass();
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            string OldpassEncrp = cl.Encrypt(txtoldPass.Text);
            string NewPassEncrp = cl.Encrypt(txtnewPass.Text);
            string ConfirmPassEncrp = cl.Encrypt(txtConfirmpass.Text);

            if (txtoldPass.Text == string.Empty)
            {
                txtoldPass.Focus();
                MessageBox.Show("Old Password field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (txtnewPass.Text == string.Empty)
            {
                txtnewPass.Focus();
                MessageBox.Show("New Password field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtConfirmpass.Text == string.Empty)
            {
                txtConfirmpass.Focus();
                MessageBox.Show("Confirm Password field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter da = new SqlDataAdapter("Select Password From Payroll_Users Where Password ='"+ OldpassEncrp + "'", P_Connection.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count.ToString() == "1")
            {
                if(NewPassEncrp == ConfirmPassEncrp)
                {
                    SqlCommand comm = new SqlCommand("Update Payroll_Users set Password = '"+ConfirmPassEncrp+"' WHERE Password ='"+ OldpassEncrp + "'",P_Connection.conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Password updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClear();
                }
                else
                {
                    MessageBox.Show("Passwords do NOT match! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClear();
                }
            }
            else
            {
                MessageBox.Show("Please check your Old Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClear();
            }
        }

        public void txtClear()
        {
            txtoldPass.Text = "";
            txtnewPass.Text = "";
            txtConfirmpass.Text = "";
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            if (txtoldPass.PasswordChar == '*')
                txtoldPass.PasswordChar = '\0';
            else
                txtoldPass.PasswordChar = '*';
        }
    }
}
