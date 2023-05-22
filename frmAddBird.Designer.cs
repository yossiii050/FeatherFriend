namespace BirdManagment
{
    partial class frmAddBird
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
            this.serial = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.add_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxMom = new System.Windows.Forms.ComboBox();
            this.comboBoxDad = new System.Windows.Forms.ComboBox();
            this.comboBoxSpec = new System.Windows.Forms.ComboBox();
            this.comboBoxSubSpec = new System.Windows.Forms.ComboBox();
            this.comboBoxGend = new System.Windows.Forms.ComboBox();
            this.comboBoxCage = new System.Windows.Forms.ComboBox();
            this.labelHeadcolor = new System.Windows.Forms.Label();
            this.headcolorBird = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.breastcolorBird = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bodycolorBird = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.AcceptsTab = true;
            this.serial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.serial.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serial.Location = new System.Drawing.Point(189, 65);
            this.serial.Margin = new System.Windows.Forms.Padding(4);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(160, 26);
            this.serial.TabIndex = 0;
            this.serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "d";
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 282);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 15, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(310, 373);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 28);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(484, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mom ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(484, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cage No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(51, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sub Species";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(51, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Species";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(51, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID No.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(484, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dad ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(51, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(51, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Hatch date";
            // 
            // comboBoxMom
            // 
            this.comboBoxMom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxMom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxMom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMom.FormattingEnabled = true;
            this.comboBoxMom.Location = new System.Drawing.Point(593, 117);
            this.comboBoxMom.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMom.Name = "comboBoxMom";
            this.comboBoxMom.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMom.TabIndex = 22;
            // 
            // comboBoxDad
            // 
            this.comboBoxDad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxDad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDad.FormattingEnabled = true;
            this.comboBoxDad.Location = new System.Drawing.Point(593, 165);
            this.comboBoxDad.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDad.Name = "comboBoxDad";
            this.comboBoxDad.Size = new System.Drawing.Size(160, 24);
            this.comboBoxDad.TabIndex = 23;
            // 
            // comboBoxSpec
            // 
            this.comboBoxSpec.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxSpec.FormattingEnabled = true;
            this.comboBoxSpec.Items.AddRange(new object[] {
            "American Gouldian",
            "European Gouldian",
            "Australian Gouldian"});
            this.comboBoxSpec.Location = new System.Drawing.Point(189, 113);
            this.comboBoxSpec.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSpec.Name = "comboBoxSpec";
            this.comboBoxSpec.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSpec.TabIndex = 24;
            this.comboBoxSpec.Text = "American Gouldian";
            this.comboBoxSpec.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpec_SelectedIndexChanged);
            // 
            // comboBoxSubSpec
            // 
            this.comboBoxSubSpec.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxSubSpec.FormattingEnabled = true;
            this.comboBoxSubSpec.Items.AddRange(new object[] {
            "North America",
            "Central America",
            "South America"});
            this.comboBoxSubSpec.Location = new System.Drawing.Point(189, 172);
            this.comboBoxSubSpec.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSubSpec.Name = "comboBoxSubSpec";
            this.comboBoxSubSpec.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSubSpec.TabIndex = 25;
            this.comboBoxSubSpec.Text = "North America";
            // 
            // comboBoxGend
            // 
            this.comboBoxGend.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxGend.FormattingEnabled = true;
            this.comboBoxGend.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGend.Location = new System.Drawing.Point(189, 224);
            this.comboBoxGend.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGend.Name = "comboBoxGend";
            this.comboBoxGend.Size = new System.Drawing.Size(160, 24);
            this.comboBoxGend.TabIndex = 26;
            this.comboBoxGend.Text = "Male";
            // 
            // comboBoxCage
            // 
            this.comboBoxCage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxCage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCage.FormattingEnabled = true;
            this.comboBoxCage.Location = new System.Drawing.Point(593, 64);
            this.comboBoxCage.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCage.Name = "comboBoxCage";
            this.comboBoxCage.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCage.TabIndex = 27;
            // 
            // labelHeadcolor
            // 
            this.labelHeadcolor.AutoSize = true;
            this.labelHeadcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadcolor.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelHeadcolor.Location = new System.Drawing.Point(503, 332);
            this.labelHeadcolor.Name = "labelHeadcolor";
            this.labelHeadcolor.Size = new System.Drawing.Size(111, 25);
            this.labelHeadcolor.TabIndex = 29;
            this.labelHeadcolor.Text = "Head Color";
            // 
            // headcolorBird
            // 
            this.headcolorBird.AcceptsTab = true;
            this.headcolorBird.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.headcolorBird.Enabled = false;
            this.headcolorBird.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headcolorBird.Location = new System.Drawing.Point(639, 330);
            this.headcolorBird.Margin = new System.Windows.Forms.Padding(4);
            this.headcolorBird.Name = "headcolorBird";
            this.headcolorBird.Size = new System.Drawing.Size(92, 26);
            this.headcolorBird.TabIndex = 28;
            this.headcolorBird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(607, 225);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 81);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(503, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Breast Color";
            // 
            // breastcolorBird
            // 
            this.breastcolorBird.AcceptsTab = true;
            this.breastcolorBird.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.breastcolorBird.Enabled = false;
            this.breastcolorBird.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breastcolorBird.Location = new System.Drawing.Point(639, 364);
            this.breastcolorBird.Margin = new System.Windows.Forms.Padding(4);
            this.breastcolorBird.Name = "breastcolorBird";
            this.breastcolorBird.Size = new System.Drawing.Size(92, 26);
            this.breastcolorBird.TabIndex = 31;
            this.breastcolorBird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.breastcolorBird.TextChanged += new System.EventHandler(this.breastcolorBird_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Location = new System.Drawing.Point(503, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Body Color";
            // 
            // bodycolorBird
            // 
            this.bodycolorBird.AcceptsTab = true;
            this.bodycolorBird.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bodycolorBird.Enabled = false;
            this.bodycolorBird.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodycolorBird.Location = new System.Drawing.Point(639, 399);
            this.bodycolorBird.Margin = new System.Windows.Forms.Padding(4);
            this.bodycolorBird.Name = "bodycolorBird";
            this.bodycolorBird.Size = new System.Drawing.Size(92, 26);
            this.bodycolorBird.TabIndex = 33;
            this.bodycolorBird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAddBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(904, 490);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bodycolorBird);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.breastcolorBird);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHeadcolor);
            this.Controls.Add(this.headcolorBird);
            this.Controls.Add(this.comboBoxCage);
            this.Controls.Add(this.comboBoxGend);
            this.Controls.Add(this.comboBoxSubSpec);
            this.Controls.Add(this.comboBoxSpec);
            this.Controls.Add(this.comboBoxDad);
            this.Controls.Add(this.comboBoxMom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.serial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddBird";
            this.Text = "frmAddBird";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serial;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMom;
        private System.Windows.Forms.ComboBox comboBoxDad;
        private System.Windows.Forms.ComboBox comboBoxGend;
        private System.Windows.Forms.ComboBox comboBoxCage;
        private System.Windows.Forms.Label labelHeadcolor;
        private System.Windows.Forms.TextBox headcolorBird;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox breastcolorBird;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bodycolorBird;
        public System.Windows.Forms.ComboBox comboBoxSpec;
        public System.Windows.Forms.ComboBox comboBoxSubSpec;
    }
}