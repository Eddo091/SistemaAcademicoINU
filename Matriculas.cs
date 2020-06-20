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
    public partial class Matriculas : Form
    {
        //DB
        Conexion objconexion = new Conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable(); //Estudiante
        DataTable tbl2 = new DataTable();//Especialidad
        DataTable tbl3 = new DataTable(); //Seccion
        DataTable tbl4 = new DataTable(); //Modalidad
        public Matriculas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                MessageBox.Show("Primer registro!!!", "Matricula",
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
                MessageBox.Show("Último registro!!!", "Matricula",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            Mostrardatos();
        }

        private void Matriculas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Matricula_estudiante' Puede moverla o quitarla según sea necesario.
            this.matricula_estudianteTableAdapter.Fill(this.dataSet.Matricula_estudiante);
            //DB
            actualizarDs();
            Mostrardatos();
        }
        //DB
        void actualizarDs()
        {
            tbl = objconexion.obtener_datosEstudiante().Tables["Estudiante"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["ID_ESTUDIANTE"] };
            tbl2 = objconexion.obtener_datosEspecialidad().Tables["ESPECIALIDAD"];
            tbl2.PrimaryKey = new DataColumn[] { tbl2.Columns["ID_ESPECIALIDAD"] };
            tbl3 = objconexion.obtener_datosSeccion().Tables["SECCION"];
            tbl3.PrimaryKey = new DataColumn[] { tbl2.Columns["Id_SECCION"] };
            tbl4 = objconexion.obtener_datosModalidad().Tables["MODALIDAD"];
            tbl4.PrimaryKey = new DataColumn[] { tbl2.Columns["Id_MODALIDAD"] };
        }
        void Mostrardatos()
        {
            try
            {
                txtName.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtApellido.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtCodigo.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtEspecialidad.Text = tbl2.Rows[posicion].ItemArray[1].ToString();
                txtSeccion.Text = tbl3.Rows[posicion].ItemArray[1].ToString();
                txtModalidad.Text = tbl4.Rows[posicion].ItemArray[1].ToString();
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Mostrar datos Matricula",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] valores1 = {
                      txtName.Text,
            txtApellido.Text,
            txtCodigo.Text,
            };
            String[] valores2 = {
                      txtEspecialidad.Text
            };
            String[] valores3 = {
                      txtSeccion.Text
            };
            String[] valores4 = {
                    txtModalidad.Text
            };

            objconexion.mantenimiento_datosEstudiante(valores1, accion); //estudiante
            objconexion.mantenimientodatos_Especialidad(valores2, accion); //especialidad
            objconexion.mantenimientodatos_Seccion(valores3, accion); //Seccion
            objconexion.mantenimientodatos_Modalidad(valores4, accion);//Modalidad
            actualizarDs();
            posicion = tbl.Rows.Count - 1;
            Mostrardatos();


        }

     

    
    }
}
