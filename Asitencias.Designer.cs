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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asitencias));
            System.Windows.Forms.Label nombre_Label;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label mATERIASLabel;
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataSet = new SistemaAcademico.DataSet();
            this.aSISTENCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSISTENCIATableAdapter = new SistemaAcademico.DataSetTableAdapters.ASISTENCIATableAdapter();
            this.tableAdapterManager = new SistemaAcademico.DataSetTableAdapters.TableAdapterManager();
            this.aSISTENCIABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aSISTENCIABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombre_TextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.mATERIASComboBox = new System.Windows.Forms.ComboBox();
            nombre_Label = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            mATERIASLabel = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSISTENCIABindingNavigator)).BeginInit();
            this.aSISTENCIABindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // nombre_Label
            // 
            nombre_Label.AutoSize = true;
            nombre_Label.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_Label.Location = new System.Drawing.Point(6, 82);
            nombre_Label.Name = "nombre_Label";
            nombre_Label.Size = new System.Drawing.Size(75, 18);
            nombre_Label.TabIndex = 54;
            nombre_Label.Text = "Nombre :";
            // 
            // nombre_TextBox
            // 
            this.nombre_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "Nombre ", true));
            this.nombre_TextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_TextBox.Location = new System.Drawing.Point(87, 79);
            this.nombre_TextBox.Name = "nombre_TextBox";
            this.nombre_TextBox.Size = new System.Drawing.Size(121, 26);
            this.nombre_TextBox.TabIndex = 55;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(6, 116);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(70, 18);
            apellidoLabel.TabIndex = 56;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(87, 111);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(121, 26);
            this.apellidoTextBox.TabIndex = 57;
            // 
            // mATERIASLabel
            // 
            mATERIASLabel.AutoSize = true;
            mATERIASLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mATERIASLabel.Location = new System.Drawing.Point(223, 82);
            mATERIASLabel.Name = "mATERIASLabel";
            mATERIASLabel.Size = new System.Drawing.Size(98, 18);
            mATERIASLabel.TabIndex = 58;
            mATERIASLabel.Text = "MATERIAS:";
            // 
            // mATERIASComboBox
            // 
            this.mATERIASComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aSISTENCIABindingSource, "MATERIAS", true));
            this.mATERIASComboBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mATERIASComboBox.FormattingEnabled = true;
            this.mATERIASComboBox.Location = new System.Drawing.Point(327, 79);
            this.mATERIASComboBox.Name = "mATERIASComboBox";
            this.mATERIASComboBox.Size = new System.Drawing.Size(121, 26);
            this.mATERIASComboBox.TabIndex = 59;
            // 
            // Asitencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 424);
            this.Controls.Add(nombre_Label);
            this.Controls.Add(this.nombre_TextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
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
        private System.Windows.Forms.TextBox nombre_TextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.ComboBox mATERIASComboBox;
    }
}