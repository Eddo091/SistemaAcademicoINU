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
    
    public partial class Asignaturas : Form
    {
        Conexion objconexion = new Conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable(); //Materias
        public Asignaturas()
        {
            InitializeComponent();
        }
    }
}
