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
    public partial class Estudiantil : Form
    {
        //BD
        Conexion objconexion = new Conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Estudiantil()
        {
            InitializeComponent();
        }

        private void Estudiantil_Load(object sender, EventArgs e)
        {
            //DB
            actualizarDs();
            Mostrardatos();
            btnelim.Visible = false;
        }
        //DB
        void actualizarDs()
        {
            tbl = objconexion.obtener_datosEstudiante().Tables["Estudiante"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["ID_ESTUDIANTE"] };
        }
        void Mostrardatos()
        {
            try
            {
                lblid.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtName.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtApellido.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtCodigo.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtEspecialidad.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtSeccion.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txtModalidad.Text = tbl.Rows[posicion].ItemArray[6].ToString();
                txtYear.Text = tbl.Rows[posicion].ItemArray[7].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mostrar datos Estudiante",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //Limpiar cajas
        void limpiar_cajas()
        {
            lblid.Text = "";
            txtName.Text = "";
            txtApellido.Text = "";
            txtCodigo.Text = "";
            txtEspecialidad.Text = "";
            txtSeccion.Text = "";
            txtModalidad.Text = "";
            txtYear.Text = "";



        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //navegacion
        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            Mostrardatos();
            //
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                Mostrardatos();
            }
            else
            {
                MessageBox.Show("Primer registro!!!", "Estudiantes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                Mostrardatos();
                btnelim.Visible = true;
            }
            else
            {
                MessageBox.Show("Último registro!!!", "Estudiantes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            Mostrardatos();
        }
        //boton de guardar
        private void button1_Click(object sender, EventArgs e)
        {
            
          



                
                String[] valores = {
                      txtName.Text,
            txtApellido.Text,
            txtCodigo.Text,
            txtEspecialidad.Text,
            txtSeccion.Text,
            txtModalidad.Text,
            txtYear.Text };
                objconexion.mantenimiento_datosEstudiante(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                MessageBox.Show("Datos: " + valores, "Valores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrardatos();




            



        }
        //Eliminar
        private void btnelim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar a " + txtName.Text + " ?", "Estudiantes", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblid.Text };
                objconexion.mantenimiento_datosEstudiante(valores, "eliminar");
                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                Mostrardatos();
            }
        }
    }
}
