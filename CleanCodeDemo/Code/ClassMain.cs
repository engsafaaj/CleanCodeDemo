using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanCodeDemo.Code
{
  public class ClassMain
    {
        private Main _main;
        public ClassMain(Main main)
        {
            _main = main;
        }

        public void LoadPage(UserControl userControl)
        {
            _main.panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            _main.panelContainer.Controls.Add(userControl);
        }
    }
}
