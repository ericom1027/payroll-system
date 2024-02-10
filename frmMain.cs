using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class frmMain : Form
       
    {
        
        public frmMain()
        {
            InitializeComponent();
            panelB.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 42)
            {
                PanelMenu.Visible = false;
                PanelMenu.Width = 255;
                PanelAnimator.ShowSync(PanelMenu);
                PictureBanimator.ShowSync(PictureBox);
            }
            else
            {
                PictureBanimator.HideSync(PictureBox);
                PanelMenu.Visible = false;
                PanelMenu.Width = 42;
                PanelAnimator.ShowSync(PanelMenu);

            }

        }
        private void btnEmp_Click(object sender, EventArgs e)
        {
            frmAddEmployee fSAddEmployee = new frmAddEmployee();
            fSAddEmployee.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            frmPayroll fsPayroll = new frmPayroll();
            fsPayroll.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers fSUsers = new frmUsers();
            fSUsers.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReporting fSReporting = new frmReporting();
            fSReporting.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GetRole roleHelper = new GetRole();
            labelfn.Text = ClassParameters.fname;
            labelLastname.Text = ClassParameters.lname;
            userlabel.Text = ClassParameters.uname;
           
            ClassParameters.userRoleString = roleHelper.GetRoleString(ClassParameters.userrole);
            LabelRole.Text = ClassParameters.userRoleString;
            
            PictureBox.Image = ClassParameters.img;
            bPicBox1.Image = ClassParameters.img;
            if (LabelRole.Text == "User")
            {
                btnUsers.Enabled = false;
                btnChangepass.Enabled = false;
            }
        }

        private void bPicBox1_Click(object sender, EventArgs e)
        {
            if(panelB.Visible == false)
            {
                panelB.Visible = true;
            }
            else
            {
                panelB.Visible = false;
            }
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            DialogResult dQuestionResuslt = MessageBox.Show("Are your sure you want to Sign Out?", " Main Dashboard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dQuestionResuslt == DialogResult.Yes)
            {
                frmMain.ActiveForm.Close();
                frmLogin fl = new frmLogin();
                fl.Show();
            }

           
        }
        private void btnChangepass_Click_1(object sender, EventArgs e)
        {
            ChangePassword frmPass = new ChangePassword();
            frmPass.ShowDialog();
        }

       
        private void btnCA_Click(object sender, EventArgs e)
        {
            frmCashAdvance frmCA = new frmCashAdvance();
            frmCA.ShowDialog();
        }
    }
 }
    

