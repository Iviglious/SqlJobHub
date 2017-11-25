using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlJobHubDesign
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            /*
            FlowLayoutPanel flp = new FlowLayoutPanel();
            Panel p1 = new Panel();
            Panel p2 = new Panel();
            Panel p3 = new Panel();

            //this.SuspendLayout();
            flp.SuspendLayout();

            flp.Location = new Point(430, 12);
            flp.Size = new Size(410, 370);
            flp.BackColor = Color.Azure;

            flp.Controls.Add(p1);
            flp.Controls.Add(p2);
            flp.Controls.Add(p3);

            p1.Size = new Size(400, 100);
            p1.BackColor = Color.Chocolate;

            p2.Size = new Size(400, 100);
            p2.BackColor = Color.Yellow;

            p3.Size = new Size(400, 100);
            p3.BackColor = Color.Violet;

            this.Controls.Add(flp);

            flp.ResumeLayout(false);
            //this.ResumeLayout(false);
            */

            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.SuspendLayout();
            tlp.Dock = DockStyle.Fill;
            tlp.RowCount = 4;
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));

            Panel p1 = new Panel();
            p1.Dock = DockStyle.Fill;
            p1.BackColor = Color.Chocolate;

            Panel p2 = new Panel();
            p2.Dock = DockStyle.Fill;
            p2.BackColor = Color.Green;

            Panel p3 = new Panel();
            p3.Dock = DockStyle.Fill;
            p3.BackColor = Color.Yellow;

            tlp.Controls.Add(p1, 0, 0);
            tlp.Controls.Add(p2, 0, 1);
            tlp.Controls.Add(p3, 0, 2);

            tlp.ResumeLayout(false);
            this.tabPage1.Controls.Add(tlp);

        }
    }
}
