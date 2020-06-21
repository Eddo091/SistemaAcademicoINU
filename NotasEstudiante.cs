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
        //BD
        Conexion objconexion = new Conexion();

        public NotasEstudiante()
        {
            InitializeComponent();
        }
    
        private void Promedio()
        {
            
            double lab1, lab2, parcial, nfilas = 0, prom1, prom=0;
            
            nfilas = notasdelEstudianteDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i<nfilas; i++)
           { 
            fila = notasdelEstudianteDataGridView.Rows[i];
            lab1 = int.Parse(fila.Cells["Laboratorio 1"].Value.ToString());
            lab2 = int.Parse(fila.Cells["Laboratorio 2"].Value.ToString());
            parcial = int.Parse(fila.Cells["Parcial"].Value.ToString());
            prom = int.Parse(fila.Cells["Promedio"].ToString());
                prom1 =+ (lab1 * 0.30) + (lab2 * 0.30) + (parcial * 0.40);
                prom = prom1;
                pROMEDIOLabel1.Text = prom.ToString();
            }

           

            


        }
        private void accion()
        {
            String[] valores = { nOTA_1TextBox.Text, nOTA_2TextBox.Text, nOTA_3TextBox.Text };
        }

        private void NotasEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.dataSet.Notas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.DOCENTES' Puede moverla o quitarla según sea necesario.
            this.dOCENTESTableAdapter.Fill(this.dataSet.DOCENTES);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.NotasdelEstudiante' Puede moverla o quitarla según sea necesario.
            this.notasdelEstudianteTableAdapter.FillNotasEstudiante(this.dataSet1.NotasdelEstudiante);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.dataSet1.Estudiante);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.dataSet.Notas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.dataSet.Notas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.DOCENTES' Puede moverla o quitarla según sea necesario.
            this.dOCENTESTableAdapter.Fill(this.dataSet.DOCENTES);
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
            Promedio();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            notasBindingSource.MovePrevious();
            Promedio();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            notasBindingSource.MoveLast();
            Promedio();
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            notasBindingSource.MoveNext();
            Promedio();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notasdelEstudianteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notasdelEstudianteTableAdapter.FillBy(this.dataSet.NotasdelEstudiante);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // notasBindingSource.Insert(int.Parse( accion));
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notasdelEstudianteTableAdapter.FillBy1(this.dataSet.NotasdelEstudiante);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
