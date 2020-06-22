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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "MATERIAS like '%" + valor + "%'" + "or PERSONAL like '%" + valor + "%'";
            dataGridView1.DataSource = bs;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.MATERIAS' Puede moverla o quitarla según sea necesario.
            this.mATERIASTableAdapter.Fill(this.dataSet.MATERIAS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformeMaterias notas = new InformeMaterias();
            notas.ShowDialog();
        }
    }
}
