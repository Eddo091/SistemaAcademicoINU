namespace SistemaAcademico
{
    partial class Asitencias
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
            System.Windows.Forms.Label mATERIASLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label nombre_Label;
            System.Windows.Forms.Label eSPECIALIDADLabel;
            System.Windows.Forms.Label sECCIONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asitencias));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataSet = new SistemaAcademico.DataSet();
            this.aSISTENCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSISTENCIATableAdapter = new SistemaAcademico.DataSetTableAdapters.ASISTENCIATableAdapter();
            this.tableAdapterManager = new SistemaAcademico.DataSetTableAdapters.TableAdapterManager();
            this.aSISTENCIABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aSISTENCIABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new SistemaAcademico.DataSetTableAdapters.EstudianteTableAdapter();
            this.eSPECIALIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSPECIALIDADTableAdapter = new SistemaAcademico.DataSetTableAdapters.ESPECIALIDADTableAdapter();
            this.sECCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sECCIONTableAdapter = new SistemaAcademico.DataSetTableAdapters.SECCIONTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.mATERIASComboBox = new System.Windows.Forms.ComboBox();
            this.nombre_ComboBox = new System.Windows.Forms.ComboBox();
            this.apellidoComboBox = new System.Windows.Forms.ComboBox();
            this.eSPECIALIDADComboBox = new System.Windows.Forms.ComboBox();
            this.sECCIONComboBox = new System.Windows.Forms.ComboBox();
            mATERIASLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            nombre_Label = new System.Windows.Forms.Label();
            eSPECIALIDADLabel = new System.Windows.Forms.Label();
            sECCIONLabel = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingNavigator)).BeginInit();
            this.aSISTENCIABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIALIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECCIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mATERIASLabel
            // 
            mATERIASLabel.AutoSize = true;
            mATERIASLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mATERIASLabel.Location = new System.Drawing.Point(25, 161);
            mATERIASLabel.Name = "mATERIASLabel";
            mATERIASLabel.Size = new System.Drawing.Size(75, 15);
            mATERIASLabel.TabIndex = 58;
            mATERIASLabel.Text = "MATERIAS:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(287, 80);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(71, 15);
            apellidoLabel.TabIndex = 56;
            apellidoLabel.Text = "APELLIDO:";
            // 
            // nombre_Label
            // 
            nombre_Label.AutoSize = true;
            nombre_Label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_Label.Location = new System.Drawing.Point(25, 80);
            nombre_Label.Name = "nombre_Label";
            nombre_Label.Size = new System.Drawing.Size(65, 15);
            nombre_Label.TabIndex = 54;
            nombre_Label.Text = "NOMBRE:";
            // 
            // eSPECIALIDADLabel
            // 
            eSPECIALIDADLabel.AutoSize = true;
            eSPECIALIDADLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eSPECIALIDADLabel.Location = new System.Drawing.Point(25, 116);
            eSPECIALIDADLabel.Name = "eSPECIALIDADLabel";
            eSPECIALIDADLabel.Size = new System.Drawing.Size(100, 15);
            eSPECIALIDADLabel.TabIndex = 64;
            eSPECIALIDADLabel.Text = "ESPECIALIDAD:";
            // 
            // sECCIONLabel
            // 
            sECCIONLabel.AutoSize = true;
            sECCIONLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sECCIONLabel.Location = new System.Drawing.Point(287, 120);
            sECCIONLabel.Name = "sECCIONLabel";
            sECCIONLabel.Size = new System.Drawing.Size(65, 15);
            sECCIONLabel.TabIndex = 65;
            sECCIONLabel.Text = "SECCION:";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.lblid);
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(665, 38);
            this.BarraTitulo.TabIndex = 53;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(623, -5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 52);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblid
            // 
            this.lblid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(609, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 16);
            this.lblid.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(225, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "ASISTENCIAS";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aSISTENCIABindingSource
            // 
            this.aSISTENCIABindingSource.DataMember = "ASISTENCIA";
            this.aSISTENCIABindingSource.DataSource = this.dataSet;
            // 
            // aSISTENCIATableAdapter
            // 
            this.aSISTENCIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AÑOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DOCENTESTableAdapter = null;
            this.tableAdapterManager.ESPECIALIDADTableAdapter = null;
            this.tableAdapterManager.EstudianteTableAdapter = null;
            this.tableAdapterManager.MATERIASTableAdapter = null;
            this.tableAdapterManager.MODALIDADTableAdapter = null;
            this.tableAdapterManager.NOTAS_PERIODOTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.SECCIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaAcademico.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // aSISTENCIABindingNavigator
            // 
            this.aSISTENCIABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aSISTENCIABindingNavigator.BindingSource = this.aSISTENCIABindingSource;
            this.aSISTENCIABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aSISTENCIABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aSISTENCIABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aSISTENCIABindingNavigatorSaveItem});
            this.aSISTENCIABindingNavigator.Location = new System.Drawing.Point(0, 38);
            this.aSISTENCIABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aSISTENCIABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aSISTENCIABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aSISTENCIABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aSISTENCIABindingNavigator.Name = "aSISTENCIABindingNavigator";
            this.aSISTENCIABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aSISTENCIABindingNavigator.Size = new System.Drawing.Size(665, 25);
            this.aSISTENCIABindingNavigator.TabIndex = 54;
            this.aSISTENCIABindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aSISTENCIABindingNavigatorSaveItem
            // 
            this.aSISTENCIABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aSISTENCIABindingNavigatorSaveItem.Enabled = false;
            this.aSISTENCIABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aSISTENCIABindingNavigatorSaveItem.Image")));
            this.aSISTENCIABindingNavigatorSaveItem.Name = "aSISTENCIABindingNavigatorSaveItem";
            this.aSISTENCIABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aSISTENCIABindingNavigatorSaveItem.Text = "Save Data";
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.dataSet;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // eSPECIALIDADBindingSource
            // 
            this.eSPECIALIDADBindingSource.DataMember = "ESPECIALIDAD";
            this.eSPECIALIDADBindingSource.DataSource = this.dataSet;
            // 
            // eSPECIALIDADTableAdapter
            // 
            this.eSPECIALIDADTableAdapter.ClearBeforeFill = true;
            // 
            // sECCIONBindingSource
            // 
            this.sECCIONBindingSource.DataMember = "SECCION";
            this.sECCIONBindingSource.DataSource = this.dataSet;
            // 
            // sECCIONTableAdapter
            // 
            this.sECCIONTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F);
            this.button1.Location = new System.Drawing.Point(281, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mATERIASComboBox
            // 
            this.mATERIASComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "MATERIAS", true));
            this.mATERIASComboBox.DataSource = this.aSISTENCIABindingSource;
            this.mATERIASComboBox.DisplayMember = "MATERIAS";
            this.mATERIASComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mATERIASComboBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mATERIASComboBox.FormattingEnabled = true;
            this.mATERIASComboBox.Location = new System.Drawing.Point(129, 153);
            this.mATERIASComboBox.Name = "mATERIASComboBox";
            this.mATERIASComboBox.Size = new System.Drawing.Size(121, 26);
            this.mATERIASComboBox.TabIndex = 5;
            // 
            // nombre_ComboBox
            // 
            this.nombre_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "Nombre ", true));
            this.nombre_ComboBox.DataSource = this.aSISTENCIABindingSource;
            this.nombre_ComboBox.DisplayMember = "Nombre ";
            this.nombre_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombre_ComboBox.FormattingEnabled = true;
            this.nombre_ComboBox.Location = new System.Drawing.Point(128, 77);
            this.nombre_ComboBox.Name = "nombre_ComboBox";
            this.nombre_ComboBox.Size = new System.Drawing.Size(119, 21);
            this.nombre_ComboBox.TabIndex = 1;
            // 
            // apellidoComboBox
            // 
            this.apellidoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "Apellido", true));
            this.apellidoComboBox.DataSource = this.aSISTENCIABindingSource;
            this.apellidoComboBox.DisplayMember = "Apellido";
            this.apellidoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apellidoComboBox.FormattingEnabled = true;
            this.apellidoComboBox.Location = new System.Drawing.Point(390, 81);
            this.apellidoComboBox.Name = "apellidoComboBox";
            this.apellidoComboBox.Size = new System.Drawing.Size(119, 21);
            this.apellidoComboBox.TabIndex = 2;
            // 
            // eSPECIALIDADComboBox
            // 
            this.eSPECIALIDADComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "ESPECIALIDAD", true));
            this.eSPECIALIDADComboBox.DataSource = this.aSISTENCIABindingSource;
            this.eSPECIALIDADComboBox.DisplayMember = "ESPECIALIDAD";
            this.eSPECIALIDADComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSPECIALIDADComboBox.FormattingEnabled = true;
            this.eSPECIALIDADComboBox.Location = new System.Drawing.Point(129, 114);
            this.eSPECIALIDADComboBox.Name = "eSPECIALIDADComboBox";
            this.eSPECIALIDADComboBox.Size = new System.Drawing.Size(121, 21);
            this.eSPECIALIDADComboBox.TabIndex = 3;
            // 
            // sECCIONComboBox
            // 
            this.sECCIONComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "SECCION", true));
            this.sECCIONComboBox.DataSource = this.aSISTENCIABindingSource;
            this.sECCIONComboBox.DisplayMember = "SECCION";
            this.sECCIONComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sECCIONComboBox.FormattingEnabled = true;
            this.sECCIONComboBox.Location = new System.Drawing.Point(390, 117);
            this.sECCIONComboBox.Name = "sECCIONComboBox";
            this.sECCIONComboBox.Size = new System.Drawing.Size(121, 21);
            this.sECCIONComboBox.TabIndex = 4;
            // 
            // Asitencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 424);
            this.Controls.Add(sECCIONLabel);
            this.Controls.Add(this.sECCIONComboBox);
            this.Controls.Add(eSPECIALIDADLabel);
            this.Controls.Add(this.eSPECIALIDADComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.apellidoComboBox);
            this.Controls.Add(this.nombre_ComboBox);
            this.Controls.Add(nombre_Label);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(mATERIASLabel);
            this.Controls.Add(this.mATERIASComboBox);
            this.Controls.Add(this.aSISTENCIABindingNavigator);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asitencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asitencias";
            this.Load += new System.EventHandler(this.Asitencias_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingNavigator)).EndInit();
            this.aSISTENCIABindingNavigator.ResumeLayout(false);
            this.aSISTENCIABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIALIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECCIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource aSISTENCIABindingSource;
        private DataSetTableAdapters.ASISTENCIATableAdapter aSISTENCIATableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aSISTENCIABindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aSISTENCIABindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private DataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.BindingSource eSPECIALIDADBindingSource;
        private DataSetTableAdapters.ESPECIALIDADTableAdapter eSPECIALIDADTableAdapter;
        private System.Windows.Forms.BindingSource sECCIONBindingSource;
        private DataSetTableAdapters.SECCIONTableAdapter sECCIONTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox mATERIASComboBox;
        private System.Windows.Forms.ComboBox nombre_ComboBox;
        private System.Windows.Forms.ComboBox apellidoComboBox;
        private System.Windows.Forms.ComboBox eSPECIALIDADComboBox;
        private System.Windows.Forms.ComboBox sECCIONComboBox;
    }
}