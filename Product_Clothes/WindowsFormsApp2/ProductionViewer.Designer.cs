﻿namespace WindowsFormsApp2
{
    partial class ProductionViewer
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dB_accounting_material_financial_assetsDataSet = new WindowsFormsApp2.DB_accounting_material_financial_assetsDataSet();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.ReportProduction.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dB_accounting_material_financial_assetsDataSet
            // 
            this.dB_accounting_material_financial_assetsDataSet.DataSetName = "DB_accounting_material_financial_assetsDataSet";
            this.dB_accounting_material_financial_assetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "Production";
            this.productionBindingSource.DataSource = this.dB_accounting_material_financial_assetsDataSet;
            // 
            // ProductionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProductionViewer";
            this.Text = "ProductionViewer";
            this.Load += new System.EventHandler(this.ProductionViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_accounting_material_financial_assetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DB_accounting_material_financial_assetsDataSet dB_accounting_material_financial_assetsDataSet;
        private System.Windows.Forms.BindingSource productionBindingSource;
    }
}