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
        private int numeroTraductor;
        private string frase = "";
        private ControladorEscritorio controlador = new ControladorEscritorio();

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
            establecerListaAlgoritmos();
            establecerListaPersistencia();
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            ShowDialog();
            controlador.crearAlfabeto();
            
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

        private void displayTime()
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayTime();
        }

        private bool traducir()
        {
            definirFrase();
            if(!controlador.verificarString(frase)) {
                MessageBox.Show("Existen caracteres no pertenecientes al alfabeto establecido");
                return false;
            }
            if (Codificar.Checked)
            {
                controlador.codificar(frase, numeroTraductor);

            } else
            {
                controlador.decodificar(frase, numeroTraductor);
            }
            return true;
        }

        void definirFrase() {
            frase = textBox1.Text;
        }

        void establecerListaAlgoritmos() {
            bool continuar = true;
            string[] listaNombresTraductores = controlador.getNombresTraductores();
            int cantidadTraductores = listaNombresTraductores.Length;
            for(int posicion = 0; posicion < cantidadTraductores; posicion++) {
                checkedListBox2.Items.Add(listaNombresTraductores.ElementAt(posicion));
            }
            
        }

        void establecerListaPersistencia() {
            bool continuar = true;
            string[] listaNombresPersistencia = controlador.getNombresPersistencia();
            int cantidadTraductores = listaNombresPersistencia.Length;
            string nombresTraductores = "";

            for(int posicion = 0; posicion < cantidadTraductores; posicion++) {
                checkedListBox1.Items.Add(listaNombresPersistencia.ElementAt(posicion));
            }
            

        }

        int[] establecerAlgoritmo() {
            int[] res = new int[checkedListBox2.CheckedIndices.Count];
            checkedListBox2.CheckedIndices.CopyTo(res, 0);
            return res;
        }

        int[] establecerPersistencia() {
            int[] res = new int[checkedListBox1.CheckedIndices.Count];
            checkedListBox1.CheckedIndices.CopyTo(res, 0);
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] listaAlgoritmo = establecerAlgoritmo();

            int[] listaPersistencia = establecerPersistencia();
            if(listaAlgoritmo.Count() == 0) {
                MessageBox.Show("Debe de seleccionar al menos un algoritmo");
                return;
            }
            if(listaPersistencia.Count() == 0) {
                MessageBox.Show("Debe de seleccionar al menos un metodo de persistencia");
                return;
            }

            string[] lineas = new string[listaAlgoritmo.Count()];
            for(int i = 0; i < listaAlgoritmo.Length; i++) {

                numeroTraductor = listaAlgoritmo[i];
                traducir();
                for(int j = 0; j < listaPersistencia.Length; j++) {
                    controlador.numeroPersistencia = listaPersistencia[j];
                    controlador.guardar();
                }
                lineas[i] = controlador.getNombresTraductores().ElementAt(listaAlgoritmo[i]) + ": " + controlador.retornarResultado();
            }
            textBox3.Lines=(lineas);
        }
        
        
    }
}
