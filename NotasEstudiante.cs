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
    public partial class NotasEstudiante : Form
    {
        public NotasEstudiante()
        {
            InitializeComponent();
        }

        private void Promedio()
        {
            double lab1, lab2, parcial, nfilas = 0, prom1, prom;
            
            nfilas = notasdelEstudianteDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i<nfilas; i++)
           { 
            fila = notasdelEstudianteDataGridView.Rows[i];
            lab1 = int.Parse(fila.Cells["Laboratorio 1"].ToString());
            lab2 = int.Parse(fila.Cells["Laboratorio 2"].ToString());
            parcial = int.Parse(fila.Cells["Parcial"].ToString());
            prom = int.Parse(fila.Cells["Promedio"].ToString());

            }

            prom1 = (lab1 * 0.30) + (lab2 * 0.30) + (parcial * 0.40);
            prom = prom1;
             
        }


        private void NotasEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.dataSet.Notas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.ESPECIALIDAD' Puede moverla o quitarla según sea necesario.
            this.eSPECIALIDADTableAdapter.Fill(this.dataSet.ESPECIALIDAD);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.MATERIAS' Puede moverla o quitarla según sea necesario.
            this.mATERIASTableAdapter.Fill(this.dataSet.MATERIAS);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.dataSet.Estudiante);
            // TODO: This line of code loads data into the 'dataSet.NotasdelEstudiante' table. You can move, or remove it, as needed.
            this.notasdelEstudianteTableAdapter.FillNotasEstudiante(this.dataSet.NotasdelEstudiante);

        }

        private void eSPECIALIDADComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eSPECIALIDADLabel_Click(object sender, EventArgs e)
        {

        }

        private void notasdelEstudianteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            notasBindingSource.MoveFirst();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            notasBindingSource.MovePrevious();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            notasBindingSource.MoveLast();
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            notasBindingSource.MoveNext();
        }
    }
}
