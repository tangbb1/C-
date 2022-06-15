namespace MultiLanguageResx
{
    partial class PasswordForm
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
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.accountTxt = new System.Windows.Forms.TextBox();
            this.passwordLab = new System.Windows.Forms.Label();
            this.accountLab = new System.Windows.Forms.Label();
            this.newpasswordTxt = new System.Windows.Forms.TextBox();
            this.newpasswordLab = new System.Windows.Forms.Label();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(135, 101);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(180, 21);
            this.passwordTxt.TabIndex = 8;
            // 
            // accountTxt
            // 
            this.accountTxt.Location = new System.Drawing.Point(135, 44);
            this.accountTxt.Name = "accountTxt";
            this.accountTxt.Size = new System.Drawing.Size(180, 21);
            this.accountTxt.TabIndex = 7;
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.Location = new System.Drawing.Point(51, 104);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(41, 12);
            this.passwordLab.TabIndex = 6;
            this.passwordLab.Text = "旧密码";
            // 
            // accountLab
            // 
            this.accountLab.AutoSize = true;
            this.accountLab.Location = new System.Drawing.Point(63, 47);
            this.accountLab.Name = "accountLab";
            this.accountLab.Size = new System.Drawing.Size(29, 12);
            this.accountLab.TabIndex = 5;
            this.accountLab.Text = "账号";
            // 
            // newpasswordTxt
            // 
            this.newpasswordTxt.Location = new System.Drawing.Point(135, 159);
            this.newpasswordTxt.Name = "newpasswordTxt";
            this.newpasswordTxt.Size = new System.Drawing.Size(180, 21);
            this.newpasswordTxt.TabIndex = 10;
            // 
            // newpasswordLab
            // 
            this.newpasswordLab.AutoSize = true;
            this.newpasswordLab.Location = new System.Drawing.Point(51, 162);
            this.newpasswordLab.Name = "newpasswordLab";
            this.newpasswordLab.Size = new System.Drawing.Size(41, 12);
            this.newpasswordLab.TabIndex = 9;
            this.newpasswordLab.Text = "新密码";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(261, 221);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(90, 35);
            this.modifyBtn.TabIndex = 11;
            this.modifyBtn.Text = "修改";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 286);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.newpasswordTxt);
            this.Controls.Add(this.newpasswordLab);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.accountTxt);
            this.Controls.Add(this.passwordLab);
            this.Controls.Add(this.accountLab);
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox accountTxt;
        private System.Windows.Forms.Label passwordLab;
        private System.Windows.Forms.Label accountLab;
        private System.Windows.Forms.TextBox newpasswordTxt;
        private System.Windows.Forms.Label newpasswordLab;
        private System.Windows.Forms.Button modifyBtn;
    }
}