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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void gameFrame_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.Image = global::Enterprise_Bolado.Properties.Resources.botaovsEntered;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.Image = global::Enterprise_Bolado.Properties.Resources.botaovsDefault;
        }

      

       

       

        

    }
}
