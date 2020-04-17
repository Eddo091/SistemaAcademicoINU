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
    public partial class Docentes : Form
    {
        Conexion objconexion = new Conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable(); //Docente
        DataTable tbl2 = new DataTable(); //Materia
        public Docentes()
        {
            InitializeComponent();
        }
        //limpiar cajas
        void limpiar_cajas()
        {
            lblid.Text = "";
            txtName.Text = "";
            txtApellido.Text = "";
            txtCodigo.Text = "";
            txtMateria.Text = "";


        }
        //Navegacion

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            Mostrardatos();
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
                MessageBox.Show("Primer registro!!!", "Docentes",
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
                MessageBox.Show("Último registro!!!", "Docentes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            Mostrardatos();
        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            //DB
            actualizarDs();
            Mostrardatos();
            btnelim.Visible = false;
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datosDocente().Tables["DOCENTES"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["Id_DOCENTES"] };
        }
        void Mostrardatos()
        {
            try
            {

                lblid.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtName.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtApellido.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtCodigo.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtMateria.Text = tbl2.Rows[posicion].ItemArray[1].ToString();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mostrar datos Docentes",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] valores = {
                      txtName.Text,
            txtApellido.Text,
            txtCodigo.Text,
            txtMateria.Text,
            };
            objconexion.mantenimientodatos_Docente(valores, accion);
            actualizarDs();
            posicion = tbl.Rows.Count - 1;
            MessageBox.Show("Datos: " + valores, "Valores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Mostrardatos();

            String[] valores2 = {
                   
            txtMateria.Text
            };
            objconexion.mantenimientodatos_Docente(valores2, accion);
            actualizarDs();
            posicion = tbl.Rows.Count - 1;
            MessageBox.Show("Datos: " + valores2, "Valores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Mostrardatos();
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar a " + txtName.Text + " ?", "Docentes", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblid.Text };
                objconexion.mantenimientodatos_Docente(valores, "eliminar");
                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                Mostrardatos();
            }
        }
    }
}
