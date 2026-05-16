namespace GestionVehicular
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            testConnection = new Button();
            menuStrip1 = new MenuStrip();
            agregarContribuyenteToolStripMenuItem = new ToolStripMenuItem();
            agregarContribuyenteToolStripMenuItem1 = new ToolStripMenuItem();
            agregarContribuyentesToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            consultarPorContribuyenteYVehículosToolStripMenuItem = new ToolStripMenuItem();
            consultarPorContribuyenteToolStripMenuItem = new ToolStripMenuItem();
            consultarPorVehículoToolStripMenuItem = new ToolStripMenuItem();
            listadoDeContribuyenteYVehículoToolStripMenuItem = new ToolStripMenuItem();
            listadoPorContribuyentesToolStripMenuItem = new ToolStripMenuItem();
            listadoPorVehiculosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // testConnection
            // 
            testConnection.Location = new Point(14, 112);
            testConnection.Margin = new Padding(3, 4, 3, 4);
            testConnection.Name = "testConnection";
            testConnection.Size = new Size(203, 84);
            testConnection.TabIndex = 2;
            testConnection.Text = "Probar Conexión a la DB";
            testConnection.UseVisualStyleBackColor = true;
            testConnection.Click += TestConnection_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarContribuyenteToolStripMenuItem, consultarPorContribuyenteYVehículosToolStripMenuItem, listadoDeContribuyenteYVehículoToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1120, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarContribuyenteToolStripMenuItem
            // 
            agregarContribuyenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarContribuyenteToolStripMenuItem1, agregarToolStripMenuItem });
            agregarContribuyenteToolStripMenuItem.Name = "agregarContribuyenteToolStripMenuItem";
            agregarContribuyenteToolStripMenuItem.Size = new Size(137, 24);
            agregarContribuyenteToolStripMenuItem.Text = "Gestion de Datos";
            // 
            // agregarContribuyenteToolStripMenuItem1
            // 
            agregarContribuyenteToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { agregarContribuyentesToolStripMenuItem, modificarToolStripMenuItem });
            agregarContribuyenteToolStripMenuItem1.Name = "agregarContribuyenteToolStripMenuItem1";
            agregarContribuyenteToolStripMenuItem1.Size = new Size(232, 26);
            agregarContribuyenteToolStripMenuItem1.Text = "Menú Contribuyentes";
            // 
            // agregarContribuyentesToolStripMenuItem
            // 
            agregarContribuyentesToolStripMenuItem.Name = "agregarContribuyentesToolStripMenuItem";
            agregarContribuyentesToolStripMenuItem.Size = new Size(224, 26);
            agregarContribuyentesToolStripMenuItem.Text = "Agregar";
            agregarContribuyentesToolStripMenuItem.Click += agregarContribuyentesToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(224, 26);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem1, modificarToolStripMenuItem1 });
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(232, 26);
            agregarToolStripMenuItem.Text = "Menú Vehiculos";
            // 
            // agregarToolStripMenuItem1
            // 
            agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            agregarToolStripMenuItem1.Size = new Size(224, 26);
            agregarToolStripMenuItem1.Text = "Agregar";
            agregarToolStripMenuItem1.Click += agregarToolStripMenuItem1_Click;
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(224, 26);
            modificarToolStripMenuItem1.Text = "Modificar";
            modificarToolStripMenuItem1.Click += modificarToolStripMenuItem1_Click;
            // 
            // consultarPorContribuyenteYVehículosToolStripMenuItem
            // 
            consultarPorContribuyenteYVehículosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarPorContribuyenteToolStripMenuItem, consultarPorVehículoToolStripMenuItem });
            consultarPorContribuyenteYVehículosToolStripMenuItem.Name = "consultarPorContribuyenteYVehículosToolStripMenuItem";
            consultarPorContribuyenteYVehículosToolStripMenuItem.Size = new Size(90, 24);
            consultarPorContribuyenteYVehículosToolStripMenuItem.Text = " Consultas";
            // 
            // consultarPorContribuyenteToolStripMenuItem
            // 
            consultarPorContribuyenteToolStripMenuItem.Name = "consultarPorContribuyenteToolStripMenuItem";
            consultarPorContribuyenteToolStripMenuItem.Size = new Size(276, 26);
            consultarPorContribuyenteToolStripMenuItem.Text = "Consultar por contribuyente";
            // 
            // consultarPorVehículoToolStripMenuItem
            // 
            consultarPorVehículoToolStripMenuItem.Name = "consultarPorVehículoToolStripMenuItem";
            consultarPorVehículoToolStripMenuItem.Size = new Size(276, 26);
            consultarPorVehículoToolStripMenuItem.Text = "Consultar por vehículo";
            // 
            // listadoDeContribuyenteYVehículoToolStripMenuItem
            // 
            listadoDeContribuyenteYVehículoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoPorContribuyentesToolStripMenuItem, listadoPorVehiculosToolStripMenuItem });
            listadoDeContribuyenteYVehículoToolStripMenuItem.Name = "listadoDeContribuyenteYVehículoToolStripMenuItem";
            listadoDeContribuyenteYVehículoToolStripMenuItem.Size = new Size(77, 24);
            listadoDeContribuyenteYVehículoToolStripMenuItem.Text = "Listados";
            listadoDeContribuyenteYVehículoToolStripMenuItem.Click += listadoDeContribuyenteYVehículoToolStripMenuItem_Click;
            // 
            // listadoPorContribuyentesToolStripMenuItem
            // 
            listadoPorContribuyentesToolStripMenuItem.Name = "listadoPorContribuyentesToolStripMenuItem";
            listadoPorContribuyentesToolStripMenuItem.Size = new Size(270, 26);
            listadoPorContribuyentesToolStripMenuItem.Text = "Listado por Contribuyentes";
            // 
            // listadoPorVehiculosToolStripMenuItem
            // 
            listadoPorVehiculosToolStripMenuItem.Name = "listadoPorVehiculosToolStripMenuItem";
            listadoPorVehiculosToolStripMenuItem.Size = new Size(270, 26);
            listadoPorVehiculosToolStripMenuItem.Text = "Listado por Vehiculos";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 600);
            Controls.Add(testConnection);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            Text = "Formulario Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button testConnection;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarContribuyenteToolStripMenuItem;
        private ToolStripMenuItem consultarPorContribuyenteYVehículosToolStripMenuItem;
        private ToolStripMenuItem consultarPorContribuyenteToolStripMenuItem;
        private ToolStripMenuItem consultarPorVehículoToolStripMenuItem;
        private ToolStripMenuItem listadoDeContribuyenteYVehículoToolStripMenuItem;
        private ToolStripMenuItem agregarContribuyenteToolStripMenuItem1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem agregarContribuyentesToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem listadoPorContribuyentesToolStripMenuItem;
        private ToolStripMenuItem listadoPorVehiculosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
