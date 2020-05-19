using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class Form1 : Form
    {
        //
        
        //CONSTRUCTOR
        public Form1()
        {
            //tread (progress bar)
            Thread trd = new Thread(new ThreadStart (formRun));
            trd.Start();
            Thread.Sleep(9000);
            trd.Abort();

            //

            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void formRun()
        {
            Application.Run(new Welcome());

            throw new NotImplementedException();
        }

        //METODO PARA REDIMENCIONA EL FORMULARIO
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //EXCLUSION DE LA ESQUINA
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorForm.Region = region;
            this.Invalidate();


        }

        //COLOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        private void panelContenedorForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        //FECHA Y HORA ACTUAL
        private void tmFechayHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void btnDeslizanteMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 215)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 215)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //METODOS PARA LAS FUNCIONES DEL FORMULARIO
        int lx, ly;
        int sw, sh;

        //SIRVE PARA MAXIMIZAR EL FORMULARIO
        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
        }
        //SIRVE PARA MINIMIZAR EL FORMULARIO
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //SIRVE PARA VOLVER A LA POSICION INICIAL DEL FORMULARIO
        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarLogoINU();
        }
        private void btnMatricula_Click(object sender, EventArgs e)
        {
           Matricula fm = new Matricula();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }


        private void MostrarLogoINU()
        {
            AbrirFormEnPanel(new LogoINU());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarLogoINU();
           
        }
        

        //BtnClick
        private void button1_Click(object sender, EventArgs e)
        {
            Estudiantes fm = new Estudiantes();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profesores fm = new Profesores();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias fm = new Materias();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            NotasEstudiante Notas = new NotasEstudiante();
            Notas.ShowDialog();

        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {
        }


        //PARA ABRIR UN FORMULARIO EN UN PANEL
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.PanelContenedorPrincipal.Controls.Count > 0)
                this.PanelContenedorPrincipal.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedorPrincipal.Controls.Add(fh);
            this.PanelContenedorPrincipal.Tag = fh;
            fh.Show();
        }


    }



}
