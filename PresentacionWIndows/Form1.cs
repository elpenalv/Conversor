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

        private void button1_Click(object sender, EventArgs e)
        {
            double cantidad = 0;

            bool verdad = double.TryParse(textBox1.Text, out cantidad);
            if (verdad || cantidad >=0)
            {
                Divisa divi1 = c.GetDivisas()[lB1.SelectedItem.ToString()];
                Divisa divi2 = c.GetDivisas()[lB2.SelectedItem.ToString()];

                double resultado = this.c.Convertir(divi1, divi2, cantidad);
                string valorFormateado = resultado.ToString("N2");
                textBox2.Text = valorFormateado;
            }
            else
            {
                MessageBox.Show("Introduce la cantidad correctamente");
            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
