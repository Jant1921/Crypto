using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptoSystem
{
    public partial class GUI : Form
    {
        bool decodifica = true;
        public GUI()
        {
            InitializeComponent();
            displayTime();
            Codificar.Checked = true;
            timer1.Enabled = true;
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (Codificar.Checked)
            {
                Decodificar.Checked = false;
            }else
            {
                Decodificar.Checked = true;
            }
        }

        private void Decodificar_CheckedChanged(object sender, EventArgs e)
        {
            if (Decodificar.Checked)
            {
                Codificar.Checked = false;
            }
            else
            {
                Codificar.Checked = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void displayTime()
        {
            //label3.Text = DateTime.Now.ToShortTimeString();
            label3.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayTime();
        }
    }
}
