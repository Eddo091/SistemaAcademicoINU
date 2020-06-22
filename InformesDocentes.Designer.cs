namespace SistemaAcademico
{
    partial class InformesDocentes
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
            this.MATERIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new SistemaAcademico.DataSet();
            this.DOCENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DOCENTESTableAdapter = new SistemaAcademico.DataSetTableAdapters.DOCENTESTableAdapter();
            this.MATERIASTableAdapter = new SistemaAcademico.DataSetTableAdapters.MATERIASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCENTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MATERIASBindingSource
            // 
            this.MATERIASBindingSource.DataMember = "MATERIAS";
            this.MATERIASBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DOCENTESBindingSource
            // 
            this.DOCENTESBindingSource.DataMember = "DOCENTES";
            this.DOCENTESBindingSource.DataSource = this.DataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rptProfes";
            reportDataSource1.Value = this.DOCENTESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaAcademico.reportedocentes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(624, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // DOCENTESTableAdapter
            // 
            this.DOCENTESTableAdapter.ClearBeforeFill = true;
            // 
            // MATERIASTableAdapter
            // 
            this.MATERIASTableAdapter.ClearBeforeFill = true;
            // 
            // InformesDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 403);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformesDocentes";
            this.Text = "InformesDocentes";
            this.Load += new System.EventHandler(this.InformesDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MATERIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCENTESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DOCENTESBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.DOCENTESTableAdapter DOCENTESTableAdapter;
        private System.Windows.Forms.BindingSource MATERIASBindingSource;
        private DataSetTableAdapters.MATERIASTableAdapter MATERIASTableAdapter;
    }
}