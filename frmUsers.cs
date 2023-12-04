using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Payroll_System
{
    public partial class frmUsers : Form
    {
       public frmUsers()
        {
            InitializeComponent();
            cmbLoadUsertype();
            fillUsersDGV();
            txtid.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }


        #region Textbox Clear  
        public void txtClear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtFname.Clear();
            txtLname.Clear();
            cmbUserlevel.Text = string.Empty;
            pictureBox.Image = null;
        }

        #endregion

        #region ComboBox User Role

        private void cmbLoadUsertype()
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            comm.CommandText = "Select  * from User_Type";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            DataRow itemrow = table1.NewRow();
            itemrow[1] = "--Select Role--";
            table1.Rows.InsertAt(itemrow, 0);

            cmbUserlevel.DataSource = table1;
            cmbUserlevel.DisplayMember = "UserType";
            cmbUserlevel.ValueMember = "id";
            cmbUserlevel.SelectedIndex = 0;
        }
        #endregion


        #region Close User
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to close?", "Users Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion


        #region Cancel

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtClear();
            cmbUserlevel.Text = string.Empty;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        #endregion

        #region User Save
        private void btnSave_Click(object sender, EventArgs e)
        {

            CryptoClass cl = new CryptoClass();
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Focus();
                MessageBox.Show("Username field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           else if (txtPassword.Text == string.Empty)
            {
                txtPassword.Focus();
                MessageBox.Show("Password field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtFname.Text == string.Empty)
            {
                txtFname.Focus();
                MessageBox.Show("Firstname field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtLname.Text == string.Empty)
            {
                txtLname.Focus();
                MessageBox.Show("Lastname field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbUserlevel.Text == string.Empty)
            {
                cmbUserlevel.Focus();
                MessageBox.Show("User Level field is required!", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Username from Payroll_Users where Username ='" + txtUsername.Text + "'", P_Connection.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Username is Already Exist", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClear();
                }
                else
                {
                    comm.CommandText = "Insert into Payroll_Users VALUES (@Username,@Password,@Firstname,@Lastname, @type, @photo)";
                    comm.Parameters.AddWithValue("@Username", txtUsername.Text);
                    comm.Parameters.AddWithValue("@Password", cl.Encrypt(txtPassword.Text));
                    comm.Parameters.AddWithValue("@Firstname", (txtFname.Text));
                    comm.Parameters.AddWithValue("@Lastname", (txtLname.Text));
                    comm.Parameters.AddWithValue("@type", Convert.ToInt32(cmbUserlevel.SelectedValue));
                    MemoryStream memstr = new MemoryStream();
                    pictureBox.Image.Save(memstr, pictureBox.Image.RawFormat);
                    comm.Parameters.AddWithValue("@photo", memstr.ToArray());

                    comm.ExecuteNonQuery();
                    MessageBox.Show("User Save Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillUsersDGV();
                    txtClear();
                }
            }  
               
        }
        #endregion
       
        #region Fill Datagrid User         
        private void fillUsersDGV()
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;

           comm.CommandText = "SELECT id, Username, Password, Firstname, Lastname, type, photo FROM Payroll_Users ORDER by Firstname ASC";
          

            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUsers.DataSource = dt;

        }
        #endregion


        #region Datagrid Cell Click
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // int intid = 0;
                int row = e.RowIndex;
                txtid.Text = dgvUsers.SelectedCells[0].Value.ToString();
                // intid = Convert.ToInt32(dgvUsers[0, row].Value);
                txtUsername.Text = dgvUsers.SelectedCells[1].Value.ToString();
                txtPassword.Text = dgvUsers.SelectedCells[2].Value.ToString();
                txtFname.Text = dgvUsers.SelectedCells[3].Value.ToString();
                txtLname.Text = dgvUsers.SelectedCells[4].Value.ToString();
                // cmbUserlevel.Text = Convert.ToString(dgvUsers[5, row].Value.ToString());
                cmbUserlevel.SelectedValue = dgvUsers.SelectedCells[5].Value.ToString();
                Byte[] data = new Byte[0];
                data = (Byte[])(dgvUsers[6, row].Value);
                MemoryStream mem = new MemoryStream(data);
                pictureBox.Image = Image.FromStream(mem);
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            catch(Exception ex)
            { 
                pictureBox.Image = null;
                MessageBox.Show(ex.Message, "No Photo in Database");
                return;
            }

        }
        #endregion

        #region Upload Image
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "Downloads";
            ofd.Filter = "Image Files(*.jpg)|*.jpg|All Files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(ofd.FileName);

            }
        }

        #endregion

        #region Delete User
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                P_Connection NewConnection = new P_Connection();
                NewConnection.Connection_P();

                SqlCommand comm = new SqlCommand();
                comm.Connection = P_Connection.conn;

                DialogResult DR = MessageBox.Show("Are you sure you want to delete this User " + txtUsername.Text + "?",
               "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    comm.CommandText = "Delete From Payroll_Users Where id=@id";
                    comm.Parameters.AddWithValue("@id", int.Parse(txtid.Text));

                    comm.ExecuteNonQuery();

                    MessageBox.Show("User Delete Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillUsersDGV();
                    txtClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }
        #endregion

        #region Update User
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            P_Connection NewConnection = new P_Connection();
            NewConnection.Connection_P();

            SqlCommand comm = new SqlCommand();
            comm.Connection = P_Connection.conn;


            comm.CommandText = "Update Payroll_Users set Firstname = @Firstname, Lastname = @Lastname, type = @type, photo = @photo WHERE id = @id";
            comm.Parameters.AddWithValue("@id", txtid.Text);
            comm.Parameters.AddWithValue("@Firstname", txtFname.Text);
            comm.Parameters.AddWithValue("@Lastname", txtLname.Text);
            comm.Parameters.AddWithValue("@type", Convert.ToInt32(cmbUserlevel.SelectedValue));
            MemoryStream memstr = new MemoryStream();
            pictureBox.Image.Save(memstr, pictureBox.Image.RawFormat);
            comm.Parameters.AddWithValue("@photo", memstr.ToArray());

            comm.ExecuteNonQuery();

            MessageBox.Show("User Updated Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillUsersDGV();
            txtClear();
            btnUpdate.Visible = false;

        }
        #endregion

       
    }

}


