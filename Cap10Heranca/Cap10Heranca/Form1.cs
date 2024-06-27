using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap10Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Conta conta;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new ContaPoupanca();
        }
    }
}
