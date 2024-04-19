using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO.PL
{
    public partial class frmCreate : Form
    {
        public enum CreateType
        {
            ShortTerm,
            LongTerm
        }
        public frmCreate(CreateType createType)
        {
            InitializeComponent();
            textBox1.Enabled = true;
            switch(createType)
            {
                case CreateType.ShortTerm:
                    panel5.Visible = false;
                    listView1.Visible = false;
                    break;
                case CreateType.LongTerm:

                    break;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
