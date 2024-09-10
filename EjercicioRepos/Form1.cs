using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioRepos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtnumero3.Text = "";
            txtnumero1.Focus();
            txtnumero2.Focus();
            txtnumero3.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int Numero1, Numero2, Numero3,Suma;
            //Declaracion de restricciones
            if(String.IsNullOrEmpty(txtnumero1.Text))
            {
                MessageBox.Show("No ha llenado el campo el campo 1");
                return;
            }
            Numero1 = Convert.ToInt32(txtnumero1.Text);
            if (String.IsNullOrEmpty(txtnumero2.Text))
            {
                MessageBox.Show("No ha llenado el campo el campo 2");
                return;
            }
            if (String.IsNullOrEmpty(txtnumero2.Text))
            {
                MessageBox.Show("No ha llenado el campo el campo 2");
                return;
            }
            Numero2 = Convert.ToInt32(txtnumero2.Text);

            
            if (String.IsNullOrEmpty(txtnumero3.Text))
            {
                MessageBox.Show("No ha llenado el campo el campo 3");
                return;
            }
            Numero3 = Convert.ToInt32(txtnumero3.Text);
            //Operador
            Suma = Numero1 + Numero2 + Numero3;
            MessageBox.Show(String.Format("el resultado de la suma es: {0}", Suma));
        }
    }
}
