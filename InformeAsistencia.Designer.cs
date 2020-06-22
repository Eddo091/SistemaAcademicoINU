namespace SistemaAcademico
{
    partial class InformeAsistencia
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
            this.ASISTENCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ASISTENCIATableAdapter = new SistemaAcademico.DataSetTableAdapters.ASISTENCIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASISTENCIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ASISTENCIABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaAcademico.Asistencia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 512);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ASISTENCIABindingSource
            // 
            this.ASISTENCIABindingSource.DataMember = "ASISTENCIA";
            this.ASISTENCIABindingSource.DataSource = this.DataSet;
            // 
            // ASISTENCIATableAdapter
            // 
            this.ASISTENCIATableAdapter.ClearBeforeFill = true;
            // 
            // InformeAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeAsistencia";
            this.Text = "InformeAsistencia";
            this.Load += new System.EventHandler(this.InformeAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASISTENCIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ASISTENCIABindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.ASISTENCIATableAdapter ASISTENCIATableAdapter;
    }
}