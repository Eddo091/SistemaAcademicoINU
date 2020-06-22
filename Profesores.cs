using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace SistemaAcademico
{
    public partial class Profesores : Form
    {
        //BD
        Conexion objconexion = new Conexion();
        public Profesores()
        {
            InitializeComponent();
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "NOMBRES like '%" + valor + "%'"+ "or APELLIDOS like '%" + valor + "%'" + "or MATERIAS like '%" + valor + "%'";
            dataGridView1.DataSource = bs;
        }
        public int _codDocen;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           Docentes frm = new Docentes();
            frm.ShowDialog();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.DOCENTES' Puede moverla o quitarla según sea necesario.
            this.dOCENTESTableAdapter.Fill(this.dataSet.DOCENTES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Docentes frm = new Docentes();
            frm.ShowDialog();
        }

       // private void button2_Click(object sender, EventArgs e)
       // {
           // NotasEstudiante Notas = new NotasEstudiante();
           // Notas.ShowDialog();
      //  }

        private void button2_Click_1(object sender, EventArgs e)
        {
            InformesDocentes doc = new InformesDocentes();
            doc.ShowDialog();
        }
    }
}
