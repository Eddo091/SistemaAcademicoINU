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
    public partial class Reportescs : Form
    {
        private int _idNOTAS = 0;
        public Reportescs(int _idNots)
        {
            InitializeComponent();
            _idNOTAS = _idNots;
        }

        private void Reportescs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.RPTNotas' table. You can move, or remove it, as needed.
            this.RPTNotasTableAdapter.FillRPNotas(this.DataSet.RPTNotas, _idNOTAS);

            this.reportViewer1.RefreshReport();
        }
    }
}
