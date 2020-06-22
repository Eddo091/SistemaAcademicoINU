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
            // TODO: esta línea de código carga datos en la tabla 'dataSet.SECCION' Puede moverla o quitarla según sea necesario.
            this.sECCIONTableAdapter.Fill(this.dataSet.SECCION);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.ESPECIALIDAD' Puede moverla o quitarla según sea necesario.
            this.eSPECIALIDADTableAdapter.Fill(this.dataSet.ESPECIALIDAD);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.dataSet.Estudiante);
            // TODO: This line of code loads data into the 'dataSet.ASISTENCIA' table. You can move, or remove it, as needed.
            this.aSISTENCIATableAdapter.FillAsistencia(this.dataSet.ASISTENCIA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
