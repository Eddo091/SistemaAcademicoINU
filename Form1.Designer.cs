namespace SistemaAcademico
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelContenedorForm = new System.Windows.Forms.Panel();
            this.PanelContenedorPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAcademica = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnNotas = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnStudents = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeslizanteMenu = new System.Windows.Forms.PictureBox();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFechayHora = new System.Windows.Forms.Timer(this.components);
            this.panelContenedorForm.SuspendLayout();
            this.PanelContenedorPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslizanteMenu)).BeginInit();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelContenedorForm.Controls.Add(this.PanelContenedorPrincipal);
            this.panelContenedorForm.Controls.Add(this.panel1);
            this.panelContenedorForm.Controls.Add(this.panelMenu);
            this.panelContenedorForm.Controls.Add(this.PanelBarraTitulo);
            this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorForm.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.Size = new System.Drawing.Size(1100, 600);
            this.panelContenedorForm.TabIndex = 7;
            this.panelContenedorForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorForm_Paint);
            // 
            // PanelContenedorPrincipal
            // 
            this.PanelContenedorPrincipal.Controls.Add(this.pictureBox9);
            this.PanelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorPrincipal.Location = new System.Drawing.Point(215, 62);
            this.PanelContenedorPrincipal.Name = "PanelContenedorPrincipal";
            this.PanelContenedorPrincipal.Size = new System.Drawing.Size(885, 480);
            this.PanelContenedorPrincipal.TabIndex = 7;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(69, 6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(734, 447);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(215, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 58);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFecha.Location = new System.Drawing.Point(557, 30);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(32, 25);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "??";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHora.Location = new System.Drawing.Point(645, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(32, 25);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "??";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.btnAcademica);
            this.panelMenu.Controls.Add(this.pictureBox7);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.pictureBox6);
            this.panelMenu.Controls.Add(this.btnNotas);
            this.panelMenu.Controls.Add(this.pictureBox5);
            this.panelMenu.Controls.Add(this.btnMaterias);
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.btnProfesores);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.btnStudents);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.btnMatricula);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnDeslizanteMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 62);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(215, 538);
            this.panelMenu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "INU";
            // 
            // btnAcademica
            // 
            this.btnAcademica.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAcademica.FlatAppearance.BorderSize = 0;
            this.btnAcademica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnAcademica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAcademica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcademica.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAcademica.Image = ((System.Drawing.Image)(resources.GetObject("btnAcademica.Image")));
            this.btnAcademica.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAcademica.Location = new System.Drawing.Point(7, 335);
            this.btnAcademica.Name = "btnAcademica";
            this.btnAcademica.Size = new System.Drawing.Size(205, 42);
            this.btnAcademica.TabIndex = 27;
            this.btnAcademica.Text = "  Academica";
            this.btnAcademica.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAcademica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcademica.UseVisualStyleBackColor = true;
            this.btnAcademica.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 345);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 30);
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReportes.Location = new System.Drawing.Point(7, 287);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(205, 42);
            this.btnReportes.TabIndex = 25;
            this.btnReportes.Text = "  Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Visible = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 297);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 30);
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // btnNotas
            // 
            this.btnNotas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnNotas.Image")));
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNotas.Location = new System.Drawing.Point(7, 239);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(205, 42);
            this.btnNotas.TabIndex = 23;
            this.btnNotas.Text = "  Notas";
            this.btnNotas.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 249);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 30);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // btnMaterias
            // 
            this.btnMaterias.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMaterias.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterias.Image")));
            this.btnMaterias.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMaterias.Location = new System.Drawing.Point(7, 191);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(205, 42);
            this.btnMaterias.TabIndex = 21;
            this.btnMaterias.Text = "  Materias";
            this.btnMaterias.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 201);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 30);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProfesores.FlatAppearance.BorderSize = 0;
            this.btnProfesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnProfesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnProfesores.Image = ((System.Drawing.Image)(resources.GetObject("btnProfesores.Image")));
            this.btnProfesores.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnProfesores.Location = new System.Drawing.Point(7, 143);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(205, 42);
            this.btnProfesores.TabIndex = 19;
            this.btnProfesores.Text = "  Profesores";
            this.btnProfesores.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 30);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // btnStudents
            // 
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnStudents.Image")));
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStudents.Location = new System.Drawing.Point(7, 95);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(205, 42);
            this.btnStudents.TabIndex = 17;
            this.btnStudents.Text = "  Estudiantes";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 30);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnMatricula
            // 
            this.btnMatricula.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnMatricula.Image")));
            this.btnMatricula.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMatricula.Location = new System.Drawing.Point(7, 47);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(203, 42);
            this.btnMatricula.TabIndex = 15;
            this.btnMatricula.Text = "  Matrícula";
            this.btnMatricula.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatricula.UseVisualStyleBackColor = true;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 30);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeslizanteMenu
            // 
            this.btnDeslizanteMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeslizanteMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeslizanteMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnDeslizanteMenu.Image")));
            this.btnDeslizanteMenu.Location = new System.Drawing.Point(169, 6);
            this.btnDeslizanteMenu.Name = "btnDeslizanteMenu";
            this.btnDeslizanteMenu.Size = new System.Drawing.Size(43, 37);
            this.btnDeslizanteMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDeslizanteMenu.TabIndex = 13;
            this.btnDeslizanteMenu.TabStop = false;
            this.btnDeslizanteMenu.Click += new System.EventHandler(this.btnDeslizanteMenu_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.PanelBarraTitulo.Controls.Add(this.btnNormal);
            this.PanelBarraTitulo.Controls.Add(this.btnCerrar);
            this.PanelBarraTitulo.Controls.Add(this.pictureBox8);
            this.PanelBarraTitulo.Controls.Add(this.label1);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1100, 62);
            this.PanelBarraTitulo.TabIndex = 4;
            this.PanelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBarraTitulo_Paint);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(932, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 62);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(975, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(43, 62);
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click_1);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(1018, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(43, 62);
            this.btnNormal.TabIndex = 7;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1061, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 62);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(9, 6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(62, 53);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "INSTITUTO NACIONAL DE USULUTAN";
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // tmFechayHora
            // 
            this.tmFechayHora.Enabled = true;
            this.tmFechayHora.Tick += new System.EventHandler(this.tmFechayHora_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelContenedorForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "Form1";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelContenedorForm.ResumeLayout(false);
            this.PanelContenedorPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslizanteMenu)).EndInit();
            this.PanelBarraTitulo.ResumeLayout(false);
            this.PanelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorForm;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmFechayHora;
        private System.Windows.Forms.PictureBox btnDeslizanteMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAcademica;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel PanelContenedorPrincipal;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

