namespace TP1
{
    partial class ContenedorPrincipal
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
            this.ventanaInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarArtporCódigoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarArtporCódigoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructivoDeUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.necesitoAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ventanaInicio
            // 
            this.ventanaInicio.Name = "ventanaInicio";
            this.ventanaInicio.Size = new System.Drawing.Size(48, 20);
            this.ventanaInicio.Text = "Inicio";
            this.ventanaInicio.Click += new System.EventHandler(this.listarArticulosMenu_Click);
            // 
            // ListadosToolStripMenuItem
            // 
            this.ListadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarArticulosToolStripMenuItem,
            this.listarMarcasToolStripMenuItem,
            this.listarCategoríasToolStripMenuItem});
            this.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem";
            this.ListadosToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ListadosToolStripMenuItem.Text = "Listar";
            // 
            // listarArticulosToolStripMenuItem
            // 
            this.listarArticulosToolStripMenuItem.Name = "listarArticulosToolStripMenuItem";
            this.listarArticulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarArticulosToolStripMenuItem.Text = "Artículos";
            this.listarArticulosToolStripMenuItem.Click += new System.EventHandler(this.listarArticulosToolStripMenuItem_Click);
            // 
            // listarMarcasToolStripMenuItem
            // 
            this.listarMarcasToolStripMenuItem.Name = "listarMarcasToolStripMenuItem";
            this.listarMarcasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarMarcasToolStripMenuItem.Text = "Marcas";
            this.listarMarcasToolStripMenuItem.Click += new System.EventHandler(this.listarMarcasToolStripMenuItem_Click);
            // 
            // listarCategoríasToolStripMenuItem
            // 
            this.listarCategoríasToolStripMenuItem.Name = "listarCategoríasToolStripMenuItem";
            this.listarCategoríasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarCategoríasToolStripMenuItem.Text = "Categorías";
            this.listarCategoríasToolStripMenuItem.Click += new System.EventHandler(this.listarCategoríasToolStripMenuItem_Click);
            // 
            // BuscarToolStripMenuItem
            // 
            this.BuscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuscarArticuloToolStripMenuItem,
            this.BuscarPorMarcaToolStripMenuItem,
            this.BuscarPorCategoriaToolStripMenuItem});
            this.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem";
            this.BuscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.BuscarToolStripMenuItem.Text = "Buscar";
            // 
            // BuscarArticuloToolStripMenuItem
            // 
            this.BuscarArticuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuscarArtporCódigoToolStripMenuItem1,
            this.BuscarArtporCódigoToolStripMenuItem2});
            this.BuscarArticuloToolStripMenuItem.Name = "BuscarArticuloToolStripMenuItem";
            this.BuscarArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BuscarArticuloToolStripMenuItem.Text = "Buscar Articulo";
            // 
            // BuscarArtporCódigoToolStripMenuItem1
            // 
            this.BuscarArtporCódigoToolStripMenuItem1.Name = "BuscarArtporCódigoToolStripMenuItem1";
            this.BuscarArtporCódigoToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.BuscarArtporCódigoToolStripMenuItem1.Text = "Por código";
            this.BuscarArtporCódigoToolStripMenuItem1.Click += new System.EventHandler(this.porCódigoToolStripMenuItem1_Click);
            // 
            // BuscarArtporCódigoToolStripMenuItem2
            // 
            this.BuscarArtporCódigoToolStripMenuItem2.Name = "BuscarArtporCódigoToolStripMenuItem2";
            this.BuscarArtporCódigoToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.BuscarArtporCódigoToolStripMenuItem2.Text = "Por nombre";
            this.BuscarArtporCódigoToolStripMenuItem2.Click += new System.EventHandler(this.porNombreToolStripMenuItem1_Click);
            // 
            // BuscarPorMarcaToolStripMenuItem
            // 
            this.BuscarPorMarcaToolStripMenuItem.Name = "BuscarPorMarcaToolStripMenuItem";
            this.BuscarPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BuscarPorMarcaToolStripMenuItem.Text = "Buscar Marca";
            this.BuscarPorMarcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // BuscarPorCategoriaToolStripMenuItem
            // 
            this.BuscarPorCategoriaToolStripMenuItem.Name = "BuscarPorCategoriaToolStripMenuItem";
            this.BuscarPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BuscarPorCategoriaToolStripMenuItem.Text = "Buscar Categoria";
            this.BuscarPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructivoDeUsoToolStripMenuItem,
            this.reportarProblemaToolStripMenuItem,
            this.necesitoAyudaToolStripMenuItem,
            this.créditosToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // instructivoDeUsoToolStripMenuItem
            // 
            this.instructivoDeUsoToolStripMenuItem.Name = "instructivoDeUsoToolStripMenuItem";
            this.instructivoDeUsoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instructivoDeUsoToolStripMenuItem.Text = "Instructivo de uso";
            // 
            // reportarProblemaToolStripMenuItem
            // 
            this.reportarProblemaToolStripMenuItem.Name = "reportarProblemaToolStripMenuItem";
            this.reportarProblemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportarProblemaToolStripMenuItem.Text = "Reportar problema";
            // 
            // necesitoAyudaToolStripMenuItem
            // 
            this.necesitoAyudaToolStripMenuItem.Name = "necesitoAyudaToolStripMenuItem";
            this.necesitoAyudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.necesitoAyudaToolStripMenuItem.Text = "Necesito ayuda";
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.créditosToolStripMenuItem.Text = "Créditos";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaInicio,
            this.ListadosToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.BuscarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip2";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículoToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoríaToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // artículoToolStripMenuItem
            // 
            this.artículoToolStripMenuItem.Name = "artículoToolStripMenuItem";
            this.artículoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.artículoToolStripMenuItem.Text = "Artículo";
            this.artículoToolStripMenuItem.Click += new System.EventHandler(this.artículoToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click_1);
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            this.categoríaToolStripMenuItem.Click += new System.EventHandler(this.categoríaToolStripMenuItem_Click);
            // 
            // ContenedorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ContenedorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ventanaInicio;
        private System.Windows.Forms.ToolStripMenuItem ListadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarArtporCódigoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BuscarArtporCódigoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem BuscarPorMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructivoDeUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarProblemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem necesitoAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
    }
}

