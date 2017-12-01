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
            InitTabControl();
        }

        private void InitTabControl()
        {
            this.CPTabControl.SuspendLayout();

            for (int i = 1; i <= 3; i++)
            {
                TableLayoutPanel tlp = new TableLayoutPanel()
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    RowCount = i * 3 + 1
                };
                tlp.SuspendLayout();

                for (int b = 0; b < i * 3; b++)
                {
                    // Create panel
                    JobPanel jp = new JobPanel("Testing job for execution of SSIS package " + i.ToString() + " - " + (b + 1).ToString(), "Test step A")
                    {
                        Dock = DockStyle.Fill
                    };

                    // Add row
                    tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));

                    // Add panel
                    tlp.Controls.Add(jp, 0, b);
                }

                TabPage tp = new TabPage("Env " + i.ToString());
                tp.Controls.Add(tlp);
                this.CPTabControl.TabPages.Add(tp);

                // Resume Layout
                tlp.ResumeLayout(false);
            }

            // Resume Layout
            this.CPTabControl.ResumeLayout(false);
        }
    }
}
