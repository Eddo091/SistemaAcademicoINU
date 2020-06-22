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
    public partial class InformeMatricula : Form
    {
        
        public InformeMatricula()
        {
            InitializeComponent();
           
        }

        private void InformeMatricula_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.Matricula_estudiante' table. You can move, or remove it, as needed.
           this.Matricula_estudianteTableAdapter.Fill(this.DataSet.Matricula_estudiante);

            this.reportViewer1.RefreshReport();
        }
    }
}
