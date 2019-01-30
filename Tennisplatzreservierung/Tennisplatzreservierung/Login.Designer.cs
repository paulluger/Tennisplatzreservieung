namespace Tennisplatzreservierung
{
    partial class Login
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
            this.tbx_login_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.btn_login_register = new System.Windows.Forms.Button();
            this.mtbx_login_password = new System.Windows.Forms.MaskedTextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_login_email
            // 
            this.tbx_login_email.Location = new System.Drawing.Point(138, 55);
            this.tbx_login_email.Name = "tbx_login_email";
            this.tbx_login_email.Size = new System.Drawing.Size(230, 20);
            this.tbx_login_email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btn_login_login
            // 
            this.btn_login_login.Location = new System.Drawing.Point(116, 136);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(190, 44);
            this.btn_login_login.TabIndex = 4;
            this.btn_login_login.Text = "Login";
            this.btn_login_login.UseVisualStyleBackColor = true;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_login_register
            // 
            this.btn_login_register.Location = new System.Drawing.Point(317, 217);
            this.btn_login_register.Name = "btn_login_register";
            this.btn_login_register.Size = new System.Drawing.Size(75, 23);
            this.btn_login_register.TabIndex = 5;
            this.btn_login_register.Text = "Registrieren";
            this.btn_login_register.UseVisualStyleBackColor = true;
            this.btn_login_register.Click += new System.EventHandler(this.btn_login_register_Click);
            // 
            // mtbx_login_password
            // 
            this.mtbx_login_password.Location = new System.Drawing.Point(138, 90);
            this.mtbx_login_password.Name = "mtbx_login_password";
            this.mtbx_login_password.PasswordChar = '*';
            this.mtbx_login_password.Size = new System.Drawing.Size(230, 20);
            this.mtbx_login_password.TabIndex = 1;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(39, 200);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(0, 13);
            this.lbl_output.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 263);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login_register);
            this.Controls.Add(this.tbx_login_email);
            this.Controls.Add(this.mtbx_login_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_login_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_login_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login_login;
        private System.Windows.Forms.Button btn_login_register;
        private System.Windows.Forms.MaskedTextBox mtbx_login_password;
        private System.Windows.Forms.Label lbl_output;
    }
}