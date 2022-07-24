using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanCodeDemo.Code
{
  public class ClassMain:IDisposable
    {
        private Main _main;
        private bool disposedValue;

        public ClassMain(Main main)
        {
            _main = main;
        }

        public void LoadPage(UserControl userControl)
        {
            // Dispose Old Page
            var oldPage = _main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null)
            {
                _main.panelContainer.Controls.Remove(oldPage);
                oldPage.Dispose();
            }
            // Load New Page
            _main.panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            _main.panelContainer.Controls.Add(userControl);
        }
    }
}
