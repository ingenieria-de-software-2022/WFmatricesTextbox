using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFmatTextbox
{
    public partial class Form1 : Form
    {
        int m, n;
        double[,] elem;
        string[] split;

        public Form1()
        {
            InitializeComponent();
            listBoxMatrix.Items.Clear();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            m = int.Parse(textBoxM.Text);
            n = int.Parse(textBoxN.Text);
            elem = new double[m, n];
            MessageBox.Show("Se creo una matriz de tamaño [" + m + "] - [" + n + "]");
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m; i++)
                {
                    split = textBoxMatrix.Lines[i].Split(',');

                    for (int j = 0; j < n; j++)
                    {
                        elem[i, j] = double.Parse(split[j]);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error en la entrada de datos.\nIngrese solo números");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string aux;

            for (int i = 0; i < m; i++)
            {
                aux = " ";
                for (int j = 0; j < n; j++)
                {
                    aux += elem[i, j] + " \t";
                }

                listBoxMatrix.Items.Add(aux);
            }
        }
    }
}
