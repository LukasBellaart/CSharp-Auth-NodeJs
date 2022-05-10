namespace Login
{
    partial class Form1
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
            this.LoginUsername = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.RegisterUsername = new System.Windows.Forms.TextBox();
            this.RegisterPassword = new System.Windows.Forms.TextBox();
            this.ResetUsername = new System.Windows.Forms.TextBox();
            this.ResetPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterSerialKey = new System.Windows.Forms.TextBox();
            this.RegisterDiscordId = new System.Windows.Forms.TextBox();
            this.ResetRepeatPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginUsername
            // 
            this.LoginUsername.Location = new System.Drawing.Point(23, 64);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(165, 20);
            this.LoginUsername.TabIndex = 0;
            this.LoginUsername.Text = "Username";
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(23, 90);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(165, 20);
            this.LoginPassword.TabIndex = 1;
            this.LoginPassword.Text = "Password";
            // 
            // RegisterUsername
            // 
            this.RegisterUsername.Location = new System.Drawing.Point(196, 64);
            this.RegisterUsername.Name = "RegisterUsername";
            this.RegisterUsername.Size = new System.Drawing.Size(165, 20);
            this.RegisterUsername.TabIndex = 2;
            this.RegisterUsername.Text = "Username";
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.Location = new System.Drawing.Point(196, 90);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.Size = new System.Drawing.Size(165, 20);
            this.RegisterPassword.TabIndex = 3;
            this.RegisterPassword.Text = "Password";
            // 
            // ResetUsername
            // 
            this.ResetUsername.Location = new System.Drawing.Point(367, 64);
            this.ResetUsername.Name = "ResetUsername";
            this.ResetUsername.Size = new System.Drawing.Size(165, 20);
            this.ResetUsername.TabIndex = 4;
            this.ResetUsername.Text = "Username";
            // 
            // ResetPassword
            // 
            this.ResetPassword.Location = new System.Drawing.Point(367, 90);
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(165, 20);
            this.ResetPassword.TabIndex = 5;
            this.ResetPassword.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reset Password";
            // 
            // RegisterSerialKey
            // 
            this.RegisterSerialKey.Location = new System.Drawing.Point(196, 142);
            this.RegisterSerialKey.Name = "RegisterSerialKey";
            this.RegisterSerialKey.Size = new System.Drawing.Size(165, 20);
            this.RegisterSerialKey.TabIndex = 10;
            this.RegisterSerialKey.Text = "Serial Key";
            // 
            // RegisterDiscordId
            // 
            this.RegisterDiscordId.Location = new System.Drawing.Point(196, 116);
            this.RegisterDiscordId.Name = "RegisterDiscordId";
            this.RegisterDiscordId.Size = new System.Drawing.Size(165, 20);
            this.RegisterDiscordId.TabIndex = 9;
            this.RegisterDiscordId.Text = "Discord Id";
            // 
            // ResetRepeatPassword
            // 
            this.ResetRepeatPassword.Location = new System.Drawing.Point(367, 116);
            this.ResetRepeatPassword.Name = "ResetRepeatPassword";
            this.ResetRepeatPassword.Size = new System.Drawing.Size(165, 20);
            this.ResetRepeatPassword.TabIndex = 11;
            this.ResetRepeatPassword.Text = "Repeat Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(23, 116);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(165, 24);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(196, 168);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(165, 24);
            this.RegisterButton.TabIndex = 13;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(367, 142);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(165, 24);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "Reset Password";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 199);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ResetRepeatPassword);
            this.Controls.Add(this.RegisterSerialKey);
            this.Controls.Add(this.RegisterDiscordId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetPassword);
            this.Controls.Add(this.ResetUsername);
            this.Controls.Add(this.RegisterPassword);
            this.Controls.Add(this.RegisterUsername);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUsername;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.TextBox RegisterUsername;
        private System.Windows.Forms.TextBox RegisterPassword;
        private System.Windows.Forms.TextBox ResetUsername;
        private System.Windows.Forms.TextBox ResetPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegisterSerialKey;
        private System.Windows.Forms.TextBox RegisterDiscordId;
        private System.Windows.Forms.TextBox ResetRepeatPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

