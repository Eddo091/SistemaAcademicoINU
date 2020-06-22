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
    public partial class informesNotas : Form
    {
        public informesNotas()
        {
            InitializeComponent();
        }

        private void informesNotas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.RPTNotas' table. You can move, or remove it, as needed.
        //    this.RPTNotasTableAdapter.FillRPNotas(this.DataSet.RPTNotas);
            // TODO: This line of code loads data into the 'DataSet.RPTNotas' table. You can move, or remove it, as needed.
            //   this.RPTNotasTableAdapter.FillRPTNotas(this.DataSet.RPTNotas);

            //   this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
