using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Payroll_System
{
    public partial class frmLogin : Form
    {
        CryptoClass cl = new CryptoClass();
       public frmLogin()
        {
            InitializeComponent();
        }

       

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Process selProcess in Process.GetProcesses())
            {
                if (selProcess.ProcessName == "taskmgr")
                {
                    selProcess.Kill();
                    break;
                }
            }
        }

      

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();
            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;


            string userEncrpt = (txtUsername.Text);
            string passEncrp = cl.Encrypt(txtPassword.Text);

            comm.CommandText = "Select * From Payroll_Users Where Username='" + userEncrpt + "' AND Password='" + passEncrp + "'";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            if (table1.Rows.Count > 0)
            {

                ClassParameters.fname = table1.Rows[0]["Firstname"].ToString();
                ClassParameters.lname = table1.Rows[0]["Lastname"].ToString();
                ClassParameters.uname = table1.Rows[0]["Username"].ToString();
                ClassParameters.userrole = Convert.ToInt32(table1.Rows[0]["type"].ToString());
                
                
                Byte[] data = new Byte[0];
                data = (Byte[])(table1.Rows[0]["photo"]);
                MemoryStream mem = new MemoryStream(data);
                ClassParameters.img = Image.FromStream(mem);


                frmLogin.ActiveForm.Hide();
                new frmMain().ShowDialog();

            }
            else
            {
                MessageBox.Show("Username or Password invalid");

            }
        }
    }
}

        
    
