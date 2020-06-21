namespace SistemaAcademico
{
    partial class InformeMaterias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet = new SistemaAcademico.DataSet();
            this.MATERIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MATERIASTableAdapter = new SistemaAcademico.DataSetTableAdapters.MATERIASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "rptMateria";
            reportDataSource1.Value = this.MATERIASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaAcademico.rptMateria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MATERIASBindingSource
            // 
            this.MATERIASBindingSource.DataMember = "MATERIAS";
            this.MATERIASBindingSource.DataSource = this.DataSet;
            // 
            // MATERIASTableAdapter
            // 
            this.MATERIASTableAdapter.ClearBeforeFill = true;
            // 
            // InformeMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeMaterias";
            this.Text = "InformeMaterias";
            this.Load += new System.EventHandler(this.InformeMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MATERIASBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.MATERIASTableAdapter MATERIASTableAdapter;
    }
}