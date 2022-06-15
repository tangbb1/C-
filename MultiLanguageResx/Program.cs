using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLanguageResx
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            testResource testResource = new testResource();
            testResource.test();

            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            
        }
    }
}
