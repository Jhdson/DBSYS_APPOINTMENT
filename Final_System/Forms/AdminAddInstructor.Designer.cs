namespace Final_System.Forms
{
    partial class AdminAddInstructor
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
            this.pnlInstructor = new System.Windows.Forms.Panel();
            this.dataGridView1ins = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDELETEINS = new System.Windows.Forms.Button();
            this.btnUPDATEINS = new System.Windows.Forms.Button();
            this.btnAddINS = new System.Windows.Forms.Button();
            this.txtfnameins = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtexins = new System.Windows.Forms.TextBox();
            this.txtcontactins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlnameins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnInstructor = new System.Windows.Forms.Button();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.dataGridViewPARTICIPANTS = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TXTPASS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.TXTUSERNAME = new System.Windows.Forms.TextBox();
            this.TXTFIRSTNAME = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTADDRESS = new System.Windows.Forms.TextBox();
            this.TXTPHONE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTLASTNAME = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TXTEMAIL = new System.Windows.Forms.TextBox();
            this.pbmini1 = new System.Windows.Forms.PictureBox();
            this.pbclose1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1ins)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPARTICIPANTS)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInstructor
            // 
            this.pnlInstructor.BackColor = System.Drawing.Color.SeaShell;
            this.pnlInstructor.Controls.Add(this.dataGridView1ins);
            this.pnlInstructor.Controls.Add(this.panel2);
            this.pnlInstructor.Location = new System.Drawing.Point(12, 57);
            this.pnlInstructor.Name = "pnlInstructor";
            this.pnlInstructor.Size = new System.Drawing.Size(782, 449);
            this.pnlInstructor.TabIndex = 0;
            this.pnlInstructor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInstructor_Paint);
            // 
            // dataGridView1ins
            // 
            this.dataGridView1ins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1ins.Location = new System.Drawing.Point(16, 47);
            this.dataGridView1ins.Name = "dataGridView1ins";
            this.dataGridView1ins.RowHeadersWidth = 62;
            this.dataGridView1ins.Size = new System.Drawing.Size(455, 345);
            this.dataGridView1ins.TabIndex = 15;
            this.dataGridView1ins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1ins_CellClick);
            this.dataGridView1ins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1ins_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDELETEINS);
            this.panel2.Controls.Add(this.btnUPDATEINS);
            this.panel2.Controls.Add(this.btnAddINS);
            this.panel2.Controls.Add(this.txtfnameins);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtexins);
            this.panel2.Controls.Add(this.txtcontactins);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtlnameins);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(482, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 346);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnDELETEINS
            // 
            this.btnDELETEINS.Location = new System.Drawing.Point(195, 305);
            this.btnDELETEINS.Name = "btnDELETEINS";
            this.btnDELETEINS.Size = new System.Drawing.Size(75, 23);
            this.btnDELETEINS.TabIndex = 15;
            this.btnDELETEINS.Text = "Delete";
            this.btnDELETEINS.UseVisualStyleBackColor = true;
            this.btnDELETEINS.Click += new System.EventHandler(this.btnDELETEINS_Click);
            // 
            // btnUPDATEINS
            // 
            this.btnUPDATEINS.Location = new System.Drawing.Point(103, 305);
            this.btnUPDATEINS.Name = "btnUPDATEINS";
            this.btnUPDATEINS.Size = new System.Drawing.Size(75, 23);
            this.btnUPDATEINS.TabIndex = 14;
            this.btnUPDATEINS.Text = "Update";
            this.btnUPDATEINS.UseVisualStyleBackColor = true;
            this.btnUPDATEINS.Click += new System.EventHandler(this.btnUPDATEINS_Click);
            // 
            // btnAddINS
            // 
            this.btnAddINS.Location = new System.Drawing.Point(14, 305);
            this.btnAddINS.Name = "btnAddINS";
            this.btnAddINS.Size = new System.Drawing.Size(75, 23);
            this.btnAddINS.TabIndex = 3;
            this.btnAddINS.Text = "Create";
            this.btnAddINS.UseVisualStyleBackColor = true;
            this.btnAddINS.Click += new System.EventHandler(this.btnAddINS_Click);
            // 
            // txtfnameins
            // 
            this.txtfnameins.Location = new System.Drawing.Point(105, 62);
            this.txtfnameins.Name = "txtfnameins";
            this.txtfnameins.Size = new System.Drawing.Size(162, 20);
            this.txtfnameins.TabIndex = 1;
            this.txtfnameins.TextChanged += new System.EventHandler(this.txtfnameins_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact Number";
            // 
            // txtexins
            // 
            this.txtexins.Location = new System.Drawing.Point(108, 145);
            this.txtexins.Name = "txtexins";
            this.txtexins.Size = new System.Drawing.Size(162, 20);
            this.txtexins.TabIndex = 5;
            // 
            // txtcontactins
            // 
            this.txtcontactins.Location = new System.Drawing.Point(109, 191);
            this.txtcontactins.Name = "txtcontactins";
            this.txtcontactins.Size = new System.Drawing.Size(162, 20);
            this.txtcontactins.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Experties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtlnameins
            // 
            this.txtlnameins.Location = new System.Drawing.Point(108, 102);
            this.txtlnameins.Name = "txtlnameins";
            this.txtlnameins.Size = new System.Drawing.Size(162, 20);
            this.txtlnameins.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(21, 5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(75, 34);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Participant";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnInstructor
            // 
            this.btnInstructor.Location = new System.Drawing.Point(111, 5);
            this.btnInstructor.Name = "btnInstructor";
            this.btnInstructor.Size = new System.Drawing.Size(75, 34);
            this.btnInstructor.TabIndex = 2;
            this.btnInstructor.Text = "Instructor";
            this.btnInstructor.UseVisualStyleBackColor = true;
            this.btnInstructor.Click += new System.EventHandler(this.btnInstructor_Click);
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackColor = System.Drawing.Color.SeaShell;
            this.pnlUsers.Controls.Add(this.dataGridViewPARTICIPANTS);
            this.pnlUsers.Controls.Add(this.panel3);
            this.pnlUsers.Location = new System.Drawing.Point(12, 45);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(782, 461);
            this.pnlUsers.TabIndex = 16;
            // 
            // dataGridViewPARTICIPANTS
            // 
            this.dataGridViewPARTICIPANTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPARTICIPANTS.Location = new System.Drawing.Point(9, 27);
            this.dataGridViewPARTICIPANTS.Name = "dataGridViewPARTICIPANTS";
            this.dataGridViewPARTICIPANTS.RowHeadersWidth = 62;
            this.dataGridViewPARTICIPANTS.Size = new System.Drawing.Size(467, 407);
            this.dataGridViewPARTICIPANTS.TabIndex = 15;
            this.dataGridViewPARTICIPANTS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPARTICIPANTS_CellClick);
            this.dataGridViewPARTICIPANTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPARTICIPANTS_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TXTPASS);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.btnDELETE);
            this.panel3.Controls.Add(this.btnUPDATE);
            this.panel3.Controls.Add(this.btnADD);
            this.panel3.Controls.Add(this.TXTUSERNAME);
            this.panel3.Controls.Add(this.TXTFIRSTNAME);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.TXTADDRESS);
            this.panel3.Controls.Add(this.TXTPHONE);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.TXTLASTNAME);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.TXTEMAIL);
            this.panel3.Location = new System.Drawing.Point(485, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 406);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // TXTPASS
            // 
            this.TXTPASS.Location = new System.Drawing.Point(95, 280);
            this.TXTPASS.Name = "TXTPASS";
            this.TXTPASS.Size = new System.Drawing.Size(175, 20);
            this.TXTPASS.TabIndex = 17;
            this.TXTPASS.TextChanged += new System.EventHandler(this.TXTPASS_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 285);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Password";
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(194, 348);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(75, 26);
            this.btnDELETE.TabIndex = 15;
            this.btnDELETE.Text = "Delete";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(113, 348);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(75, 26);
            this.btnUPDATE.TabIndex = 14;
            this.btnUPDATE.Text = "Update";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(32, 348);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 26);
            this.btnADD.TabIndex = 3;
            this.btnADD.Text = "Create";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // TXTUSERNAME
            // 
            this.TXTUSERNAME.Location = new System.Drawing.Point(95, 239);
            this.TXTUSERNAME.Name = "TXTUSERNAME";
            this.TXTUSERNAME.Size = new System.Drawing.Size(175, 20);
            this.TXTUSERNAME.TabIndex = 13;
            // 
            // TXTFIRSTNAME
            // 
            this.TXTFIRSTNAME.Location = new System.Drawing.Point(92, 80);
            this.TXTFIRSTNAME.Name = "TXTFIRSTNAME";
            this.TXTFIRSTNAME.Size = new System.Drawing.Size(175, 20);
            this.TXTFIRSTNAME.TabIndex = 1;
            this.TXTFIRSTNAME.TextChanged += new System.EventHandler(this.TXTFIRSTNAME_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Username";
            // 
            // TXTADDRESS
            // 
            this.TXTADDRESS.Location = new System.Drawing.Point(93, 119);
            this.TXTADDRESS.Name = "TXTADDRESS";
            this.TXTADDRESS.Size = new System.Drawing.Size(175, 20);
            this.TXTADDRESS.TabIndex = 7;
            this.TXTADDRESS.TextChanged += new System.EventHandler(this.TXTADDRESS_TextChanged);
            // 
            // TXTPHONE
            // 
            this.TXTPHONE.Location = new System.Drawing.Point(95, 198);
            this.TXTPHONE.Name = "TXTPHONE";
            this.TXTPHONE.Size = new System.Drawing.Size(175, 20);
            this.TXTPHONE.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "First Name";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Email Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Phone Number";
            // 
            // TXTLASTNAME
            // 
            this.TXTLASTNAME.Location = new System.Drawing.Point(92, 46);
            this.TXTLASTNAME.Name = "TXTLASTNAME";
            this.TXTLASTNAME.Size = new System.Drawing.Size(175, 20);
            this.TXTLASTNAME.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Last Name";
            // 
            // TXTEMAIL
            // 
            this.TXTEMAIL.Location = new System.Drawing.Point(94, 157);
            this.TXTEMAIL.Name = "TXTEMAIL";
            this.TXTEMAIL.Size = new System.Drawing.Size(175, 20);
            this.TXTEMAIL.TabIndex = 9;
            // 
            // pbmini1
            // 
            this.pbmini1.Image = global::Final_System.Properties.Resources.minimize_sign;
            this.pbmini1.Location = new System.Drawing.Point(738, 12);
            this.pbmini1.Name = "pbmini1";
            this.pbmini1.Size = new System.Drawing.Size(26, 14);
            this.pbmini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmini1.TabIndex = 25;
            this.pbmini1.TabStop = false;
            // 
            // pbclose1
            // 
            this.pbclose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbclose1.Image = global::Final_System.Properties.Resources.close;
            this.pbclose1.Location = new System.Drawing.Point(770, 5);
            this.pbclose1.Name = "pbclose1";
            this.pbclose1.Size = new System.Drawing.Size(24, 21);
            this.pbclose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose1.TabIndex = 24;
            this.pbclose1.TabStop = false;
            this.pbclose1.Click += new System.EventHandler(this.pbclose1_Click);
            this.pbclose1.MouseHover += new System.EventHandler(this.pbclose1_MouseHover);
            // 
            // AdminAddInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.pbmini1);
            this.Controls.Add(this.pbclose1);
            this.Controls.Add(this.btnInstructor);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlInstructor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAddInstructor";
            this.Text = "AdminAddInstructor";
            this.Load += new System.EventHandler(this.AdminAddInstructor_Load_1);
            this.pnlInstructor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1ins)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPARTICIPANTS)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInstructor;
        private System.Windows.Forms.TextBox txtfnameins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnInstructor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDELETEINS;
        private System.Windows.Forms.Button btnUPDATEINS;
        private System.Windows.Forms.Button btnAddINS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtexins;
        private System.Windows.Forms.TextBox txtcontactins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlnameins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1ins;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox TXTPASS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXTUSERNAME;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTADDRESS;
        private System.Windows.Forms.TextBox TXTPHONE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTLASTNAME;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXTEMAIL;
        private System.Windows.Forms.ErrorProvider errorProviderCustom1;
        private System.Windows.Forms.PictureBox pbclose1;
        private System.Windows.Forms.PictureBox pbmini1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridViewPARTICIPANTS;
        private System.Windows.Forms.TextBox TXTFIRSTNAME;
    }
}