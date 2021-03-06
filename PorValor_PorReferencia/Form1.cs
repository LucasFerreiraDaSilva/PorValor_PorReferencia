using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorValor_PorReferencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //altera o valor das variáveis locais que são PASSADAS por valor
        //SEM afetar os valores das variáveis originais na chamada
        //essas declarações são válidas apenas dentro deste ESCOPO
        void porValor(double varA, double varB)
        {
            varA = varA * 3;
            varB = varB * 5;
            MessageBox.Show("a = " + varA + " e b = " + varB);
        }

        void porReferencia(ref double x, ref double y)
        {
            x = x * 3;
            y = y * 5;
            MessageBox.Show("a = " + x + " e b = " + y);
        }

        private void btValor_Click(object sender, EventArgs e)
        {
            //declaraçao local das variáveis originais:
            double varA, varB;

            //captação dos dados dos campos...:
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //chama o método "porValor" declarado acima...:
            porValor(varA, varB);

            //mostra os valores das variáveis nos txtRes...:
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            //declaraçao local das variáveis originais:
            double varA, varB;

            //captação dos dados dos campos...:
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //chamada do método passando a referência das variáveis em memória (endereço)
            porReferencia(ref varA, ref varB);

            //mostra os valores das variáveis nos txtRes...:
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }
    }
}
