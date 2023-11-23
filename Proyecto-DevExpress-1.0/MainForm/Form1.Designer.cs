namespace MainForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barButtonItem1Cerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1Empleados = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.BBtnEmpleados = new DevExpress.XtraBars.BarButtonItem();
            this.BBtnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageEmpleados = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1Clientes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1Config = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1Empleados,
            this.barButtonItem1Cerrar,
            this.barButtonItem2,
            this.skinRibbonGalleryBarItem1,
            this.BBtnEmpleados,
            this.BBtnClientes,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageEmpleados,
            this.ribbonPage1Clientes,
            this.ribbonPage1Config});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.barButtonItem1Cerrar);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.barButtonItem2);
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(1269, 162);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.barButtonItem1Cerrar);
            this.applicationMenu1.ItemLinks.Add(this.barButtonItem2);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem1Cerrar
            // 
            this.barButtonItem1Cerrar.Caption = "Cerrar";
            this.barButtonItem1Cerrar.Id = 2;
            this.barButtonItem1Cerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1Cerrar.ImageOptions.Image")));
            this.barButtonItem1Cerrar.Name = "barButtonItem1Cerrar";
            this.barButtonItem1Cerrar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem1Cerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1Cerrar_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ayuda";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem1Empleados
            // 
            this.barButtonItem1Empleados.Caption = "Agregar Empleado";
            this.barButtonItem1Empleados.Id = 1;
            this.barButtonItem1Empleados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1Empleados.ImageOptions.Image")));
            this.barButtonItem1Empleados.Name = "barButtonItem1Empleados";
            this.barButtonItem1Empleados.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem1Empleados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1Empleados_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 4;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // BBtnEmpleados
            // 
            this.BBtnEmpleados.Caption = "Empleados";
            this.BBtnEmpleados.Id = 5;
            this.BBtnEmpleados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BBtnEmpleados.ImageOptions.Image")));
            this.BBtnEmpleados.Name = "BBtnEmpleados";
            this.BBtnEmpleados.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BBtnEmpleados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BBtnEmpleados_ItemClick);
            // 
            // BBtnClientes
            // 
            this.BBtnClientes.Caption = "Clientes";
            this.BBtnClientes.Id = 6;
            this.BBtnClientes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BBtnClientes.ImageOptions.Image")));
            this.BBtnClientes.Name = "BBtnClientes";
            this.BBtnClientes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BBtnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BBtnClientes_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Form2";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPageEmpleados
            // 
            this.ribbonPageEmpleados.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageEmpleados.Image")));
            this.ribbonPageEmpleados.Name = "ribbonPageEmpleados";
            this.ribbonPageEmpleados.Text = "Empleados";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BBtnEmpleados);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1Clientes
            // 
            this.ribbonPage1Clientes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage1Clientes.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1Clientes.Image")));
            this.ribbonPage1Clientes.Name = "ribbonPage1Clientes";
            this.ribbonPage1Clientes.Text = "Clientes";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.BBtnClientes);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPage1Config
            // 
            this.ribbonPage1Config.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1Config.Name = "ribbonPage1Config";
            this.ribbonPage1Config.Text = "Form2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Config";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 623);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageEmpleados;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1Empleados;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1Clientes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1Cerrar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1Config;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem BBtnEmpleados;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem BBtnClientes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

