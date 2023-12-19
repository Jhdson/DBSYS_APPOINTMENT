namespace Final_System.Forms
{
    partial class Staff_Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhoneCONF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailCONF = new System.Windows.Forms.TextBox();
            this.txtADDresCONF = new System.Windows.Forms.TextBox();
            this.txtMidCONF = new System.Windows.Forms.TextBox();
            this.txtLnCONF = new System.Windows.Forms.TextBox();
            this.txtfnCONF = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datagridBOOKING = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pbclose1 = new System.Windows.Forms.PictureBox();
            this.pbmini1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.txtIDCONF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBOOKING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtIDCONF);
            this.panel1.Controls.Add(this.txtPhoneCONF);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmailCONF);
            this.panel1.Controls.Add(this.txtADDresCONF);
            this.panel1.Controls.Add(this.txtMidCONF);
            this.panel1.Controls.Add(this.txtLnCONF);
            this.panel1.Controls.Add(this.txtfnCONF);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.datagridBOOKING);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 428);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtPhoneCONF
            // 
            this.txtPhoneCONF.Location = new System.Drawing.Point(599, 244);
            this.txtPhoneCONF.Name = "txtPhoneCONF";
            this.txtPhoneCONF.Size = new System.Drawing.Size(175, 20);
            this.txtPhoneCONF.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email Add";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middle Initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // txtEmailCONF
            // 
            this.txtEmailCONF.Location = new System.Drawing.Point(599, 210);
            this.txtEmailCONF.Name = "txtEmailCONF";
            this.txtEmailCONF.Size = new System.Drawing.Size(175, 20);
            this.txtEmailCONF.TabIndex = 6;
            this.txtEmailCONF.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtADDresCONF
            // 
            this.txtADDresCONF.Location = new System.Drawing.Point(599, 174);
            this.txtADDresCONF.Name = "txtADDresCONF";
            this.txtADDresCONF.Size = new System.Drawing.Size(175, 20);
            this.txtADDresCONF.TabIndex = 5;
            // 
            // txtMidCONF
            // 
            this.txtMidCONF.Location = new System.Drawing.Point(599, 138);
            this.txtMidCONF.Name = "txtMidCONF";
            this.txtMidCONF.Size = new System.Drawing.Size(175, 20);
            this.txtMidCONF.TabIndex = 4;
            // 
            // txtLnCONF
            // 
            this.txtLnCONF.Location = new System.Drawing.Point(599, 102);
            this.txtLnCONF.Name = "txtLnCONF";
            this.txtLnCONF.Size = new System.Drawing.Size(175, 20);
            this.txtLnCONF.TabIndex = 3;
            // 
            // txtfnCONF
            // 
            this.txtfnCONF.Location = new System.Drawing.Point(599, 66);
            this.txtfnCONF.Name = "txtfnCONF";
            this.txtfnCONF.Size = new System.Drawing.Size(175, 20);
            this.txtfnCONF.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(515, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 67);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reject";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // datagridBOOKING
            // 
            this.datagridBOOKING.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBOOKING.Location = new System.Drawing.Point(12, 18);
            this.datagridBOOKING.Name = "datagridBOOKING";
            this.datagridBOOKING.Size = new System.Drawing.Size(495, 390);
            this.datagridBOOKING.TabIndex = 0;
            this.datagridBOOKING.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridBOOKING_CellClick);
            this.datagridBOOKING.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbclose1
            // 
            this.pbclose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbclose1.Image = global::Final_System.Properties.Resources.close;
            this.pbclose1.Location = new System.Drawing.Point(770, 5);
            this.pbclose1.Name = "pbclose1";
            this.pbclose1.Size = new System.Drawing.Size(24, 21);
            this.pbclose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose1.TabIndex = 5;
            this.pbclose1.TabStop = false;
            this.pbclose1.Click += new System.EventHandler(this.pbclose1_Click);
            this.pbclose1.MouseHover += new System.EventHandler(this.pbclose1_Click);
            // 
            // pbmini1
            // 
            this.pbmini1.Image = global::Final_System.Properties.Resources.minimize_sign;
            this.pbmini1.Location = new System.Drawing.Point(738, 12);
            this.pbmini1.Name = "pbmini1";
            this.pbmini1.Size = new System.Drawing.Size(26, 14);
            this.pbmini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmini1.TabIndex = 6;
            this.pbmini1.TabStop = false;
            this.pbmini1.Click += new System.EventHandler(this.pbclose2_Click);
            this.pbmini1.MouseHover += new System.EventHandler(this.pbclose2_Click);
            // 
            // txtIDCONF
            // 
            this.txtIDCONF.Location = new System.Drawing.Point(599, 33);
            this.txtIDCONF.Name = "txtIDCONF";
            this.txtIDCONF.Size = new System.Drawing.Size(175, 20);
            this.txtIDCONF.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID";
            // 
            // Staff_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.pbmini1);
            this.Controls.Add(this.pbclose1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_Dashboard";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridBOOKING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datagridBOOKING;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbclose1;
        private System.Windows.Forms.PictureBox pbmini1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox txtEmailCONF;
        private System.Windows.Forms.TextBox txtADDresCONF;
        private System.Windows.Forms.TextBox txtMidCONF;
        private System.Windows.Forms.TextBox txtLnCONF;
        private System.Windows.Forms.TextBox txtfnCONF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneCONF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDCONF;
    }
}