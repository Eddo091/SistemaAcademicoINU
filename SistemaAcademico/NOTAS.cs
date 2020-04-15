using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class NOTAS : Form
    {
        public NOTAS()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hice doble click en el xd, pensé que habia");
        }

        private void NOTAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.dataSet.Notas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Falta el cuadro de busqueda");
        }
    }
}
