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
            agregarVehículoToolStripMenuItem = new ToolStripMenuItem();
            consultarPorContribuyenteYVehículosToolStripMenuItem = new ToolStripMenuItem();
            consultarPorContribuyenteToolStripMenuItem = new ToolStripMenuItem();
            consultarPorVehículoToolStripMenuItem = new ToolStripMenuItem();
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem = new ToolStripMenuItem();
            modificarContribuyenteToolStripMenuItem = new ToolStripMenuItem();
            modificarVehículoToolStripMenuItem = new ToolStripMenuItem();
            listadoDeContribuyenteYVehículoToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarContribuyenteToolStripMenuItem, consultarPorContribuyenteYVehículosToolStripMenuItem, modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem, listadoDeContribuyenteYVehículoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1290, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarContribuyenteToolStripMenuItem
            // 
            agregarContribuyenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarContribuyenteToolStripMenuItem1, agregarVehículoToolStripMenuItem });
            agregarContribuyenteToolStripMenuItem.Name = "agregarContribuyenteToolStripMenuItem";
            agregarContribuyenteToolStripMenuItem.Size = new Size(242, 24);
            agregarContribuyenteToolStripMenuItem.Text = "Agregar contribuyente y vehículo";
            // 
            // agregarContribuyenteToolStripMenuItem1
            // 
            agregarContribuyenteToolStripMenuItem1.Name = "agregarContribuyenteToolStripMenuItem1";
            agregarContribuyenteToolStripMenuItem1.Size = new Size(241, 26);
            agregarContribuyenteToolStripMenuItem1.Text = "Agregar contribuyente";
            agregarContribuyenteToolStripMenuItem1.Click += agregarContribuyenteToolStripMenuItem1_Click;
            // 
            // agregarVehículoToolStripMenuItem
            // 
            agregarVehículoToolStripMenuItem.Name = "agregarVehículoToolStripMenuItem";
            agregarVehículoToolStripMenuItem.Size = new Size(241, 26);
            agregarVehículoToolStripMenuItem.Text = "Agregar vehículo";
            agregarVehículoToolStripMenuItem.Click += agregarVehículoToolStripMenuItem_Click;
            // 
            // consultarPorContribuyenteYVehículosToolStripMenuItem
            // 
            consultarPorContribuyenteYVehículosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarPorContribuyenteToolStripMenuItem, consultarPorVehículoToolStripMenuItem });
            consultarPorContribuyenteYVehículosToolStripMenuItem.Name = "consultarPorContribuyenteYVehículosToolStripMenuItem";
            consultarPorContribuyenteYVehículosToolStripMenuItem.Size = new Size(287, 24);
            consultarPorContribuyenteYVehículosToolStripMenuItem.Text = " Consultar por contribuyente y vehículos";
            // 
            // consultarPorContribuyenteToolStripMenuItem
            // 
            consultarPorContribuyenteToolStripMenuItem.Name = "consultarPorContribuyenteToolStripMenuItem";
            consultarPorContribuyenteToolStripMenuItem.Size = new Size(276, 26);
            consultarPorContribuyenteToolStripMenuItem.Text = "Consultar por contribuyente";
            consultarPorContribuyenteToolStripMenuItem.Click += consultarPorContribuyenteToolStripMenuItem_Click;
            // 
            // consultarPorVehículoToolStripMenuItem
            // 
            consultarPorVehículoToolStripMenuItem.Name = "consultarPorVehículoToolStripMenuItem";
            consultarPorVehículoToolStripMenuItem.Size = new Size(276, 26);
            consultarPorVehículoToolStripMenuItem.Text = "Consultar por vehículo";
            consultarPorVehículoToolStripMenuItem.Click += consultarPorVehículoToolStripMenuItem_Click;
            // 
            // modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem
            // 
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarContribuyenteToolStripMenuItem, modificarVehículoToolStripMenuItem });
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.Name = "modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem";
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.Size = new Size(365, 24);
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.Text = " Modificar datos de un contribuyente y de vehículos";
            // 
            // modificarContribuyenteToolStripMenuItem
            // 
            modificarContribuyenteToolStripMenuItem.Name = "modificarContribuyenteToolStripMenuItem";
            modificarContribuyenteToolStripMenuItem.Size = new Size(251, 26);
            modificarContribuyenteToolStripMenuItem.Text = "Modificar contribuyente";
            modificarContribuyenteToolStripMenuItem.Click += modificarContribuyenteToolStripMenuItem_Click;
            // 
            // modificarVehículoToolStripMenuItem
            // 
            modificarVehículoToolStripMenuItem.Name = "modificarVehículoToolStripMenuItem";
            modificarVehículoToolStripMenuItem.Size = new Size(251, 26);
            modificarVehículoToolStripMenuItem.Text = "Modificar vehículo";
            modificarVehículoToolStripMenuItem.Click += modificarVehículoToolStripMenuItem_Click;
            // 
            // listadoDeContribuyenteYVehículoToolStripMenuItem
            // 
            listadoDeContribuyenteYVehículoToolStripMenuItem.Name = "listadoDeContribuyenteYVehículoToolStripMenuItem";
            listadoDeContribuyenteYVehículoToolStripMenuItem.Size = new Size(257, 24);
            listadoDeContribuyenteYVehículoToolStripMenuItem.Text = "Listado de contribuyente y vehículo";
            listadoDeContribuyenteYVehículoToolStripMenuItem.Click += listadoDeContribuyenteYVehículoToolStripMenuItem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 583);
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
        private ToolStripMenuItem modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem;
        private ToolStripMenuItem modificarContribuyenteToolStripMenuItem;
        private ToolStripMenuItem modificarVehículoToolStripMenuItem;
        private ToolStripMenuItem listadoDeContribuyenteYVehículoToolStripMenuItem;
        private ToolStripMenuItem agregarContribuyenteToolStripMenuItem1;
        private ToolStripMenuItem agregarVehículoToolStripMenuItem;
    }
}
