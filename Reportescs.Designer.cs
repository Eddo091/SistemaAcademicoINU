namespace SistemaAcademico
{
    partial class Reportescs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet = new SistemaAcademico.DataSet();
            this.RPTNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RPTNotasTableAdapter = new SistemaAcademico.DataSetTableAdapters.RPTNotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPTNotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "rptNotas";
            reportDataSource2.Value = this.RPTNotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaAcademico.RptIncripcion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(713, 419);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RPTNotasBindingSource
            // 
            this.RPTNotasBindingSource.DataMember = "RPTNotas";
            this.RPTNotasBindingSource.DataSource = this.DataSet;
            // 
            // RPTNotasTableAdapter
            // 
            this.RPTNotasTableAdapter.ClearBeforeFill = true;
            // 
            // Reportescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 427);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportescs";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reportescs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPTNotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPTNotasBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.RPTNotasTableAdapter RPTNotasTableAdapter;
    }
}