namespace LoginRegistrer
{
    partial class RegisterForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textForename = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(78, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "COMPANY NAME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(16, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "USERNAME:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(13, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "PASSWORD:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "FULL NAME:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textForename
            // 
            this.textForename.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.textForename.ForeColor = System.Drawing.Color.Gray;
            this.textForename.Location = new System.Drawing.Point(174, 107);
            this.textForename.Multiline = true;
            this.textForename.Name = "textForename";
            this.textForename.Size = new System.Drawing.Size(201, 30);
            this.textForename.TabIndex = 200;
            this.textForename.Text = "Forename";
            this.textForename.TextChanged += new System.EventHandler(this.textForename_TextChanged);
            this.textForename.Enter += new System.EventHandler(this.TextForename_Enter);
            this.textForename.Leave += new System.EventHandler(this.textForename_Leave);
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.textUsername.ForeColor = System.Drawing.Color.Gray;
            this.textUsername.Location = new System.Drawing.Point(175, 179);
            this.textUsername.Multiline = true;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(415, 30);
            this.textUsername.TabIndex = 203;
            this.textUsername.Text = "Preferred username";
            this.textUsername.Enter += new System.EventHandler(this.textUsername_Enter);
            this.textUsername.Leave += new System.EventHandler(this.textUsername_Leave);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.textPassword.ForeColor = System.Drawing.Color.Gray;
            this.textPassword.Location = new System.Drawing.Point(175, 215);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(415, 30);
            this.textPassword.TabIndex = 204;
            this.textPassword.Text = "Password";
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(46)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRegister.Location = new System.Drawing.Point(196, 333);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(210, 44);
            this.buttonRegister.TabIndex = 206;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.textEmail.ForeColor = System.Drawing.Color.Gray;
            this.textEmail.Location = new System.Drawing.Point(174, 143);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(416, 30);
            this.textEmail.TabIndex = 202;
            this.textEmail.Text = "example@companyemail.com";
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(18, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "EMAIL:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPasswordConfirm
            // 
            this.textPasswordConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.textPasswordConfirm.ForeColor = System.Drawing.Color.Gray;
            this.textPasswordConfirm.Location = new System.Drawing.Point(174, 251);
            this.textPasswordConfirm.Multiline = true;
            this.textPasswordConfirm.Name = "textPasswordConfirm";
            this.textPasswordConfirm.Size = new System.Drawing.Size(415, 30);
            this.textPasswordConfirm.TabIndex = 205;
            this.textPasswordConfirm.Text = "Confirm Password";
            this.textPasswordConfirm.Enter += new System.EventHandler(this.textPasswordConfirm_Enter);
            this.textPasswordConfirm.Leave += new System.EventHandler(this.textPasswordConfirm_Leave);
            // 
            // textLastName
            // 
            this.textLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.textLastName.ForeColor = System.Drawing.Color.Gray;
            this.textLastName.Location = new System.Drawing.Point(389, 107);
            this.textLastName.Multiline = true;
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(201, 30);
            this.textLastName.TabIndex = 201;
            this.textLastName.Text = "Surname";
            this.textLastName.Enter += new System.EventHandler(this.TextLastName_Enter);
            this.textLastName.Leave += new System.EventHandler(this.textLastName_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(173)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(559, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 32);
            this.label6.TabIndex = 208;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.buttonRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(602, 389);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textPasswordConfirm);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textForename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registeration";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textForename;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPasswordConfirm;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label6;
    }
}