﻿namespace Final_System.Forms
{
    partial class UserDashboard
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
            this.Book = new System.Windows.Forms.Button();
            this.txtChckFN = new System.Windows.Forms.TextBox();
            this.txtChckADD = new System.Windows.Forms.TextBox();
            this.txtChckEmail = new System.Windows.Forms.TextBox();
            this.txtChcknUMBER = new System.Windows.Forms.TextBox();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.dtpexpire = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChckLN = new System.Windows.Forms.TextBox();
            this.PNLconfirmbooking = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCheckOUT = new System.Windows.Forms.Button();
            this.pnlINSTUCTOR = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBOOKID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBOOKLN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBOOKContact = new System.Windows.Forms.TextBox();
            this.txtBOOKexpert = new System.Windows.Forms.TextBox();
            this.txtBOOKFN = new System.Windows.Forms.TextBox();
            this.dataGridViewBOOKins = new System.Windows.Forms.DataGridView();
            this.pbclose1 = new System.Windows.Forms.PictureBox();
            this.pbmini1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvDone = new System.Windows.Forms.DataGridView();
            this.panelDONEappoint = new System.Windows.Forms.Panel();
            this.PNLconfirmbooking.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlINSTUCTOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOOKins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDone)).BeginInit();
            this.panelDONEappoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // Book
            // 
            this.Book.Location = new System.Drawing.Point(204, 518);
            this.Book.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(182, 48);
            this.Book.TabIndex = 2;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // txtChckFN
            // 
            this.txtChckFN.Location = new System.Drawing.Point(186, 86);
            this.txtChckFN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChckFN.Name = "txtChckFN";
            this.txtChckFN.Size = new System.Drawing.Size(282, 26);
            this.txtChckFN.TabIndex = 4;
            this.txtChckFN.TextChanged += new System.EventHandler(this.txtChckFN_TextChanged);
            // 
            // txtChckADD
            // 
            this.txtChckADD.Location = new System.Drawing.Point(188, 206);
            this.txtChckADD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChckADD.Name = "txtChckADD";
            this.txtChckADD.Size = new System.Drawing.Size(282, 26);
            this.txtChckADD.TabIndex = 5;
            this.txtChckADD.TextChanged += new System.EventHandler(this.txtChckADD_TextChanged);
            // 
            // txtChckEmail
            // 
            this.txtChckEmail.Location = new System.Drawing.Point(188, 269);
            this.txtChckEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChckEmail.Name = "txtChckEmail";
            this.txtChckEmail.Size = new System.Drawing.Size(282, 26);
            this.txtChckEmail.TabIndex = 6;
            this.txtChckEmail.TextChanged += new System.EventHandler(this.txtChckEmail_TextChanged);
            // 
            // txtChcknUMBER
            // 
            this.txtChcknUMBER.Location = new System.Drawing.Point(188, 328);
            this.txtChcknUMBER.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChcknUMBER.Name = "txtChcknUMBER";
            this.txtChcknUMBER.Size = new System.Drawing.Size(282, 26);
            this.txtChcknUMBER.TabIndex = 7;
            this.txtChcknUMBER.TextChanged += new System.EventHandler(this.txtChcknUMBER_TextChanged);
            // 
            // dtpstart
            // 
            this.dtpstart.Location = new System.Drawing.Point(159, 403);
            this.dtpstart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(313, 26);
            this.dtpstart.TabIndex = 8;
            // 
            // dtpexpire
            // 
            this.dtpexpire.Location = new System.Drawing.Point(159, 462);
            this.dtpexpire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpexpire.Name = "dtpexpire";
            this.dtpexpire.Size = new System.Drawing.Size(313, 26);
            this.dtpexpire.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "FirstName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email Add";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date Started";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 462);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date Expiry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "LastName";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtChckLN
            // 
            this.txtChckLN.Location = new System.Drawing.Point(188, 148);
            this.txtChckLN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChckLN.Name = "txtChckLN";
            this.txtChckLN.Size = new System.Drawing.Size(282, 26);
            this.txtChckLN.TabIndex = 16;
            this.txtChckLN.TextChanged += new System.EventHandler(this.txtChckLN_TextChanged);
            // 
            // PNLconfirmbooking
            // 
            this.PNLconfirmbooking.Controls.Add(this.panel1);
            this.PNLconfirmbooking.Location = new System.Drawing.Point(18, 92);
            this.PNLconfirmbooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PNLconfirmbooking.Name = "PNLconfirmbooking";
            this.PNLconfirmbooking.Size = new System.Drawing.Size(1138, 628);
            this.PNLconfirmbooking.TabIndex = 17;
            this.PNLconfirmbooking.Paint += new System.Windows.Forms.PaintEventHandler(this.PNLconfirmbooking_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtChckLN);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Book);
            this.panel1.Controls.Add(this.txtChckFN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtChckADD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtChckEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtChcknUMBER);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpstart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpexpire);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(322, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 597);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(348, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fill up Personal Informartion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contact No.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(36, 32);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(112, 51);
            this.btnBooking.TabIndex = 18;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnCheckOUT
            // 
            this.btnCheckOUT.Location = new System.Drawing.Point(194, 32);
            this.btnCheckOUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckOUT.Name = "btnCheckOUT";
            this.btnCheckOUT.Size = new System.Drawing.Size(124, 51);
            this.btnCheckOUT.TabIndex = 19;
            this.btnCheckOUT.Text = "Appointments";
            this.btnCheckOUT.UseVisualStyleBackColor = true;
            this.btnCheckOUT.Click += new System.EventHandler(this.btnCheckOUT_Click);
            // 
            // pnlINSTUCTOR
            // 
            this.pnlINSTUCTOR.BackColor = System.Drawing.Color.SeaShell;
            this.pnlINSTUCTOR.Controls.Add(this.button2);
            this.pnlINSTUCTOR.Controls.Add(this.label17);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKID);
            this.pnlINSTUCTOR.Controls.Add(this.label8);
            this.pnlINSTUCTOR.Controls.Add(this.label10);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKLN);
            this.pnlINSTUCTOR.Controls.Add(this.label11);
            this.pnlINSTUCTOR.Controls.Add(this.label15);
            this.pnlINSTUCTOR.Controls.Add(this.label16);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKContact);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKexpert);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKFN);
            this.pnlINSTUCTOR.Controls.Add(this.dataGridViewBOOKins);
            this.pnlINSTUCTOR.Location = new System.Drawing.Point(18, 97);
            this.pnlINSTUCTOR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlINSTUCTOR.Name = "pnlINSTUCTOR";
            this.pnlINSTUCTOR.Size = new System.Drawing.Size(1132, 628);
            this.pnlINSTUCTOR.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(914, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "Next ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(765, 120);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "ID";
            // 
            // txtBOOKID
            // 
            this.txtBOOKID.Location = new System.Drawing.Point(834, 115);
            this.txtBOOKID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBOOKID.Name = "txtBOOKID";
            this.txtBOOKID.Size = new System.Drawing.Size(282, 26);
            this.txtBOOKID.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(891, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "Instructors";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(712, 363);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Contact No.";
            // 
            // txtBOOKLN
            // 
            this.txtBOOKLN.Location = new System.Drawing.Point(836, 238);
            this.txtBOOKLN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBOOKLN.Name = "txtBOOKLN";
            this.txtBOOKLN.Size = new System.Drawing.Size(282, 26);
            this.txtBOOKLN.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(724, 243);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "LastName";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(732, 302);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Expertise";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(726, 183);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "FirstName";
            // 
            // txtBOOKContact
            // 
            this.txtBOOKContact.Location = new System.Drawing.Point(837, 358);
            this.txtBOOKContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBOOKContact.Name = "txtBOOKContact";
            this.txtBOOKContact.Size = new System.Drawing.Size(282, 26);
            this.txtBOOKContact.TabIndex = 6;
            // 
            // txtBOOKexpert
            // 
            this.txtBOOKexpert.Location = new System.Drawing.Point(837, 295);
            this.txtBOOKexpert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBOOKexpert.Name = "txtBOOKexpert";
            this.txtBOOKexpert.Size = new System.Drawing.Size(282, 26);
            this.txtBOOKexpert.TabIndex = 5;
            // 
            // txtBOOKFN
            // 
            this.txtBOOKFN.Location = new System.Drawing.Point(834, 178);
            this.txtBOOKFN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBOOKFN.Name = "txtBOOKFN";
            this.txtBOOKFN.Size = new System.Drawing.Size(282, 26);
            this.txtBOOKFN.TabIndex = 4;
            // 
            // dataGridViewBOOKins
            // 
            this.dataGridViewBOOKins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOOKins.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewBOOKins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBOOKins.Name = "dataGridViewBOOKins";
            this.dataGridViewBOOKins.RowHeadersWidth = 62;
            this.dataGridViewBOOKins.Size = new System.Drawing.Size(690, 500);
            this.dataGridViewBOOKins.TabIndex = 1;
            this.dataGridViewBOOKins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBOOKins_CellClick_1);
            // 
            // pbclose1
            // 
            this.pbclose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbclose1.Image = global::Final_System.Properties.Resources.close;
            this.pbclose1.Location = new System.Drawing.Point(1155, 8);
            this.pbclose1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbclose1.Name = "pbclose1";
            this.pbclose1.Size = new System.Drawing.Size(36, 32);
            this.pbclose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose1.TabIndex = 21;
            this.pbclose1.TabStop = false;
            this.pbclose1.Click += new System.EventHandler(this.pbclose1_Click);
            this.pbclose1.MouseHover += new System.EventHandler(this.pbclose1_MouseHover);
            // 
            // pbmini1
            // 
            this.pbmini1.Image = global::Final_System.Properties.Resources.minimize_sign;
            this.pbmini1.Location = new System.Drawing.Point(1107, 18);
            this.pbmini1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbmini1.Name = "pbmini1";
            this.pbmini1.Size = new System.Drawing.Size(39, 22);
            this.pbmini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmini1.TabIndex = 22;
            this.pbmini1.TabStop = false;
            // 
            // dgvDone
            // 
            this.dgvDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDone.Location = new System.Drawing.Point(24, 26);
            this.dgvDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDone.Name = "dgvDone";
            this.dgvDone.RowHeadersWidth = 62;
            this.dgvDone.Size = new System.Drawing.Size(1100, 595);
            this.dgvDone.TabIndex = 23;
            this.dgvDone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoneAPPOINTMENT_CellClick);
            this.dgvDone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoneAPPOINTMENT_CellContentClick);
            // 
            // panelDONEappoint
            // 
            this.panelDONEappoint.Controls.Add(this.dgvDone);
            this.panelDONEappoint.Location = new System.Drawing.Point(12, 92);
            this.panelDONEappoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDONEappoint.Name = "panelDONEappoint";
            this.panelDONEappoint.Size = new System.Drawing.Size(1134, 632);
            this.panelDONEappoint.TabIndex = 24;
            this.panelDONEappoint.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 797);
            this.Controls.Add(this.pbmini1);
            this.Controls.Add(this.pbclose1);
            this.Controls.Add(this.btnCheckOUT);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.panelDONEappoint);
            this.Controls.Add(this.PNLconfirmbooking);
            this.Controls.Add(this.pnlINSTUCTOR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserDashboard";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.PNLconfirmbooking.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlINSTUCTOR.ResumeLayout(false);
            this.pnlINSTUCTOR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOOKins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDone)).EndInit();
            this.panelDONEappoint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.TextBox txtChckFN;
        private System.Windows.Forms.TextBox txtChckADD;
        private System.Windows.Forms.TextBox txtChckEmail;
        private System.Windows.Forms.TextBox txtChcknUMBER;
        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.DateTimePicker dtpexpire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChckLN;
        private System.Windows.Forms.ErrorProvider errorProviderCustom1;
        private System.Windows.Forms.Panel PNLconfirmbooking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnCheckOUT;
        private System.Windows.Forms.Panel pnlINSTUCTOR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBOOKLN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBOOKContact;
        private System.Windows.Forms.TextBox txtBOOKexpert;
        private System.Windows.Forms.TextBox txtBOOKFN;
        private System.Windows.Forms.DataGridView dataGridViewBOOKins;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbclose1;
        private System.Windows.Forms.PictureBox pbmini1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBOOKID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvDone;
        private System.Windows.Forms.Panel panelDONEappoint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}