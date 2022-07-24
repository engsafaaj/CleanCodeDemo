using CleanCodeDemo.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanCodeDemo
{
    public partial class Main : Form
    {
        //private ClassMain classMain;
        public Main()
        {
            InitializeComponent();
            //classMain = new ClassMain(this);
        }

        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            using (ClassMain ma = new ClassMain(this))
            {
                ma.LoadPage(new Gui.UsersControl.HomePageUserControl());

            }
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {

        }
        private void Main_Load(object sender, EventArgs e)
        {
           // classMain.LoadPage(new Gui.UsersControl.HomePageUserControl());

        }

        #endregion


    }
}
