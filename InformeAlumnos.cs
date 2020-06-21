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
    public partial class InformeAlumnos : Form
    {
        public InformeAlumnos()
        {
            InitializeComponent();
        }

        private void InformeAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.Estudiante' table. You can move, or remove it, as needed.
            this.EstudianteTableAdapter.Fill(this.DataSet.Estudiante);

            this.reportViewer1.RefreshReport();
        }
    }
}
