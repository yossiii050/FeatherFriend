namespace BirdManagment
{
    partial class Register
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
            this.Reg = new System.Windows.Forms.Button();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reg
            // 
            this.Reg.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Reg.Location = new System.Drawing.Point(426, 349);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(148, 75);
            this.Reg.TabIndex = 12;
            this.Reg.Text = "Register";
            this.Reg.UseVisualStyleBackColor = true;
            // 
            // PassTxt
            // 
            this.PassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PassTxt.Location = new System.Drawing.Point(492, 219);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(177, 36);
            this.PassTxt.TabIndex = 10;
            this.PassTxt.UseSystemPasswordChar = true;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UsernameTxt.Location = new System.Drawing.Point(492, 177);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(177, 36);
            this.UsernameTxt.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Password.Location = new System.Drawing.Point(306, 219);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(147, 36);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Username.Location = new System.Drawing.Point(303, 175);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(150, 36);
            this.Username.TabIndex = 9;
            this.Username.Text = "Username";
            // 
            // IDTxt
            // 
            this.IDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IDTxt.Location = new System.Drawing.Point(492, 261);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(177, 36);
            this.IDTxt.TabIndex = 14;
            this.IDTxt.UseSystemPasswordChar = true;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID.Location = new System.Drawing.Point(306, 261);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(44, 36);
            this.ID.TabIndex = 13;
            this.ID.Text = "ID";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 546);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Label ID;
    }
}