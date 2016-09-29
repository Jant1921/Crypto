using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;


namespace CriptoSystem
{
    public partial class VistaEscritorio : Form
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;

        bool decodifica = true;
        public VistaEscritorio()
        {
            InitializeComponent();
            displayTime();
            Codificar.Checked = true;
            timer1.Enabled = true;
            textBox3.Enabled = false;
            rellenarListaAlgoritmos();

            
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            ShowDialog();
            //Show();


        }
        private void rellenarListaAlgoritmos()
        {
            listBox1.Items.Add("Vigenere");
            listBox1.Items.Add("Transposicion");

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

        private void displayTime()
        {
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
                textBox3.Text = vi.codificar(textBox1.Text, "12");
            }
            else
            {
                textBox3.Text = vi.decodificar(textBox1.Text, "12");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            traducir();
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
