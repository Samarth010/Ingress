namespace Demo
{
    partial class Form1
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.login = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnConnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtenroll = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btnshutdown = new MaterialSkin.Controls.MaterialFlatButton();
            this.forgotpass = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.txtguestno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtguestpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnGuest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.login.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.forgotpass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.login);
            this.materialTabControl1.Controls.Add(this.forgotpass);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 79);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1222, 843);
            this.materialTabControl1.TabIndex = 22;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.Controls.Add(this.panel2);
            this.login.Controls.Add(this.panel1);
            this.login.Controls.Add(this.label4);
            this.login.Controls.Add(this.Btnshutdown);
            this.login.Location = new System.Drawing.Point(4, 22);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(1214, 817);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnConnect);
            this.panel2.Controls.Add(this.txtip);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(220, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 195);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnect.Depth = 0;
            this.BtnConnect.Location = new System.Drawing.Point(292, 136);
            this.BtnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Primary = true;
            this.BtnConnect.Size = new System.Drawing.Size(146, 49);
            this.BtnConnect.TabIndex = 22;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // txtip
            // 
            this.txtip.Depth = 0;
            this.txtip.Hint = "IP Address";
            this.txtip.Location = new System.Drawing.Point(279, 103);
            this.txtip.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtip.Name = "txtip";
            this.txtip.PasswordChar = '\0';
            this.txtip.SelectedText = "";
            this.txtip.SelectionLength = 0;
            this.txtip.SelectionStart = 0;
            this.txtip.Size = new System.Drawing.Size(419, 23);
            this.txtip.TabIndex = 5;
            this.txtip.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(164, 107);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "IP Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(830, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "(There is error with IP configuration of server. Please ask to admin for IP ADDRE" +
    "SS and enter it in below textbox)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtenroll);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.BtnSubmit);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 329);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo.Properties.Resources.GPERI_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(45, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtenroll
            // 
            this.txtenroll.Depth = 0;
            this.txtenroll.Hint = "Number";
            this.txtenroll.Location = new System.Drawing.Point(487, 108);
            this.txtenroll.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtenroll.Name = "txtenroll";
            this.txtenroll.PasswordChar = '\0';
            this.txtenroll.SelectedText = "";
            this.txtenroll.SelectionLength = 0;
            this.txtenroll.SelectionStart = 0;
            this.txtenroll.Size = new System.Drawing.Size(419, 23);
            this.txtenroll.TabIndex = 0;
            this.txtenroll.UseSystemPasswordChar = false;
            this.txtenroll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtenroll_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(318, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Enrollment Number";
            // 
            // txtpass
            // 
            this.txtpass.Depth = 0;
            this.txtpass.Hint = "Password";
            this.txtpass.Location = new System.Drawing.Point(487, 149);
            this.txtpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.Size = new System.Drawing.Size(419, 23);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.Depth = 0;
            this.BtnSubmit.Location = new System.Drawing.Point(513, 219);
            this.BtnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Primary = true;
            this.BtnSubmit.Size = new System.Drawing.Size(152, 46);
            this.BtnSubmit.TabIndex = 21;
            this.BtnSubmit.Text = "Login";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(375, 153);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "Welcome Entry Management System";
            // 
            // Btnshutdown
            // 
            this.Btnshutdown.AutoSize = true;
            this.Btnshutdown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btnshutdown.Depth = 0;
            this.Btnshutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnshutdown.Location = new System.Drawing.Point(1149, 6);
            this.Btnshutdown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Btnshutdown.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btnshutdown.Name = "Btnshutdown";
            this.Btnshutdown.Primary = false;
            this.Btnshutdown.Size = new System.Drawing.Size(91, 36);
            this.Btnshutdown.TabIndex = 23;
            this.Btnshutdown.Text = "Shut down";
            this.Btnshutdown.UseVisualStyleBackColor = true;
            this.Btnshutdown.Click += new System.EventHandler(this.Btnshutdown_Click);
            // 
            // forgotpass
            // 
            this.forgotpass.BackColor = System.Drawing.Color.White;
            this.forgotpass.Controls.Add(this.txtguestno);
            this.forgotpass.Controls.Add(this.materialLabel4);
            this.forgotpass.Controls.Add(this.txtguestpass);
            this.forgotpass.Controls.Add(this.BtnGuest);
            this.forgotpass.Controls.Add(this.materialLabel5);
            this.forgotpass.Controls.Add(this.label6);
            this.forgotpass.Controls.Add(this.pictureBox2);
            this.forgotpass.Controls.Add(this.materialFlatButton1);
            this.forgotpass.Controls.Add(this.materialLabel6);
            this.forgotpass.Location = new System.Drawing.Point(4, 22);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Padding = new System.Windows.Forms.Padding(3);
            this.forgotpass.Size = new System.Drawing.Size(1214, 817);
            this.forgotpass.TabIndex = 1;
            this.forgotpass.Text = "Login As Guest";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo.Properties.Resources.GPERI_LOGO;
            this.pictureBox2.Location = new System.Drawing.Point(89, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton1.Location = new System.Drawing.Point(1151, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton1.TabIndex = 24;
            this.materialFlatButton1.Text = "Shut down";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(397, 357);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(0, 19);
            this.materialLabel6.TabIndex = 5;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1222, 34);
            this.materialTabSelector2.TabIndex = 23;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-5, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1264, 57);
            this.materialTabSelector1.TabIndex = 21;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // txtguestno
            // 
            this.txtguestno.Depth = 0;
            this.txtguestno.Hint = "Number";
            this.txtguestno.Location = new System.Drawing.Point(520, 247);
            this.txtguestno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtguestno.Name = "txtguestno";
            this.txtguestno.PasswordChar = '\0';
            this.txtguestno.SelectedText = "";
            this.txtguestno.SelectionLength = 0;
            this.txtguestno.SelectionStart = 0;
            this.txtguestno.Size = new System.Drawing.Size(419, 23);
            this.txtguestno.TabIndex = 28;
            this.txtguestno.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(351, 251);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(139, 19);
            this.materialLabel4.TabIndex = 29;
            this.materialLabel4.Text = "Enrollment Number";
            // 
            // txtguestpass
            // 
            this.txtguestpass.Depth = 0;
            this.txtguestpass.Hint = "Password";
            this.txtguestpass.Location = new System.Drawing.Point(520, 288);
            this.txtguestpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtguestpass.Name = "txtguestpass";
            this.txtguestpass.PasswordChar = '*';
            this.txtguestpass.SelectedText = "";
            this.txtguestpass.SelectionLength = 0;
            this.txtguestpass.SelectionStart = 0;
            this.txtguestpass.Size = new System.Drawing.Size(419, 23);
            this.txtguestpass.TabIndex = 30;
            this.txtguestpass.UseSystemPasswordChar = false;
            // 
            // BtnGuest
            // 
            this.BtnGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuest.Depth = 0;
            this.BtnGuest.Location = new System.Drawing.Point(546, 358);
            this.BtnGuest.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuest.Name = "BtnGuest";
            this.BtnGuest.Primary = true;
            this.BtnGuest.Size = new System.Drawing.Size(152, 46);
            this.BtnGuest.TabIndex = 33;
            this.BtnGuest.Text = "Login ";
            this.BtnGuest.UseVisualStyleBackColor = true;
            this.BtnGuest.Click += new System.EventHandler(this.BtnGuest_Click_1);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(408, 292);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 31;
            this.materialLabel5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "Login As Guest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 765);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.Form1_GiveFeedback);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.materialTabControl1.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.forgotpass.ResumeLayout(false);
            this.forgotpass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage login;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSubmit;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtenroll;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton Btnshutdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton BtnConnect;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtip;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage forgotpass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtguestno;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtguestpass;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuest;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Label label6;
    }
}

