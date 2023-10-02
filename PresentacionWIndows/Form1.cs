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


            foreach (Divisa s in c.GetDivisas())
            {
                listBox1.Items.Add(s.id);
            }

            foreach (Divisa s in c.GetDivisas())
            {
                listBox2.Items.Add(s.id);
            }

            this.c = c;


        }
    
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
    }
}
