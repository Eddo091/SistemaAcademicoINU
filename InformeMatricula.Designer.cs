namespace SistemaAcademico
{
    partial class InformeMatricula
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
            this.Matricula_estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Matricula_estudianteTableAdapter = new SistemaAcademico.DataSetTableAdapters.Matricula_estudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matricula_estudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "rptMatricula";
            reportDataSource1.Value = this.Matricula_estudianteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaAcademico.RptMatricula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(766, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Matricula_estudianteBindingSource
            // 
            this.Matricula_estudianteBindingSource.DataMember = "Matricula_estudiante";
            this.Matricula_estudianteBindingSource.DataSource = this.DataSet;
            // 
            // Matricula_estudianteTableAdapter
            // 
            this.Matricula_estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // InformeMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 431);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeMatricula";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.InformeMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matricula_estudianteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Matricula_estudianteBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.Matricula_estudianteTableAdapter Matricula_estudianteTableAdapter;
    }
}