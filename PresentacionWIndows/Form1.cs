using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDominio;
using ModeloNegocio;

namespace PresentacionWIndows
{
    public partial class Form1 : Form
    {
        private Conversor c;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que le pasamos un conversor con divisas ya introducidas
        /// </summary>
        /// <param name="c"></param>
        public Form1(Conversor c) : base() {

            InitializeComponent();
            foreach (Divisa s in c.GetDivisas())
            {
                lB1.Items.Add(s.id);
            }

            foreach (Divisa s in c.GetDivisas())
            {
                lB2.Items.Add(s.id);
            }

            this.c = c;


        }
    
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funcion del boton, controlamos que la cantidad que introducimos sea valida y no sea negativa, sino mostramos error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double cantidad = 0;

            bool cantidadValida = double.TryParse(textBox1.Text, out cantidad);

            if (cantidadValida && cantidad >= 0)
            {
                if (lB1.SelectedItem == null || lB2.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona las divisas de origen y destino.");
                }
                else
                {
                    string divisaOrigen = lB1.SelectedItem.ToString();
                    string divisaDestino = lB2.SelectedItem.ToString();

                    Divisa divi1 = c.GetDivisas()[divisaOrigen];
                    Divisa divi2 = c.GetDivisas()[divisaDestino];

                    double resultado = this.c.Convertir(divi1, divi2, cantidad);
                    string valorFormateado = resultado.ToString("N2");
                    textBox2.Text = valorFormateado;
                }
            }
            else
            {
                MessageBox.Show("Introduce una cantidad válida mayor o igual a cero.");
            }
        }
        /// <summary>
        /// Boton para salir de la Aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
