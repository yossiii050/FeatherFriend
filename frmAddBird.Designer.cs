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
            this.gender = new System.Windows.Forms.TextBox();
            this.cage_no = new System.Windows.Forms.TextBox();
            this.species = new System.Windows.Forms.TextBox();
            this.sub_species = new System.Windows.Forms.TextBox();
            this.dad_serial = new System.Windows.Forms.TextBox();
            this.mom_serial = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.AcceptsTab = true;
            this.serial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.serial.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serial.Location = new System.Drawing.Point(231, 91);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(100, 22);
            this.serial.TabIndex = 0;
            this.serial.Text = "Serial No.";
            this.serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gender
            // 
            this.gender.AcceptsTab = true;
            this.gender.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gender.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(282, 176);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 22);
            this.gender.TabIndex = 3;
            this.gender.Text = "Gender";
            this.gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cage_no
            // 
            this.cage_no.AcceptsTab = true;
            this.cage_no.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cage_no.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cage_no.Location = new System.Drawing.Point(176, 176);
            this.cage_no.Name = "cage_no";
            this.cage_no.Size = new System.Drawing.Size(100, 22);
            this.cage_no.TabIndex = 4;
            this.cage_no.Text = "Cage No.";
            this.cage_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // species
            // 
            this.species.AcceptsTab = true;
            this.species.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.species.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.species.Location = new System.Drawing.Point(282, 132);
            this.species.Name = "species";
            this.species.Size = new System.Drawing.Size(100, 22);
            this.species.TabIndex = 1;
            this.species.Text = "Species";
            this.species.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sub_species
            // 
            this.sub_species.AcceptsTab = true;
            this.sub_species.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sub_species.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_species.Location = new System.Drawing.Point(176, 132);
            this.sub_species.Name = "sub_species";
            this.sub_species.Size = new System.Drawing.Size(100, 22);
            this.sub_species.TabIndex = 2;
            this.sub_species.Text = "Sub Species";
            this.sub_species.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dad_serial
            // 
            this.dad_serial.AcceptsTab = true;
            this.dad_serial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dad_serial.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dad_serial.Location = new System.Drawing.Point(282, 218);
            this.dad_serial.Name = "dad_serial";
            this.dad_serial.Size = new System.Drawing.Size(100, 22);
            this.dad_serial.TabIndex = 5;
            this.dad_serial.Text = "Dad Serial No.";
            this.dad_serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mom_serial
            // 
            this.mom_serial.AcceptsTab = true;
            this.mom_serial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mom_serial.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mom_serial.Location = new System.Drawing.Point(176, 218);
            this.mom_serial.Name = "mom_serial";
            this.mom_serial.Size = new System.Drawing.Size(100, 22);
            this.mom_serial.TabIndex = 6;
            this.mom_serial.Text = "Mom Serial No.";
            this.mom_serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(107, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hatch date";
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(242, 306);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // frmAddBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(585, 398);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mom_serial);
            this.Controls.Add(this.dad_serial);
            this.Controls.Add(this.sub_species);
            this.Controls.Add(this.species);
            this.Controls.Add(this.cage_no);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.serial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddBird";
            this.Text = "frmAddBird";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serial;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox cage_no;
        private System.Windows.Forms.TextBox species;
        private System.Windows.Forms.TextBox sub_species;
        private System.Windows.Forms.TextBox dad_serial;
        private System.Windows.Forms.TextBox mom_serial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
    }
}