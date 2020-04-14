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

       /* DataSet ds = new DataSet();//copia de la arquitectura de la base de datos en memoria RAM.

        public Conexion()
        {
            string cadena_conexion =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbfilename=|DataDirectory|\db_academico.mdf;Integrated Security=True";
            
            miConexion.ConnectionString = cadena_conexion;
            miConexion.Open();//abrimos la conexion a la base de datos...

            Parametos_estudiantes();
            Parametos_materias();

            public DataSet obtener_datos()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;
            comandoSQL.CommandText = "select * from Estudiantes";


            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "Estudiantes");
            return ds;
        }
        public DataSet obtener_materias()
        {
            ds.Clear();
            comandoSQL.Connection = miConexion;
            comandoSQL.CommandText = "select * from materias";


            miAdaptadorDatos.SelectCommand = comandoSQL;
            miAdaptadorDatos.Fill(ds, "materias");
            return ds;
        }*/

    }
    }


