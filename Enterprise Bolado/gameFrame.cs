using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise_Bolado
{
    public partial class gameFrame : Form
    {
        private Form form1;
        public gameFrame(Form formVem)
        {
            form1 = formVem;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gameFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            form1.Show();
        }

        

    }
}
