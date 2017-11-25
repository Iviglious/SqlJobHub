using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlJobHub
{
    public partial class JobPanel : UserControl
    {
        private String JobName;
        private String StepName;

        public JobPanel()
        {
            InitializeComponent();
        }

        public JobPanel(String JobName, String StepName)
        {
            InitializeComponent();

            this.JobName = JobName;
            this.StepName = StepName;

            this.JobNameLbl.Text = this.JobName;
            this.StepNameLbl.Text = this.StepName;

            this.ActionBtn.Enabled = false;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
