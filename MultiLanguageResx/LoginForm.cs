using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLanguageResx
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //设置combobox的值
            string language = Properties.Settings.Default.DefaultLanguage;
            if (language == "zh-CN")
            {
                languageTxt.Text = "简体中文(默认)";
            }
            else if (language == "zh-CHT")
            {
                languageTxt.Text = "繁體中文";
            }
            else if (language == "en-US")
            {
                languageTxt.Text = "English";
            }
        }

        //切换语言
        private void languageTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            languageTxt.Enabled = false;
            if (languageTxt.Text == "简体中文(默认)")
            {
                //修改默认语言
                MultiLanguage.SetDefaultLanguage("zh-CN");
                //对所有打开的窗口重新加载语言
                foreach (Form form in Application.OpenForms)
                {
                    LoadAll(form);
                }
            }
            else if (languageTxt.Text == "繁體中文")
            {
                //修改默认语言
                MultiLanguage.SetDefaultLanguage("zh-CHT");
                //对所有打开的窗口重新加载语言
                foreach (Form form in Application.OpenForms)
                {
                    LoadAll(form);
                }
            }
            else if (languageTxt.Text == "English")
            {
                //修改默认语言
                MultiLanguage.SetDefaultLanguage("en-US");
                //对所有打开的窗口重新加载语言
                foreach (Form form in Application.OpenForms)
                {
                    LoadAll(form);
                }
            }
            languageTxt.Enabled = true;
        }

        private void LoadAll(Form form)
        {
            if (form.Name == "LoginForm")
            {
                MultiLanguage.LoadLanguage(form, typeof(LoginForm));
            }
            else if (form.Name == "PasswordForm")
            {
                MultiLanguage.LoadLanguage(form, typeof(PasswordForm));
            }
        }

        private void passwordBtn_Click(object sender, EventArgs e)
        {
            PasswordForm pwdform = new PasswordForm();
            pwdform.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.csdn.net/softimite_zifeng");
        }
    }
}
