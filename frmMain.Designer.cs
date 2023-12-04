namespace Payroll_System
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.MainElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnCA = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelfn = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelRole = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelLastname = new Bunifu.UI.WinForms.BunifuLabel();
            this.userlabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnReports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPayroll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.bPicBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.headerDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelAnimator = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panelB = new System.Windows.Forms.Panel();
            this.btnSignout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChangepass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.PictureBanimator = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelB.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainElipse
            // 
            this.MainElipse.ElipseRadius = 5;
            this.MainElipse.TargetControl = this;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.DimGray;
            this.PanelMenu.Controls.Add(this.btnCA);
            this.PanelMenu.Controls.Add(this.labelfn);
            this.PanelMenu.Controls.Add(this.LabelRole);
            this.PanelMenu.Controls.Add(this.labelLastname);
            this.PanelMenu.Controls.Add(this.userlabel);
            this.PanelMenu.Controls.Add(this.bunifuLabel1);
            this.PanelMenu.Controls.Add(this.bunifuLabel3);
            this.PanelMenu.Controls.Add(this.btnReports);
            this.PanelMenu.Controls.Add(this.btnUsers);
            this.PanelMenu.Controls.Add(this.btnPayroll);
            this.PanelMenu.Controls.Add(this.btnEmp);
            this.PanelMenu.Controls.Add(this.btnMenu);
            this.PanelMenu.Controls.Add(this.PictureBox);
            this.PictureBanimator.SetDecoration(this.PanelMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelMenu.Location = new System.Drawing.Point(0, 38);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(255, 747);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnCA
            // 
            this.btnCA.Active = false;
            this.btnCA.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCA.BorderRadius = 0;
            this.btnCA.ButtonText = "   Cash Advance";
            this.btnCA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnCA, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.btnCA, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnCA.DisabledColor = System.Drawing.Color.Gray;
            this.btnCA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCA.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCA.Iconimage = global::Payroll_System.Properties.Resources.icons8_cash_50;
            this.btnCA.Iconimage_right = null;
            this.btnCA.Iconimage_right_Selected = null;
            this.btnCA.Iconimage_Selected = null;
            this.btnCA.IconMarginLeft = 0;
            this.btnCA.IconMarginRight = 0;
            this.btnCA.IconRightVisible = true;
            this.btnCA.IconRightZoom = 0D;
            this.btnCA.IconVisible = true;
            this.btnCA.IconZoom = 45D;
            this.btnCA.IsTab = false;
            this.btnCA.Location = new System.Drawing.Point(0, 260);
            this.btnCA.Name = "btnCA";
            this.btnCA.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCA.OnHovercolor = System.Drawing.Color.Gray;
            this.btnCA.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCA.selected = false;
            this.btnCA.Size = new System.Drawing.Size(255, 42);
            this.btnCA.TabIndex = 9;
            this.btnCA.Text = "   Cash Advance";
            this.btnCA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCA.Textcolor = System.Drawing.Color.White;
            this.btnCA.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // labelfn
            // 
            this.labelfn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelfn.AutoEllipsis = false;
            this.labelfn.CursorType = null;
            this.PictureBanimator.SetDecoration(this.labelfn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.labelfn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.labelfn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelfn.Location = new System.Drawing.Point(90, 63);
            this.labelfn.Name = "labelfn";
            this.labelfn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelfn.Size = new System.Drawing.Size(42, 19);
            this.labelfn.TabIndex = 24;
            this.labelfn.Text = "fname";
            this.labelfn.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelfn.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LabelRole
            // 
            this.LabelRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRole.AutoEllipsis = false;
            this.LabelRole.CursorType = null;
            this.PictureBanimator.SetDecoration(this.LabelRole, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.LabelRole, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LabelRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRole.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelRole.Location = new System.Drawing.Point(147, 106);
            this.LabelRole.Name = "LabelRole";
            this.LabelRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelRole.Size = new System.Drawing.Size(10, 17);
            this.LabelRole.TabIndex = 23;
            this.LabelRole.Text = "u";
            this.LabelRole.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelRole.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // labelLastname
            // 
            this.labelLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastname.AutoEllipsis = false;
            this.labelLastname.CursorType = null;
            this.PictureBanimator.SetDecoration(this.labelLastname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.labelLastname, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.labelLastname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelLastname.Location = new System.Drawing.Point(139, 63);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLastname.Size = new System.Drawing.Size(41, 19);
            this.labelLastname.TabIndex = 22;
            this.labelLastname.Text = "lname";
            this.labelLastname.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelLastname.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // userlabel
            // 
            this.userlabel.AutoEllipsis = false;
            this.userlabel.CursorType = null;
            this.PictureBanimator.SetDecoration(this.userlabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.userlabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.userlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.userlabel.Location = new System.Drawing.Point(163, 83);
            this.userlabel.Name = "userlabel";
            this.userlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userlabel.Size = new System.Drawing.Size(28, 19);
            this.userlabel.TabIndex = 21;
            this.userlabel.Text = "user";
            this.userlabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.userlabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.PictureBanimator.SetDecoration(this.bunifuLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(91, 106);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(57, 17);
            this.bunifuLabel1.TabIndex = 20;
            this.bunifuLabel1.Text = "User Type:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.PictureBanimator.SetDecoration(this.bunifuLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(91, 85);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(72, 17);
            this.bunifuLabel3.TabIndex = 19;
            this.bunifuLabel3.Text = "Current User:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnReports
            // 
            this.btnReports.Active = false;
            this.btnReports.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.BorderRadius = 0;
            this.btnReports.ButtonText = "   Reports";
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnReports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.btnReports, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnReports.DisabledColor = System.Drawing.Color.Gray;
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnReports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReports.Iconimage = global::Payroll_System.Properties.Resources.icons8_reports_24;
            this.btnReports.Iconimage_right = null;
            this.btnReports.Iconimage_right_Selected = null;
            this.btnReports.Iconimage_Selected = null;
            this.btnReports.IconMarginLeft = 0;
            this.btnReports.IconMarginRight = 0;
            this.btnReports.IconRightVisible = true;
            this.btnReports.IconRightZoom = 0D;
            this.btnReports.IconVisible = true;
            this.btnReports.IconZoom = 45D;
            this.btnReports.IsTab = false;
            this.btnReports.Location = new System.Drawing.Point(0, 346);
            this.btnReports.Name = "btnReports";
            this.btnReports.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnReports.OnHovercolor = System.Drawing.Color.Gray;
            this.btnReports.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReports.selected = false;
            this.btnReports.Size = new System.Drawing.Size(255, 42);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "   Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Textcolor = System.Drawing.Color.White;
            this.btnReports.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Active = false;
            this.btnUsers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsers.BorderRadius = 0;
            this.btnUsers.ButtonText = "   Users";
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnUsers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.btnUsers, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnUsers.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUsers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsers.Iconimage = global::Payroll_System.Properties.Resources.icons8_users_242;
            this.btnUsers.Iconimage_right = null;
            this.btnUsers.Iconimage_right_Selected = null;
            this.btnUsers.Iconimage_Selected = null;
            this.btnUsers.IconMarginLeft = 0;
            this.btnUsers.IconMarginRight = 0;
            this.btnUsers.IconRightVisible = true;
            this.btnUsers.IconRightZoom = 0D;
            this.btnUsers.IconVisible = true;
            this.btnUsers.IconZoom = 45D;
            this.btnUsers.IsTab = false;
            this.btnUsers.Location = new System.Drawing.Point(0, 303);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUsers.OnHovercolor = System.Drawing.Color.Gray;
            this.btnUsers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsers.selected = false;
            this.btnUsers.Size = new System.Drawing.Size(255, 42);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "   Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Textcolor = System.Drawing.Color.White;
            this.btnUsers.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnPayroll
            // 
            this.btnPayroll.Active = false;
            this.btnPayroll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPayroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayroll.BorderRadius = 0;
            this.btnPayroll.ButtonText = "   Payroll";
            this.btnPayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnPayroll, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.btnPayroll, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnPayroll.DisabledColor = System.Drawing.Color.Gray;
            this.btnPayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPayroll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPayroll.Iconimage = global::Payroll_System.Properties.Resources.icons8_payroll_68;
            this.btnPayroll.Iconimage_right = null;
            this.btnPayroll.Iconimage_right_Selected = null;
            this.btnPayroll.Iconimage_Selected = null;
            this.btnPayroll.IconMarginLeft = 0;
            this.btnPayroll.IconMarginRight = 0;
            this.btnPayroll.IconRightVisible = true;
            this.btnPayroll.IconRightZoom = 0D;
            this.btnPayroll.IconVisible = true;
            this.btnPayroll.IconZoom = 45D;
            this.btnPayroll.IsTab = false;
            this.btnPayroll.Location = new System.Drawing.Point(0, 217);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPayroll.OnHovercolor = System.Drawing.Color.Gray;
            this.btnPayroll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayroll.selected = false;
            this.btnPayroll.Size = new System.Drawing.Size(255, 42);
            this.btnPayroll.TabIndex = 6;
            this.btnPayroll.Text = "   Payroll";
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.Textcolor = System.Drawing.Color.White;
            this.btnPayroll.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.Active = false;
            this.btnEmp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmp.BorderRadius = 0;
            this.btnEmp.ButtonText = "   Employee";
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnEmp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.btnEmp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnEmp.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEmp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmp.Iconimage = global::Payroll_System.Properties.Resources.icons8_employee_24;
            this.btnEmp.Iconimage_right = null;
            this.btnEmp.Iconimage_right_Selected = null;
            this.btnEmp.Iconimage_Selected = null;
            this.btnEmp.IconMarginLeft = 0;
            this.btnEmp.IconMarginRight = 0;
            this.btnEmp.IconRightVisible = true;
            this.btnEmp.IconRightZoom = 0D;
            this.btnEmp.IconVisible = true;
            this.btnEmp.IconZoom = 45D;
            this.btnEmp.IsTab = false;
            this.btnEmp.Location = new System.Drawing.Point(0, 174);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEmp.OnHovercolor = System.Drawing.Color.Gray;
            this.btnEmp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmp.selected = false;
            this.btnEmp.Size = new System.Drawing.Size(255, 42);
            this.btnEmp.TabIndex = 5;
            this.btnEmp.Text = "   Employee";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.Textcolor = System.Drawing.Color.White;
            this.btnEmp.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Active = false;
            this.btnMenu.Activecolor = System.Drawing.Color.Blue;
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.ButtonText = "";
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.btnMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenu.Iconimage = global::Payroll_System.Properties.Resources.icons8_menu_50;
            this.btnMenu.Iconimage_right = null;
            this.btnMenu.Iconimage_right_Selected = null;
            this.btnMenu.Iconimage_Selected = null;
            this.btnMenu.IconMarginLeft = 0;
            this.btnMenu.IconMarginRight = 0;
            this.btnMenu.IconRightVisible = true;
            this.btnMenu.IconRightZoom = 0D;
            this.btnMenu.IconVisible = true;
            this.btnMenu.IconZoom = 40D;
            this.btnMenu.IsTab = false;
            this.btnMenu.Location = new System.Drawing.Point(213, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenu.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnMenu.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnMenu.selected = false;
            this.btnMenu.Size = new System.Drawing.Size(39, 36);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Textcolor = System.Drawing.Color.White;
            this.btnMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.AllowFocused = false;
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BorderRadius = 0;
            this.PictureBanimator.SetDecoration(this.PictureBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PictureBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBox.Image = global::Payroll_System.Properties.Resources.icons8_male_user_100;
            this.PictureBox.IsCircle = false;
            this.PictureBox.Location = new System.Drawing.Point(9, 60);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(75, 75);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            this.PictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.bPicBox1);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.PictureBanimator.SetDecoration(this.header, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.header, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1000, 41);
            this.header.TabIndex = 2;
            // 
            // bPicBox1
            // 
            this.bPicBox1.AllowFocused = false;
            this.bPicBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPicBox1.BorderRadius = 0;
            this.PictureBanimator.SetDecoration(this.bPicBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bPicBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bPicBox1.Image = global::Payroll_System.Properties.Resources.icons8_male_user_100;
            this.bPicBox1.IsCircle = false;
            this.bPicBox1.Location = new System.Drawing.Point(959, 3);
            this.bPicBox1.Name = "bPicBox1";
            this.bPicBox1.Size = new System.Drawing.Size(35, 35);
            this.bPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bPicBox1.TabIndex = 4;
            this.bPicBox1.TabStop = false;
            this.bPicBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.bPicBox1.Click += new System.EventHandler(this.bPicBox1_Click);
            // 
            // pictureBox1
            // 
            this.PanelAnimator.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = global::Payroll_System.Properties.Resources.icons8_payroll_32;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.bunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(117, 21);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Payroll System";
            // 
            // MainDragControl
            // 
            this.MainDragControl.Fixed = true;
            this.MainDragControl.Horizontal = true;
            this.MainDragControl.TargetControl = null;
            this.MainDragControl.Vertical = true;
            // 
            // headerDragControl
            // 
            this.headerDragControl.Fixed = true;
            this.headerDragControl.Horizontal = true;
            this.headerDragControl.TargetControl = this.header;
            this.headerDragControl.Vertical = true;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation1;
            // 
            // panelB
            // 
            this.panelB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelB.BackColor = System.Drawing.Color.DimGray;
            this.panelB.Controls.Add(this.btnSignout);
            this.panelB.Controls.Add(this.btnChangepass);
            this.PictureBanimator.SetDecoration(this.panelB, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panelB, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelB.Location = new System.Drawing.Point(814, 41);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(184, 79);
            this.panelB.TabIndex = 3;
            // 
            // btnSignout
            // 
            this.btnSignout.Active = false;
            this.btnSignout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSignout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignout.BorderRadius = 0;
            this.btnSignout.ButtonText = "  Sign Out";
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnSignout, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.btnSignout, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignout.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSignout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignout.Iconimage = global::Payroll_System.Properties.Resources.icons8_sign_out_32;
            this.btnSignout.Iconimage_right = null;
            this.btnSignout.Iconimage_right_Selected = null;
            this.btnSignout.Iconimage_Selected = null;
            this.btnSignout.IconMarginLeft = 0;
            this.btnSignout.IconMarginRight = 0;
            this.btnSignout.IconRightVisible = true;
            this.btnSignout.IconRightZoom = 0D;
            this.btnSignout.IconVisible = true;
            this.btnSignout.IconZoom = 45D;
            this.btnSignout.IsTab = false;
            this.btnSignout.Location = new System.Drawing.Point(0, 42);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSignout.OnHovercolor = System.Drawing.Color.Gray;
            this.btnSignout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignout.selected = false;
            this.btnSignout.Size = new System.Drawing.Size(184, 33);
            this.btnSignout.TabIndex = 7;
            this.btnSignout.Text = "  Sign Out";
            this.btnSignout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignout.Textcolor = System.Drawing.Color.White;
            this.btnSignout.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnChangepass
            // 
            this.btnChangepass.Active = false;
            this.btnChangepass.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangepass.BorderRadius = 0;
            this.btnChangepass.ButtonText = "   Change Password";
            this.btnChangepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnChangepass, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PictureBanimator.SetDecoration(this.btnChangepass, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnChangepass.DisabledColor = System.Drawing.Color.Gray;
            this.btnChangepass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangepass.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChangepass.Iconimage = global::Payroll_System.Properties.Resources.icons8_change_password_32;
            this.btnChangepass.Iconimage_right = null;
            this.btnChangepass.Iconimage_right_Selected = null;
            this.btnChangepass.Iconimage_Selected = null;
            this.btnChangepass.IconMarginLeft = 0;
            this.btnChangepass.IconMarginRight = 0;
            this.btnChangepass.IconRightVisible = true;
            this.btnChangepass.IconRightZoom = 0D;
            this.btnChangepass.IconVisible = true;
            this.btnChangepass.IconZoom = 45D;
            this.btnChangepass.IsTab = false;
            this.btnChangepass.Location = new System.Drawing.Point(-1, 4);
            this.btnChangepass.Name = "btnChangepass";
            this.btnChangepass.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnChangepass.OnHovercolor = System.Drawing.Color.Gray;
            this.btnChangepass.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChangepass.selected = false;
            this.btnChangepass.Size = new System.Drawing.Size(187, 33);
            this.btnChangepass.TabIndex = 6;
            this.btnChangepass.Text = "   Change Password";
            this.btnChangepass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangepass.Textcolor = System.Drawing.Color.White;
            this.btnChangepass.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangepass.Click += new System.EventHandler(this.btnChangepass_Click_1);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            // 
            // PictureBanimator
            // 
            this.PictureBanimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.PictureBanimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PictureBanimator.DefaultAnimation = animation2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 485);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.header);
            this.Controls.Add(this.PanelMenu);
            this.PictureBanimator.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse MainElipse;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel PanelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenu;
        private Bunifu.UI.WinForms.BunifuTransition PanelAnimator;
        private Bunifu.UI.WinForms.BunifuPictureBox PictureBox;
        private Bunifu.Framework.UI.BunifuDragControl MainDragControl;
        private Bunifu.Framework.UI.BunifuDragControl headerDragControl;
        private System.Windows.Forms.Timer timerMain;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmp;
        private Bunifu.UI.WinForms.BunifuTransition PictureBanimator;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayroll;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsers;
        private Bunifu.Framework.UI.BunifuFlatButton btnReports;
        private Bunifu.UI.WinForms.BunifuPictureBox bPicBox1;
        private System.Windows.Forms.Panel panelB;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignout;
        private Bunifu.Framework.UI.BunifuFlatButton btnChangepass;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel userlabel;
        private Bunifu.UI.WinForms.BunifuLabel labelLastname;
        private Bunifu.UI.WinForms.BunifuLabel LabelRole;
        private Bunifu.UI.WinForms.BunifuLabel labelfn;
        private Bunifu.Framework.UI.BunifuFlatButton btnCA;
    }
}

