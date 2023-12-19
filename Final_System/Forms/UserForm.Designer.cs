namespace Final_System.Forms
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.PNLCHECKOUT = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblexp = new System.Windows.Forms.Label();
            this.lblln = new System.Windows.Forms.Label();
            this.lblfn = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCheckOUT = new System.Windows.Forms.Button();
            this.pnlINSTUCTOR = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBOOKLN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBOOKContact = new System.Windows.Forms.TextBox();
            this.txtBOOKexpert = new System.Windows.Forms.TextBox();
            this.txtBOOKFN = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewBOOKins = new System.Windows.Forms.DataGridView();
            this.pbclose1 = new System.Windows.Forms.PictureBox();
            this.pbmini1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtBOOKID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.PNLCHECKOUT.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlINSTUCTOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOOKins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(438, 325);
            this.dataGridView2.TabIndex = 1;
            // 
            // Book
            // 
            this.Book.Location = new System.Drawing.Point(566, 333);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(121, 31);
            this.Book.TabIndex = 2;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = true;
         
            // 
            // txtChckFN
            // 
            this.txtChckFN.Location = new System.Drawing.Point(554, 52);
            this.txtChckFN.Name = "txtChckFN";
            this.txtChckFN.Size = new System.Drawing.Size(189, 20);
            this.txtChckFN.TabIndex = 4;
            this.txtChckFN.TextChanged += new System.EventHandler(this.txtChckFN_TextChanged);
            // 
            // txtChckADD
            // 
            this.txtChckADD.Location = new System.Drawing.Point(555, 130);
            this.txtChckADD.Name = "txtChckADD";
            this.txtChckADD.Size = new System.Drawing.Size(189, 20);
            this.txtChckADD.TabIndex = 5;
            // 
            // txtChckEmail
            // 
            this.txtChckEmail.Location = new System.Drawing.Point(555, 171);
            this.txtChckEmail.Name = "txtChckEmail";
            this.txtChckEmail.Size = new System.Drawing.Size(189, 20);
            this.txtChckEmail.TabIndex = 6;
            // 
            // txtChcknUMBER
            // 
            this.txtChcknUMBER.Location = new System.Drawing.Point(555, 209);
            this.txtChcknUMBER.Name = "txtChcknUMBER";
            this.txtChcknUMBER.Size = new System.Drawing.Size(189, 20);
            this.txtChcknUMBER.TabIndex = 7;
            this.txtChcknUMBER.TextChanged += new System.EventHandler(this.txtChcknUMBER_TextChanged);
            // 
            // dtpstart
            // 
            this.dtpstart.Location = new System.Drawing.Point(536, 258);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(210, 20);
            this.dtpstart.TabIndex = 8;
            // 
            // dtpexpire
            // 
            this.dtpexpire.Location = new System.Drawing.Point(536, 296);
            this.dtpexpire.Name = "dtpexpire";
            this.dtpexpire.Size = new System.Drawing.Size(210, 20);
            this.dtpexpire.TabIndex = 9;
            this.dtpexpire.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email Add";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date Started";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date Expiry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "LastName";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtChckLN
            // 
            this.txtChckLN.Location = new System.Drawing.Point(555, 92);
            this.txtChckLN.Name = "txtChckLN";
            this.txtChckLN.Size = new System.Drawing.Size(189, 20);
            this.txtChckLN.TabIndex = 16;
            // 
            // PNLCHECKOUT
            // 
            this.PNLCHECKOUT.Controls.Add(this.panel3);
            this.PNLCHECKOUT.Controls.Add(this.label7);
            this.PNLCHECKOUT.Controls.Add(this.txtChckLN);
            this.PNLCHECKOUT.Controls.Add(this.label6);
            this.PNLCHECKOUT.Controls.Add(this.label5);
            this.PNLCHECKOUT.Controls.Add(this.label4);
            this.PNLCHECKOUT.Controls.Add(this.label3);
            this.PNLCHECKOUT.Controls.Add(this.label2);
            this.PNLCHECKOUT.Controls.Add(this.label1);
            this.PNLCHECKOUT.Controls.Add(this.dtpexpire);
            this.PNLCHECKOUT.Controls.Add(this.dtpstart);
            this.PNLCHECKOUT.Controls.Add(this.txtChcknUMBER);
            this.PNLCHECKOUT.Controls.Add(this.txtChckEmail);
            this.PNLCHECKOUT.Controls.Add(this.txtChckADD);
            this.PNLCHECKOUT.Controls.Add(this.txtChckFN);
            this.PNLCHECKOUT.Controls.Add(this.Book);
            this.PNLCHECKOUT.Controls.Add(this.dataGridView2);
            this.PNLCHECKOUT.Location = new System.Drawing.Point(12, 60);
            this.PNLCHECKOUT.Name = "PNLCHECKOUT";
            this.PNLCHECKOUT.Size = new System.Drawing.Size(759, 408);
            this.PNLCHECKOUT.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblnum);
            this.panel3.Controls.Add(this.lblexp);
            this.panel3.Controls.Add(this.lblln);
            this.panel3.Controls.Add(this.lblfn);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(30, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 49);
            this.panel3.TabIndex = 22;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(310, 28);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(37, 13);
            this.lblnum.TabIndex = 7;
            this.lblnum.Text = "lblnum";
           
            // 
            // lblexp
            // 
            this.lblexp.AutoSize = true;
            this.lblexp.Location = new System.Drawing.Point(220, 28);
            this.lblexp.Name = "lblexp";
            this.lblexp.Size = new System.Drawing.Size(41, 13);
            this.lblexp.TabIndex = 6;
            this.lblexp.Text = "label19";
            // 
            // lblln
            // 
            this.lblln.AutoSize = true;
            this.lblln.Location = new System.Drawing.Point(111, 31);
            this.lblln.Name = "lblln";
            this.lblln.Size = new System.Drawing.Size(41, 13);
            this.lblln.TabIndex = 5;
            this.lblln.Text = "label18";
            // 
            // lblfn
            // 
            this.lblfn.AutoSize = true;
            this.lblfn.Location = new System.Drawing.Point(19, 28);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(26, 13);
            this.lblfn.TabIndex = 4;
            this.lblfn.Text = "lblfn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(310, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Contact No.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Expertise";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contact No.";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(24, 21);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(75, 33);
            this.btnBooking.TabIndex = 18;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnCheckOUT
            // 
            this.btnCheckOUT.Location = new System.Drawing.Point(129, 21);
            this.btnCheckOUT.Name = "btnCheckOUT";
            this.btnCheckOUT.Size = new System.Drawing.Size(83, 33);
            this.btnCheckOUT.TabIndex = 19;
            this.btnCheckOUT.Text = "Check Out";
            this.btnCheckOUT.UseVisualStyleBackColor = true;
            this.btnCheckOUT.Click += new System.EventHandler(this.btnCheckOUT_Click);
            // 
            // pnlINSTUCTOR
            // 
            this.pnlINSTUCTOR.BackColor = System.Drawing.Color.SeaShell;
            this.pnlINSTUCTOR.Controls.Add(this.label17);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKID);
            this.pnlINSTUCTOR.Controls.Add(this.button1);
            this.pnlINSTUCTOR.Controls.Add(this.label8);
            this.pnlINSTUCTOR.Controls.Add(this.label10);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKLN);
            this.pnlINSTUCTOR.Controls.Add(this.label11);
            this.pnlINSTUCTOR.Controls.Add(this.label15);
            this.pnlINSTUCTOR.Controls.Add(this.label16);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKContact);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKexpert);
            this.pnlINSTUCTOR.Controls.Add(this.txtBOOKFN);
            this.pnlINSTUCTOR.Controls.Add(this.button3);
            this.pnlINSTUCTOR.Controls.Add(this.dataGridViewBOOKins);
            this.pnlINSTUCTOR.Location = new System.Drawing.Point(12, 60);
            this.pnlINSTUCTOR.Name = "pnlINSTUCTOR";
            this.pnlINSTUCTOR.Size = new System.Drawing.Size(759, 408);
            this.pnlINSTUCTOR.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(583, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Instructors";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Contact No.";
            // 
            // txtBOOKLN
            // 
            this.txtBOOKLN.Location = new System.Drawing.Point(557, 155);
            this.txtBOOKLN.Name = "txtBOOKLN";
            this.txtBOOKLN.Size = new System.Drawing.Size(189, 20);
            this.txtBOOKLN.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "LastName";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(488, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Expertise";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(484, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "FirstName";
            // 
            // txtBOOKContact
            // 
            this.txtBOOKContact.Location = new System.Drawing.Point(558, 233);
            this.txtBOOKContact.Name = "txtBOOKContact";
            this.txtBOOKContact.Size = new System.Drawing.Size(189, 20);
            this.txtBOOKContact.TabIndex = 6;
            // 
            // txtBOOKexpert
            // 
            this.txtBOOKexpert.Location = new System.Drawing.Point(558, 192);
            this.txtBOOKexpert.Name = "txtBOOKexpert";
            this.txtBOOKexpert.Size = new System.Drawing.Size(189, 20);
            this.txtBOOKexpert.TabIndex = 5;
            // 
            // txtBOOKFN
            // 
            this.txtBOOKFN.Location = new System.Drawing.Point(556, 116);
            this.txtBOOKFN.Name = "txtBOOKFN";
            this.txtBOOKFN.Size = new System.Drawing.Size(189, 20);
            this.txtBOOKFN.TabIndex = 4;
            this.txtBOOKFN.TextChanged += new System.EventHandler(this.txtBOOKFN_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(439, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Book Now";
            this.button3.UseVisualStyleBackColor = true;
        
            // 
            // dataGridViewBOOKins
            // 
            this.dataGridViewBOOKins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOOKins.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewBOOKins.Name = "dataGridViewBOOKins";
            this.dataGridViewBOOKins.Size = new System.Drawing.Size(438, 325);
            this.dataGridViewBOOKins.TabIndex = 1;
            this.dataGridViewBOOKins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBOOKins_CellClick_1);
            // 
            // pbclose1
            // 
            this.pbclose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbclose1.Image = global::Final_System.Properties.Resources.close;
            this.pbclose1.Location = new System.Drawing.Point(770, 5);
            this.pbclose1.Name = "pbclose1";
            this.pbclose1.Size = new System.Drawing.Size(24, 21);
            this.pbclose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose1.TabIndex = 21;
            this.pbclose1.TabStop = false;
            this.pbclose1.Click += new System.EventHandler(this.pbclose1_Click);
            this.pbclose1.MouseHover += new System.EventHandler(this.pbclose1_MouseHover);
            // 
            // pbmini1
            // 
            this.pbmini1.Image = global::Final_System.Properties.Resources.minimize_sign;
            this.pbmini1.Location = new System.Drawing.Point(738, 12);
            this.pbmini1.Name = "pbmini1";
            this.pbmini1.Size = new System.Drawing.Size(26, 14);
            this.pbmini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmini1.TabIndex = 22;
            this.pbmini1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBOOKID
            // 
            this.txtBOOKID.Location = new System.Drawing.Point(558, 88);
            this.txtBOOKID.Name = "txtBOOKID";
            this.txtBOOKID.Size = new System.Drawing.Size(189, 20);
            this.txtBOOKID.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(510, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "ID";
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.pbmini1);
            this.Controls.Add(this.pbclose1);
            this.Controls.Add(this.btnCheckOUT);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.pnlINSTUCTOR);
            this.Controls.Add(this.PNLCHECKOUT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.PNLCHECKOUT.ResumeLayout(false);
            this.PNLCHECKOUT.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlINSTUCTOR.ResumeLayout(false);
            this.pnlINSTUCTOR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOOKins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.Panel PNLCHECKOUT;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewBOOKins;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblexp;
        private System.Windows.Forms.Label lblln;
        private System.Windows.Forms.Label lblfn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbclose1;
        private System.Windows.Forms.PictureBox pbmini1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBOOKID;
    }
}