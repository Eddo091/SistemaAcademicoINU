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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            try {
                // TODO: esta línea de código carga datos en la tabla 'dataSet.Estudiante' Puede moverla o quitarla según sea necesario.
                this.estudianteTableAdapter.Fill(this.dataSet.Estudiante);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mostrar datos Estudiante",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Falta el cuadro de busqueda");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           Estudiantil frm = new Estudiantil();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
