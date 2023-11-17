namespace Final_System
{
    partial class Login_form
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbmini1 = new System.Windows.Forms.PictureBox();
            this.pbclose1 = new System.Windows.Forms.PictureBox();
            this.pbmini = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(49, 105);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 18);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(49, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log in ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(49, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 18);
            this.textBox1.TabIndex = 6;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.White;
            this.btn_register.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_register.Location = new System.Drawing.Point(49, 194);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(169, 26);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Create Account";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Forgot Password?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(285, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 255);
            this.panel1.TabIndex = 1;
            // 
            // pbmini1
            // 
            this.pbmini1.Image = global::Final_System.Properties.Resources.minimize_sign;
            this.pbmini1.Location = new System.Drawing.Point(742, 14);
            this.pbmini1.Name = "pbmini1";
            this.pbmini1.Size = new System.Drawing.Size(26, 16);
            this.pbmini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmini1.TabIndex = 5;
            this.pbmini1.TabStop = false;
            // 
            // pbclose1
            // 
            this.pbclose1.Image = global::Final_System.Properties.Resources.close;
            this.pbclose1.Location = new System.Drawing.Point(777, 7);
            this.pbclose1.Name = "pbclose1";
            this.pbclose1.Size = new System.Drawing.Size(24, 21);
            this.pbclose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose1.TabIndex = 4;
            this.pbclose1.TabStop = false;
            this.pbclose1.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pbmini
            // 
            this.pbmini.Image = global::Final_System.Properties.Resources.square;
            this.pbmini.Location = new System.Drawing.Point(740, 4);
            this.pbmini.Name = "pbmini";
            this.pbmini.Size = new System.Drawing.Size(30, 26);
            this.pbmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmini.TabIndex = 3;
            this.pbmini.TabStop = false;
            // 
            // pbclose
            // 
            this.pbclose.Image = global::Final_System.Properties.Resources.square;
            this.pbclose.Location = new System.Drawing.Point(773, 4);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(30, 26);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 2;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_System.Properties.Resources.final_gym;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.pbmini1);
            this.Controls.Add(this.pbclose1);
            this.Controls.Add(this.pbmini);
            this.Controls.Add(this.pbclose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_form";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.PictureBox pbmini;
        private System.Windows.Forms.PictureBox pbclose1;
        private System.Windows.Forms.PictureBox pbmini1;
    }
}

