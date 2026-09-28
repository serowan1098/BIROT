namespace WindowsFormsApplication4
{
    partial class Form12
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
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.depbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fnamext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.emailext = new System.Windows.Forms.TextBox();
            this.statusbox = new System.Windows.Forms.ComboBox();
            this.IDext = new System.Windows.Forms.TextBox();
            this.DELBTN = new System.Windows.Forms.Button();
            this.ADDBTN = new System.Windows.Forms.Button();
            this.UPDBTN = new System.Windows.Forms.Button();
            this.NEWBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkRed;
            this.button5.Location = new System.Drawing.Point(96, 578);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 30);
            this.button5.TabIndex = 20;
            this.button5.Text = "Log out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(96, 417);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "Add Teachers";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(96, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "Add Students";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.ST__JOHN_PAUL_II_COLLEGE_OF_DAVAO__9_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1231, 641);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(442, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 259);
            this.panel2.TabIndex = 27;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 21);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(703, 213);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(706, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 40);
            this.label7.TabIndex = 26;
            this.label7.Text = "Teachers\' Data";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.depbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.genderbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Fnamext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addressext);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.emailext);
            this.panel1.Controls.Add(this.statusbox);
            this.panel1.Controls.Add(this.IDext);
            this.panel1.Controls.Add(this.DELBTN);
            this.panel1.Controls.Add(this.ADDBTN);
            this.panel1.Controls.Add(this.UPDBTN);
            this.panel1.Controls.Add(this.NEWBTN);
            this.panel1.Location = new System.Drawing.Point(442, 369);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 252);
            this.panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Department";
            // 
            // depbox
            // 
            this.depbox.Enabled = false;
            this.depbox.FormattingEnabled = true;
            this.depbox.Items.AddRange(new object[] {
            "BSIT",
            "BSN",
            "BSBA",
            "BSED",
            "BSHK",
            "BSHTM",
            "BSCE",
            "BSCJE",
            "SHS"});
            this.depbox.Location = new System.Drawing.Point(150, 157);
            this.depbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depbox.Name = "depbox";
            this.depbox.Size = new System.Drawing.Size(192, 24);
            this.depbox.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Address";
            // 
            // genderbox
            // 
            this.genderbox.Enabled = false;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.genderbox.Location = new System.Drawing.Point(150, 75);
            this.genderbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(192, 24);
            this.genderbox.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Gender";
            // 
            // Fnamext
            // 
            this.Fnamext.Enabled = false;
            this.Fnamext.Location = new System.Drawing.Point(150, 49);
            this.Fnamext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fnamext.Name = "Fnamext";
            this.Fnamext.Size = new System.Drawing.Size(192, 22);
            this.Fnamext.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Full Name";
            // 
            // addressext
            // 
            this.addressext.Enabled = false;
            this.addressext.Location = new System.Drawing.Point(150, 105);
            this.addressext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressext.Name = "addressext";
            this.addressext.Size = new System.Drawing.Size(192, 22);
            this.addressext.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 86;
            this.label10.Text = "Teacher ID Number";
            // 
            // emailext
            // 
            this.emailext.Enabled = false;
            this.emailext.Location = new System.Drawing.Point(150, 131);
            this.emailext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailext.Name = "emailext";
            this.emailext.Size = new System.Drawing.Size(192, 22);
            this.emailext.TabIndex = 83;
            // 
            // statusbox
            // 
            this.statusbox.Enabled = false;
            this.statusbox.FormattingEnabled = true;
            this.statusbox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusbox.Location = new System.Drawing.Point(150, 189);
            this.statusbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(192, 24);
            this.statusbox.TabIndex = 85;
            // 
            // IDext
            // 
            this.IDext.Enabled = false;
            this.IDext.Location = new System.Drawing.Point(150, 20);
            this.IDext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDext.MaxLength = 8;
            this.IDext.Name = "IDext";
            this.IDext.Size = new System.Drawing.Size(192, 22);
            this.IDext.TabIndex = 84;
            this.IDext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDext_KeyPress);
            // 
            // DELBTN
            // 
            this.DELBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.DELBTN.Enabled = false;
            this.DELBTN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DELBTN.Location = new System.Drawing.Point(538, 135);
            this.DELBTN.Margin = new System.Windows.Forms.Padding(4);
            this.DELBTN.Name = "DELBTN";
            this.DELBTN.Size = new System.Drawing.Size(94, 41);
            this.DELBTN.TabIndex = 17;
            this.DELBTN.Text = "DEL";
            this.DELBTN.UseVisualStyleBackColor = false;
            this.DELBTN.Click += new System.EventHandler(this.DELBTN_Click);
            // 
            // ADDBTN
            // 
            this.ADDBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.ADDBTN.Enabled = false;
            this.ADDBTN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ADDBTN.Location = new System.Drawing.Point(538, 86);
            this.ADDBTN.Margin = new System.Windows.Forms.Padding(4);
            this.ADDBTN.Name = "ADDBTN";
            this.ADDBTN.Size = new System.Drawing.Size(94, 41);
            this.ADDBTN.TabIndex = 16;
            this.ADDBTN.Text = "ADD";
            this.ADDBTN.UseVisualStyleBackColor = false;
            this.ADDBTN.Click += new System.EventHandler(this.ADDBTN_Click);
            // 
            // UPDBTN
            // 
            this.UPDBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.UPDBTN.Enabled = false;
            this.UPDBTN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UPDBTN.Location = new System.Drawing.Point(436, 135);
            this.UPDBTN.Margin = new System.Windows.Forms.Padding(4);
            this.UPDBTN.Name = "UPDBTN";
            this.UPDBTN.Size = new System.Drawing.Size(94, 41);
            this.UPDBTN.TabIndex = 15;
            this.UPDBTN.Text = "UPD";
            this.UPDBTN.UseVisualStyleBackColor = false;
            this.UPDBTN.Click += new System.EventHandler(this.UPDBTN_Click);
            // 
            // NEWBTN
            // 
            this.NEWBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.NEWBTN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NEWBTN.Location = new System.Drawing.Point(436, 86);
            this.NEWBTN.Margin = new System.Windows.Forms.Padding(4);
            this.NEWBTN.Name = "NEWBTN";
            this.NEWBTN.Size = new System.Drawing.Size(94, 41);
            this.NEWBTN.TabIndex = 14;
            this.NEWBTN.Text = "NEW";
            this.NEWBTN.UseVisualStyleBackColor = false;
            this.NEWBTN.Click += new System.EventHandler(this.NEWBTN_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form13";
            this.Text = "Form13";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DELBTN;
        private System.Windows.Forms.Button ADDBTN;
        private System.Windows.Forms.Button UPDBTN;
        private System.Windows.Forms.Button NEWBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox depbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fnamext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailext;
        private System.Windows.Forms.ComboBox statusbox;
        private System.Windows.Forms.TextBox IDext;
    }
}