using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//libreria para conectarse al SQL Server
using System.Windows.Forms;

namespace SistemaAcademico
{
    class Conexion
    {
        SqlConnection miConexion = new SqlConnection();//establece la conexion a la base de datos
        SqlCommand comandoSQL = new SqlCommand(); //representa los comando SQL que se van a ejecutar.
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();//intermediario entre el origen de datos y la aplicacion.
        DataSet ds = new DataSet();

        public Conexion ()
            {
            string cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\INU_DB.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();

            }
        public DataSet obtener_datosEstudiante()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;

            //Estudiante
            comandoSQL.CommandText = "select * from Estudiante";
            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "Estudiante");

            return ds;


        }
        //Docentes
        public DataSet obtener_datosDocente()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;

            comandoSQL.CommandText = "select * from DOCENTES";
        miAdaptadorDatos.SelectCommand = comandoSQL;
        miAdaptadorDatos.Fill(ds, "DOCENTES");

            return ds;


        }
             
        //Materias
         public DataSet obtener_datosMaterias()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;

             comandoSQL.CommandText = "select * from MATERIAS";
        miAdaptadorDatos.SelectCommand = comandoSQL;
        miAdaptadorDatos.Fill(ds, "MATERIAS");

            return ds;


        }

       



    //Notas
      public DataSet obtener_datosNotas()
    {
        ds.Clear();
        comandoSQL.Connection = miConexion;
        comandoSQL.CommandText = "select * from Notas";
        miAdaptadorDatos.SelectCommand = comandoSQL;
        miAdaptadorDatos.Fill(ds, "Notas");
        return ds;


    }

    

//Notas_Periodo
  public DataSet obtener_datosNotasPeriodo()
{
    ds.Clear();
   comandoSQL.CommandText = "select * from NOTAS_PERIODO";
   miAdaptadorDatos.SelectCommand = comandoSQL;
   miAdaptadorDatos.Fill(ds, "NOTAS_PERIODO");
    return ds;


}




//Año
  public DataSet obtener_datosAño()
{
    ds.Clear();
   comandoSQL.CommandText = "select * from AÑO";
miAdaptadorDatos.SelectCommand = comandoSQL;
miAdaptadorDatos.Fill(ds, "AÑO");
    return ds;


}



//Modalidad
  public DataSet obtener_datosModalidad()
{
    ds.Clear();
  comandoSQL.CommandText = "select * from MODALIDAD";
miAdaptadorDatos.SelectCommand = comandoSQL;
miAdaptadorDatos.Fill(ds, "MODALIDAD");
    return ds;


}




//Especialidad

public DataSet obtener_datosEspecialidad()
{
    ds.Clear();
   
comandoSQL.CommandText = "select * from ESPECIALIDAD";
miAdaptadorDatos.SelectCommand = comandoSQL;
miAdaptadorDatos.Fill(ds, "ESPECIALIDAD");
    return ds;


}


//Seccion

  public DataSet obtener_datosSeccion()
{
    ds.Clear();
   comandoSQL.CommandText = "select * from SECCION";
miAdaptadorDatos.SelectCommand = comandoSQL;
miAdaptadorDatos.Fill(ds, "SECCION");
    return ds;


}




//Usuarios
  public DataSet obtener_datosUsuario()
{
    ds.Clear();
   comandoSQL.CommandText = "select * from USUARIOS";
miAdaptadorDatos.SelectCommand = comandoSQL;
miAdaptadorDatos.Fill(ds, "USUARIOS");
    return ds;


}




        //Estudiante
        public void mantenimiento_datosEstudiante(String[] datos, String accion)
        {
            try
            {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO Estudiante (Nombre,Apellido,COD_ESTUDIANTE,ID_ESPECIALIDAD,ID_SECCION,ID_MODALIDAD,ID_AÑO,ID_USUARIOS) VALUE (" +
                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +
                        "'" + datos[3] + "'," +
                        "'" + datos[4] + "'," +
                        "'" + datos[5] + "'," +
                        "'" + datos[6] + "'," +
                        "'" + datos[7] + "'" +

                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE Estudiante SET " +
                        "Nombre        = '" + datos[1] + "'," +
                        "Apellido         = '" + datos[2] + "'," +
                        "COD_ESTUDIANTE        = '" + datos[3] + "'," +
                        "ID_ESPECIALIDAD        = '" + datos[4] + "'," +
                        "ID_SECCION       = '" + datos[5] + "'," +
                        "ID_MODALIDAD      = '" + datos[6] + "'," +
                        "ID_AÑO     = '" + datos[7] + "'" +
                        "WHERE ID_ESTUDIANTE = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE Estudiante FROM Estudiante WHERE ID_ESTUDIANTE='" + datos[0] + "'";
                }
                procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        //Docente
        public void mantenimientodatos_Docente(String[] datos, String accion) {
            try {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO DOCENTES (NOMBRES,APELLIDOS,CODIGO_DOCENTE,MATERIAS_ID,USUARIOS_ID) VALUE (" +
                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +
                        "'" + datos[3] + "'," +
                        "'" + datos[4] + "'," +
                         "'" + datos[5] + "'," +

                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE DOCENTES SET " +
                        "NOMBRES       = '" + datos[1] + "'," +
                        "APELLIDOS         = '" + datos[2] + "'," +
                         "CODIGO_DOCENTE         = '" + datos[3] + "'," +
                        "MATERIAS_ID       = '" + datos[4] + "'," +
                        "USUARIOS_ID       = '" + datos[5] + "'" +


                        "WHERE Id_DOCENTES = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE DOCENTES FROM DOCENTES WHERE Id_DOCENTES='" + datos[0] + "'";
                }
                procesarSQL(sql);
            } catch  (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
        //Materias
        public void mantenimientodatos_Materia(String[] datos, String accion)
        {
            try
            {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO MATERIAS (MATERIAS,ID_PERSONAL) VALUE (" +
                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'" +


                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE MATERIAS SET " +
                        "MATERIAS      = '" + datos[1] + "'," +
                        "ID_PERSONAL         = '" + datos[2] + "'" +


                        "WHERE Id_MATERIAS = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE MATERIAS FROM MATERIAS WHERE Id_MATERIAS='" + datos[0] + "'";
                }
                procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Notas
        public void mantenimientodatos_Notas(String[] datos, String accion)
        {
            try
            {
                String sql = "";
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO Notas (ID_MATERIA,ID_ESTUDIANTE,NOTA_1,NOTA_2,NOTA_3,PROMEDIO,ID_PERIODO) VALUE (" +
                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +
                        "'" + datos[3] + "'," +
                        "'" + datos[4] + "'," +
                        "'" + datos[5] + "'," +
                        "'" + datos[6] + "'," +
                        "'" + datos[7] + "'" +
                        "'" + ")";


                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE Notas SET " +
                        "ID_MATERIA      = '" + datos[1] + "'," +
                        "ID_ESTUDIANTE       = '" + datos[2] + "'," +
                        "NOTA_1       = '" + datos[3] + "'," +
                        "NOTA_2       = '" + datos[4] + "'," +
                        "NOTA_3       = '" + datos[5] + "'," +
                        "PROMEDIO      = '" + datos[6] + "'," +
                        "ID_PROMEDIO       = '" + datos[7] + "'" +

                        "WHERE Id_NOTAS = '" + datos[0] + "'"
                        + "'";
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE Notas FROM Notas WHERE Id_NOTAS='" + datos[0] + "'";
                }
                procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Notas_Promedio
        public void mantenimientodatos_NotasPromedio(String[] datos, String accion)
        {
            try { 
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO NOTAS_PERIODO (NOTA_PERIODO1,NOTA_PERIODO2,NOTA_PERIODO3,NOTA_PERIODO4,PROMEDIO_FINAL) VALUE (" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    "'" + ")";


            }
            else if (accion == "modificar")
            {
                sql = "UPDATE NOTAS_PERIODO SET " +
                    "NOTA_PERIODO1      = '" + datos[1] + "'," +
                    "NOTA_PERIODO2      = '" + datos[2] + "'," +
                    "NOTA_PERIODO3       = '" + datos[3] + "'," +
                    "NOTA_PERIODO4       = '" + datos[4] + "'," +
                    "PROMEDIOFINAL       = '" + datos[5] + "'" +
                    

                    "WHERE ID_PERIODO = '" + datos[0] + "'"
                    + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Notas FROM Notas WHERE Id_NOTAS='" + datos[0] + "'";
            }
            procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //Año
        public void mantenimientodatos_Año(String[] datos, String accion)
        {
            try { 
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO AÑO (AÑO) VALUE (" +
                    "'" + datos[1] + "'" +
                     ")";


            }
            else if (accion == "modificar")
            {
                sql = "UPDATE AÑO SET " +
                    "AÑO      = '" + datos[1] + "'" +
                    
                    "WHERE Id_AÑO = '" + datos[0] + "'"
                    + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE AÑO FROM AÑO WHERE Id_AÑO='" + datos[0] + "'";
            }
            procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Modalidad
        public void mantenimientodatos_Modalidad(String[] datos, String accion)
        {
            try { 
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO MODALIDAD (MODALIDAD) VALUE (" +
                    "'" + datos[1] + "'" +
                     ")";


            }
            else if (accion == "modificar")
            {
                sql = "UPDATE MODALIDAD SET " +
                    "MODALIDAD      = '" + datos[1] + "'" +

                    "WHERE Id_MODALIDAD = '" + datos[0] + "'"
                    + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE MODALIDAD FROM MODALIDAD WHERE Id_MODALIDAD='" + datos[0] + "'";
            }
            procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Especialidad
        public void mantenimientodatos_Especialidad(String[] datos, String accion)
        {
            try { 
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO ESPECIALIDAD (ESPECIALIDAD) VALUE (" +
                    "'" + datos[1] + "'" +
                     ")";


            }
            else if (accion == "modificar")
            {
                sql = "UPDATE ESPECIALIDAD SET " +
                    "ESPECIALIDAD     = '" + datos[1] + "'" +

                    "WHERE Id_ESPECIALIDAD = '" + datos[0] + "'"
                    + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE ESPECIALIDAD FROM ESPECIALIDAD WHERE Id_ESPECIALIDAD='" + datos[0] + "'";
            }
            procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Seccion
        public void mantenimientodatos_Seccion(String[] datos, String accion)
        {
            try { 
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO SECCION (SECCION) VALUE (" +
                    "'" + datos[1] + "'" +
                     ")";


            }
            else if (accion == "modificar")
            {
                sql = "UPDATE SECCION SET " +
                    "SECCION      = '" + datos[1] + "'" +

                    "WHERE Id_SECCION = '" + datos[0] + "'"
                    + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE SECCION FROM SECCION WHERE Id_SECCION='" + datos[0] + "'";
            }
            procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Usuarios
        public void mantenimientodatos_Usuarios(String[] datos, String accion)
        {
            try { 
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO USUARIOS (USUARIO,CONTRASEÑA) VALUE (" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'" +
                     ")";


            }
            else if (accion == "modificar")
            {
                sql = "UPDATE USUARIOS SET " +
                    "USUARIO      = '" + datos[1] + "'," +
                    "CONTRASEÑA      = '" + datos[2] + "'" +

                    "WHERE Id_USUARIO = '" + datos[0] + "'"
                    + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE USUARIOS FROM USUARIOS WHERE Id_USUARIOS='" + datos[0] + "'";
            }
            procesarSQL(sql);
            }
            catch (IndexOutOfRangeException ior) { MessageBox.Show(ior.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void procesarSQL(String sql)
        {
            comandoSQL.Connection = miConexion;
            comandoSQL.CommandText = sql;
            comandoSQL.ExecuteNonQuery();
        }
    }

    }




