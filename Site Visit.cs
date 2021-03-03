using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Charlie
{
    public partial class Site_Visit : Form
    {
        private Form1 form1;

        public Site_Visit()
        {
            InitializeComponent();
        }

        public Site_Visit(Form1 form1)
        {
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }
    }
}
