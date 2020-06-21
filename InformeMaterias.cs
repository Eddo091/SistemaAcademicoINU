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
    public partial class InformeMaterias : Form
    {
        public InformeMaterias()
        {
            InitializeComponent();
        }

        private void InformeMaterias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.MATERIAS' table. You can move, or remove it, as needed.
            this.MATERIASTableAdapter.Fill(this.DataSet.MATERIAS);

            this.reportViewer1.RefreshReport();
        }
    }
}
