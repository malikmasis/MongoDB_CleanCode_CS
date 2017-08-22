namespace MongoDB_Clean_Code
{
    partial class ListRecord
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
            this.grcListRecord = new DevExpress.XtraGrid.GridControl();
            this.grvListRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grcListRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // grcListRecord
            // 
            this.grcListRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcListRecord.Location = new System.Drawing.Point(0, 0);
            this.grcListRecord.MainView = this.grvListRecord;
            this.grcListRecord.Name = "grcListRecord";
            this.grcListRecord.Size = new System.Drawing.Size(331, 193);
            this.grcListRecord.TabIndex = 0;
            this.grcListRecord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvListRecord});
            // 
            // grvListRecord
            // 
            this.grvListRecord.GridControl = this.grcListRecord;
            this.grvListRecord.Name = "grvListRecord";
            this.grvListRecord.OptionsView.ShowGroupPanel = false;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(13, 200);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 1;
            this.btnPdf.Text = "Pdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(126, 199);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(244, 200);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(75, 23);
            this.btnXml.TabIndex = 3;
            this.btnXml.Text = "Xml";
            this.btnXml.UseVisualStyleBackColor = true;
            // 
            // ListRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 243);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.grcListRecord);
            this.Name = "ListRecord";
            this.Text = "ListRecord";
            ((System.ComponentModel.ISupportInitialize)(this.grcListRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcListRecord;
        private DevExpress.XtraGrid.Views.Grid.GridView grvListRecord;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnXml;
    }
}