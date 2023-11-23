namespace Reporte.Views.Graficas
{
    partial class Graficas1
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
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(461, 399);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(149, 46);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Imprimir";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 45);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(598, 348);
            this.dgv1.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(306, 399);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(149, 46);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Graficas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 465);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnPrint);
            this.Name = "Graficas1";
            this.Text = "Graficas1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.DataGridView dgv1;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
    }
}