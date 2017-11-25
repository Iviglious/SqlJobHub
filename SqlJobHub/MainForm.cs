using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlJobHub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int b = 1; b <= i*3; b++)
                {

                }
                TabPage tp = new TabPage("Env " + i.ToString());
                //tp.Controls.Add(tpc);
                CPTabControl.TabPages.Add(tp);
            }
        }
    }
}
