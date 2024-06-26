using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08Construtores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitializer_Click(object sender, EventArgs e)
        {

            Cliente guilherme = new Cliente("guilherme Silveira")
            {
                Cpf = "123.456.789-01",
                Rg = "21.345.987-x",
                Idade = 25
            };


            Cliente victor = new Cliente("Victor Harada")
            {
                Cpf = "123.456.789-01",
                Rg = "21.345.987-x",
                Idade = 25
            };     
        }
    }
}
