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
        public Docentes()
        {
            InitializeComponent();
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
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["DOCENTES"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["Id_DOCENTES"] };
        }
        void Mostrardatos()
        {
            try
            {
                txtName.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtApellido.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtCodigo.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtMateria.Text = tbl.Rows[posicion].ItemArray[4].ToString();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mostrar datos Docentes",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
