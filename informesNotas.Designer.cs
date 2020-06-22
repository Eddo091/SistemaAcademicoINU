namespace SistemaAcademico
{
    partial class informesNotas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RPTNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RPTNotasTableAdapter = new SistemaAcademico.DataSetTableAdapters.RPTNotasTableAdapter();
            this.NotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotasTableAdapter = new SistemaAcademico.DataSetTableAdapters.NotasTableAdapter();
            this.MATERIASTableAdapter = new SistemaAcademico.DataSetTableAdapters.MATERIASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MATERIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPTNotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotasBindingSource)).BeginInit();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rptNotas";
            reportDataSource1.Value = this.RPTNotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaAcademico.RptIncripcion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(608, 416);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            // NotasBindingSource
            // 
            this.NotasBindingSource.DataMember = "Notas";
            this.NotasBindingSource.DataSource = this.DataSet;
            // 
            // NotasTableAdapter
            // 
            this.NotasTableAdapter.ClearBeforeFill = true;
            // 
            // MATERIASTableAdapter
            // 
            this.MATERIASTableAdapter.ClearBeforeFill = true;
            // 
            // informesNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 416);
            this.Controls.Add(this.reportViewer1);
            this.Name = "informesNotas";
            this.Text = "informesNotas";
            this.Load += new System.EventHandler(this.informesNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MATERIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPTNotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPTNotasBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.RPTNotasTableAdapter RPTNotasTableAdapter;
        private System.Windows.Forms.BindingSource NotasBindingSource;
        private DataSetTableAdapters.NotasTableAdapter NotasTableAdapter;
        private System.Windows.Forms.BindingSource MATERIASBindingSource;
        private DataSetTableAdapters.MATERIASTableAdapter MATERIASTableAdapter;
    }
}