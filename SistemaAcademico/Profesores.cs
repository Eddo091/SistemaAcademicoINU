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
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           Docentes frm = new Docentes();
            frm.ShowDialog();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.DOCENTES' Puede moverla o quitarla según sea necesario.
            this.dOCENTESTableAdapter.Fill(this.dataSet.DOCENTES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Falta el cuadro de busqueda, por cierto usuarios es donde iba el usuario y contraseña u.u");
        }
    }
}
