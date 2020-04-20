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
    public partial class Estudiantes : Form
    {
        //BD
        Conexion objconexion = new Conexion();
        
        
        DataTable tbl = new DataTable();

     
        public Estudiantes()
        {
            InitializeComponent();

        }
        //Reporte 
       


            //Filtrar datos
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Nombre like '%" + valor + "%'"+"or Apellido like '%"+valor + "%'" + "or Codigo Estudiante like '%"+valor + "%'" + "or Especialidad '%"+valor
               + "%'" + "or Seccion like '%"+valor + "%'" + "or Modalidad like '%"+valor + "%'" + "or Año like '%"+valor + "%'";
            dataGridView1.DataSource = bs;
        }
        public int _codEstu;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            try {
                // TODO: esta línea de código carga datos en la tabla 'dataSet.Estudiante' Puede moverla o quitarla según sea necesario.
                this.estudianteTableAdapter.Fill(this.dataSet.Estudiante);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mostrar datos Estudiante",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);


        }
        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           Estudiantil frm = new Estudiantil();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Traté de hacer un reporte, pero no me salió:c, me estresa", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Estudiantil frm = new Estudiantil();
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
