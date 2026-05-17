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
            salirToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            salirDeLaAppToolStripMenuItem = new ToolStripMenuItem();
            lblUsuarioActual = new Label();
            btnCrearUsuario = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // testConnection
            // 
            testConnection.Location = new Point(14, 268);
            testConnection.Margin = new Padding(3, 4, 3, 4);
            testConnection.Name = "testConnection";
            testConnection.Size = new Size(169, 56);
            testConnection.TabIndex = 2;
            testConnection.Text = "Probar Conexión a la DB";
            testConnection.UseVisualStyleBackColor = true;
            testConnection.Click += TestConnection_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarContribuyenteToolStripMenuItem, consultarPorContribuyenteYVehículosToolStripMenuItem, modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem, listadoDeContribuyenteYVehículoToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1354, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarContribuyenteToolStripMenuItem
            // 
            agregarContribuyenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarContribuyenteToolStripMenuItem1, agregarVehículoToolStripMenuItem });
            agregarContribuyenteToolStripMenuItem.Name = "agregarContribuyenteToolStripMenuItem";
            agregarContribuyenteToolStripMenuItem.Size = new Size(120, 24);
            agregarContribuyenteToolStripMenuItem.Text = "Agregar Datos";
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
            consultarPorContribuyenteYVehículosToolStripMenuItem.Size = new Size(90, 24);
            consultarPorContribuyenteYVehículosToolStripMenuItem.Text = " Consultas";
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
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.Size = new Size(134, 24);
            modificarDatosDeUnContribuyenteYDeVehículosToolStripMenuItem.Text = " Modificar Datos";
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
            listadoDeContribuyenteYVehículoToolStripMenuItem.Size = new Size(151, 24);
            listadoDeContribuyenteYVehículoToolStripMenuItem.Text = "Listados Unificados";
            listadoDeContribuyenteYVehículoToolStripMenuItem.Click += listadoDeContribuyenteYVehículoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, salirDeLaAppToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(224, 26);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // salirDeLaAppToolStripMenuItem
            // 
            salirDeLaAppToolStripMenuItem.Name = "salirDeLaAppToolStripMenuItem";
            salirDeLaAppToolStripMenuItem.Size = new Size(224, 26);
            salirDeLaAppToolStripMenuItem.Text = "Salir de la App";
            salirDeLaAppToolStripMenuItem.Click += salirDeLaAppToolStripMenuItem_Click;
            // 
            // lblUsuarioActual
            // 
            lblUsuarioActual.AutoSize = true;
            lblUsuarioActual.Location = new Point(14, 65);
            lblUsuarioActual.Name = "lblUsuarioActual";
            lblUsuarioActual.Size = new Size(0, 20);
            lblUsuarioActual.TabIndex = 4;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(14, 204);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(169, 46);
            btnCrearUsuario.TabIndex = 5;
            btnCrearUsuario.Text = "Crear Nuevo Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 583);
            Controls.Add(btnCrearUsuario);
            Controls.Add(lblUsuarioActual);
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
        private Label lblUsuarioActual;
        private Button btnCrearUsuario;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirDeLaAppToolStripMenuItem;
    }
}
