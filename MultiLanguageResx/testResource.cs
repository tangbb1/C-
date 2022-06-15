using MultiLanguageResx.resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLanguageResx
{
    class testResource
    {
        public void test()
        {
            ResourceManager res = new ResourceManager(typeof(test));

            string str = res.GetString("test1");

            MessageBox.Show(str);
        }
    }
}
