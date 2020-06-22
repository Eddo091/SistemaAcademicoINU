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
    public partial class InformeAsistencia : Form
    {
        public InformeAsistencia()
        {
            InitializeComponent();
        }

        private void InformeAsistencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet.ASISTENCIA' Puede moverla o quitarla según sea necesario.
            this.ASISTENCIATableAdapter.FillAsistencia(this.DataSet.ASISTENCIA);

            this.reportViewer1.RefreshReport();
        }
    }
}
