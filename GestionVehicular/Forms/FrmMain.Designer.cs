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
            testConnection.Location = new Point(12, 84);
            testConnection.Name = "testConnection";
            testConnection.Size = new Size(178, 63);
            testConnection.TabIndex = 2;
            testConnection.Text = "Probar Conexión a la DB";
            testConnection.UseVisualStyleBackColor = true;
            testConnection.Click += TestConnection_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarContribuyenteToolStripMenuItem, consultarPorContribuyenteYVehículosToolStripMenuItem, modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem, listadoDeContribuyenteYVehículoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(980, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarContribuyenteToolStripMenuItem
            // 
            agregarContribuyenteToolStripMenuItem.Name = "agregarContribuyenteToolStripMenuItem";
            agregarContribuyenteToolStripMenuItem.Size = new Size(195, 20);
            agregarContribuyenteToolStripMenuItem.Text = "Agregar contribuyente y vehículo";
            // 
            // consultarPorContribuyenteYVehículosToolStripMenuItem
            // 
            consultarPorContribuyenteYVehículosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarPorContribuyenteToolStripMenuItem, consultarPorVehículoToolStripMenuItem });
            consultarPorContribuyenteYVehículosToolStripMenuItem.Name = "consultarPorContribuyenteYVehículosToolStripMenuItem";
            consultarPorContribuyenteYVehículosToolStripMenuItem.Size = new Size(233, 20);
            consultarPorContribuyenteYVehículosToolStripMenuItem.Text = " Consultar por contribuyente y vehículos";
            // 
            // consultarPorContribuyenteToolStripMenuItem
            // 
            consultarPorContribuyenteToolStripMenuItem.Name = "consultarPorContribuyenteToolStripMenuItem";
            consultarPorContribuyenteToolStripMenuItem.Size = new Size(223, 22);
            consultarPorContribuyenteToolStripMenuItem.Text = "Consultar por contribuyente";
            // 
            // consultarPorVehículoToolStripMenuItem
            // 
            consultarPorVehículoToolStripMenuItem.Name = "consultarPorVehículoToolStripMenuItem";
            consultarPorVehículoToolStripMenuItem.Size = new Size(223, 22);
            consultarPorVehículoToolStripMenuItem.Text = "Consultar por vehículo";
            // 
            // modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem
            // 
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarContribuyenteToolStripMenuItem, modificarVehículoToolStripMenuItem });
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.Name = "modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem";
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.Size = new Size(293, 20);
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.Text = " Modificar datos de un contribuyente y de vehículos";
            // 
            // modificarContribuyenteToolStripMenuItem
            // 
            modificarContribuyenteToolStripMenuItem.Name = "modificarContribuyenteToolStripMenuItem";
            modificarContribuyenteToolStripMenuItem.Size = new Size(202, 22);
            modificarContribuyenteToolStripMenuItem.Text = "Modificar contribuyente";
            // 
            // modificarVehículoToolStripMenuItem
            // 
            modificarVehículoToolStripMenuItem.Name = "modificarVehículoToolStripMenuItem";
            modificarVehículoToolStripMenuItem.Size = new Size(202, 22);
            modificarVehículoToolStripMenuItem.Text = "Modificar vehículo";
            // 
            // listadoDeContribuyenteYVehículoToolStripMenuItem
            // 
            listadoDeContribuyenteYVehículoToolStripMenuItem.Name = "listadoDeContribuyenteYVehículoToolStripMenuItem";
            listadoDeContribuyenteYVehículoToolStripMenuItem.Size = new Size(207, 20);
            listadoDeContribuyenteYVehículoToolStripMenuItem.Text = "Listado de contribuyente y vehículo";
            listadoDeContribuyenteYVehículoToolStripMenuItem.Click += listadoDeContribuyenteYVehículoToolStripMenuItem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 450);
            Controls.Add(testConnection);
            Controls.Add(menuStrip1);
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
    }
}
