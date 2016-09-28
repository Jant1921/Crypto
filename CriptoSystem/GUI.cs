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
            textBox3.Enabled = false;
            rellenarListaAlgoritmos();

        }
        private void rellenarListaAlgoritmos()
        {
            listBox1.Items.Add("Vigenere");
            listBox1.Items.Add("Transposicion");

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
            traducir();
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

        private void traducir()
        {
            Vigenere vi = new Vigenere();
            if (Codificar.Checked)
            {
                textBox3.Text = vi.codificar(textBox1.Text, textBox2.Text);
            }
            else
            {
                textBox3.Text = vi.decodificar(textBox1.Text, textBox2.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            traducir();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            traducir();
            //desabilitarClave();
        }
        private void desabilitarClave()
        {
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clipboard.SetDataObject(textBox2.Text);
            Clipboard.SetText(textBox3.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
