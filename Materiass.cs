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
    public partial class Materiass : Form
    {
        //BD
        Conexion objconexion = new Conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable(); //Materia
        DataTable tbl2 = new DataTable();//Docente
        public Materiass()
        {
            InitializeComponent();
        }

        private void Materiass_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.MATERIAS' Puede moverla o quitarla según sea necesario.
            this.mATERIASTableAdapter.Fill(this.dataSet.MATERIAS);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.AÑO' Puede moverla o quitarla según sea necesario.
            this.aÑOTableAdapter.Fill(this.dataSet.AÑO);
            // TODO: esta línea de código carga datos en la tabla 'iNU_DBDataSet.ESPECIALIDAD' Puede moverla o quitarla según sea necesario.
            this.eSPECIALIDADTableAdapter1.Fill(this.iNU_DBDataSet.ESPECIALIDAD);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.ESPECIALIDAD' Puede moverla o quitarla según sea necesario.
            this.eSPECIALIDADTableAdapter.Fill(this.dataSet.ESPECIALIDAD);
            //DB
            actualizarDs();
            Mostrardatos();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datosMaterias().Tables["MATERIAS"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["Id_MATERIAS"] };
            //DOC
            tbl2 = objconexion.obtener_datosDocente().Tables["DOCENTES"];
            tbl2.PrimaryKey = new DataColumn[] { tbl.Columns["Id_DOCENTES"] };



        }
        void Mostrardatos()
        {
            try
            {
                lblid.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                mATERIASComboBox.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtDOCENTE.Text = tbl2.Rows[posicion].ItemArray[1].ToString();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mostrar datos Estudiante",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void eSPECIALIDADBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eSPECIALIDADBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* //doc
            String[] valores = {
                      txtDOCENTE.Text};
            objconexion.mantenimientodatos_Docente(valores, accion);
            actualizarDs();
            posicion = tbl.Rows.Count - 1;*/
            MessageBox.Show("No sé que ponerle, me confundí demasiado, ayuda"
                ); //"Datos: " + valores, "Valores", MessageBoxButtons.OK, MessageBoxIcon.Information
            Mostrardatos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
