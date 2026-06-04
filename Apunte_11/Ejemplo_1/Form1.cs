using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form
    {

        int[] Vector = new int[100];
        int Contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        int BusquedaSecuencial(int valor) 
        {
            int idx = 0;
            int idxBuscado = -1;

            while (idxBuscado==-1 && idx < Contador) 
            {
                if (valor == Vector[idx]) 
                idxBuscado = idx;

                idx++;
            }
            
            return idxBuscado;
        }

        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form2 fDatos=new Form2();

            if (fDatos.ShowDialog()==DialogResult.OK) 
            {
                int valor = Convert.ToInt32(fDatos.tbValor.Text);
                #region Registrar
                Vector[Contador] = valor;
                Contador++;
                #endregion
            }

            fDatos.Dispose();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            Form2 fDatos = new Form2();
            Form3 fResultados = new Form3();

            if (fDatos.ShowDialog() == DialogResult.OK) 
            {
                int buscar = Convert.ToInt32( fDatos.tbValor.Text);
                int encontrado = BusquedaSecuencial(buscar);

                if (encontrado == -1)
                {
                    fResultados.lsbResultados.Items.Add("Valor no encontrado");
                    fResultados.ShowDialog();
                }
                else 
                {
                    fResultados.lsbResultados.Items.Add($"Valor encontrado: {Vector[encontrado]}");
                    fResultados.ShowDialog();
                }
            }
            fDatos.Dispose();
            fResultados.Dispose();
        }
    }
}
