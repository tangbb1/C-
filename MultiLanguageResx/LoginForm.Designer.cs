namespace MultiLanguageResx
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.languageLab = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordBtn = new System.Windows.Forms.Button();
            this.languageTxt = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.accountTxt = new System.Windows.Forms.TextBox();
            this.passwordLab = new System.Windows.Forms.Label();
            this.accountLab = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // languageLab
            // 
            this.languageLab.AutoSize = true;
            this.languageLab.Location = new System.Drawing.Point(71, 186);
            this.languageLab.Name = "languageLab";
            this.languageLab.Size = new System.Drawing.Size(29, 12);
            this.languageLab.TabIndex = 2;
            this.languageLab.Text = "语言";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(73, 259);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(90, 35);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "登录";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordBtn
            // 
            this.passwordBtn.Location = new System.Drawing.Point(225, 259);
            this.passwordBtn.Name = "passwordBtn";
            this.passwordBtn.Size = new System.Drawing.Size(90, 35);
            this.passwordBtn.TabIndex = 7;
            this.passwordBtn.Text = "修改密码";
            this.passwordBtn.UseVisualStyleBackColor = true;
            this.passwordBtn.Click += new System.EventHandler(this.passwordBtn_Click);
            // 
            // languageTxt
            // 
            this.languageTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageTxt.FormattingEnabled = true;
            this.languageTxt.Items.AddRange(new object[] {
            "简体中文(默认)",
            "繁體中文",
            "English"});
            this.languageTxt.Location = new System.Drawing.Point(135, 183);
            this.languageTxt.Name = "languageTxt";
            this.languageTxt.Size = new System.Drawing.Size(180, 20);
            this.languageTxt.TabIndex = 8;
            this.languageTxt.SelectedIndexChanged += new System.EventHandler(this.languageTxt_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Controls.Add(this.accountTxt);
            this.groupBox1.Controls.Add(this.passwordLab);
            this.groupBox1.Controls.Add(this.accountLab);
            this.groupBox1.Location = new System.Drawing.Point(43, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 116);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(92, 76);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(180, 21);
            this.passwordTxt.TabIndex = 4;
            // 
            // accountTxt
            // 
            this.accountTxt.Location = new System.Drawing.Point(92, 19);
            this.accountTxt.Name = "accountTxt";
            this.accountTxt.Size = new System.Drawing.Size(180, 21);
            this.accountTxt.TabIndex = 3;
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.Location = new System.Drawing.Point(28, 79);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(29, 12);
            this.passwordLab.TabIndex = 1;
            this.passwordLab.Text = "密码";
            // 
            // accountLab
            // 
            this.accountLab.AutoSize = true;
            this.accountLab.Location = new System.Drawing.Point(28, 22);
            this.accountLab.Name = "accountLab";
            this.accountLab.Size = new System.Drawing.Size(29, 12);
            this.accountLab.TabIndex = 0;
            this.accountLab.Text = "账号";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.languageTxt);
            this.Controls.Add(this.passwordBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.languageLab);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label languageLab;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button passwordBtn;
        private System.Windows.Forms.ComboBox languageTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox accountTxt;
        private System.Windows.Forms.Label passwordLab;
        private System.Windows.Forms.Label accountLab;
    }
}

