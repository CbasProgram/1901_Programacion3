using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5_Sebastian_Rosales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void itxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }    

        private void jtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            //condicionales
            if (itxt.Text == "" && jtxt.Text == "")
            {
                MessageBox.Show("Ingresar tamaño de la matriz");
            }

            //definición variables
            int fila = Convert.ToInt32(itxt.Text);
            int colum = Convert.ToInt32(jtxt.Text);

            //matriz
            int[,] matriz = new int[fila, colum];
            //numeros aleatorios
            Random aleatorio = new Random();

            //Generar matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 101);
                }
            }

            //llenar la matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    MessageBox.Show("La posición es: " + i + "," + j + " = " + matriz[i,j]);
                }
            }
        }
    }
}
