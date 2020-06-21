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
    public partial class Asitencias : Form
    {
        public Asitencias()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Asitencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.ASISTENCIA' table. You can move, or remove it, as needed.
            this.aSISTENCIATableAdapter.FillAsistencia(this.dataSet.ASISTENCIA);

        }
    }
}
