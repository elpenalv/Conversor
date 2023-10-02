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

        this.c = c;


        }
    
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

    }
}
