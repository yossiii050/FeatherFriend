namespace BirdManagment
{
    partial class StartPage
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
            this.REGISTER = new System.Windows.Forms.Button();
            this.LOGIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // REGISTER
            // 
            this.REGISTER.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.REGISTER.Location = new System.Drawing.Point(12, 459);
            this.REGISTER.Name = "REGISTER";
            this.REGISTER.Size = new System.Drawing.Size(148, 75);
            this.REGISTER.TabIndex = 6;
            this.REGISTER.Text = "REGISTER";
            this.REGISTER.UseVisualStyleBackColor = true;
            this.REGISTER.Click += new System.EventHandler(this.REGISTER_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LOGIN.Location = new System.Drawing.Point(812, 459);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(148, 75);
            this.LOGIN.TabIndex = 7;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BirdManagment.Properties.Resources.LOGO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(972, 546);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.REGISTER);
            this.DoubleBuffered = true;
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button REGISTER;
        private System.Windows.Forms.Button LOGIN;
    }
}