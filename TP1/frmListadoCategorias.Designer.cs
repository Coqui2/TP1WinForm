namespace TP1
{
    partial class frmListadoCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelListadoCategorias = new System.Windows.Forms.Label();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dataGrisCategorias = new System.Windows.Forms.DataGridView();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.labelListadoArt = new System.Windows.Forms.Label();
            this.dataGridArticulosPorCategoria = new System.Windows.Forms.DataGridView();
            this.btnVerArticulo = new System.Windows.Forms.Button();
            this.labelPrecioArticulo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCodigoArticulo = new System.Windows.Forms.Label();
            this.labelNombreArticulo = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrisCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulosPorCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListadoCategorias
            // 
            this.labelListadoCategorias.AutoSize = true;
            this.labelListadoCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListadoCategorias.Location = new System.Drawing.Point(45, 37);
            this.labelListadoCategorias.Name = "labelListadoCategorias";
            this.labelListadoCategorias.Size = new System.Drawing.Size(299, 31);
            this.labelListadoCategorias.TabIndex = 2;
            this.labelListadoCategorias.Text = "Listado de Categorías";
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoria.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnModificarCategoria.Location = new System.Drawing.Point(536, 304);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCategoria.TabIndex = 3;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(631, 304);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 4;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(51, 308);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarCategoria.TabIndex = 5;
            this.btnAgregarCategoria.Text = "Agregar categoría";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // dataGrisCategorias
            // 
            this.dataGrisCategorias.AllowUserToAddRows = false;
            this.dataGrisCategorias.AllowUserToDeleteRows = false;
            this.dataGrisCategorias.AllowUserToResizeColumns = false;
            this.dataGrisCategorias.AllowUserToResizeRows = false;
            this.dataGrisCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrisCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrisCategorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrisCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrisCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrisCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrisCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrisCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrisCategorias.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrisCategorias.Location = new System.Drawing.Point(51, 120);
            this.dataGrisCategorias.MultiSelect = false;
            this.dataGrisCategorias.Name = "dataGrisCategorias";
            this.dataGrisCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrisCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrisCategorias.Size = new System.Drawing.Size(731, 178);
            this.dataGrisCategorias.StandardTab = true;
            this.dataGrisCategorias.TabIndex = 9;
            this.dataGrisCategorias.SelectionChanged += new System.EventHandler(this.listaCategorias_SelectionChanged);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(162, 88);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(218, 20);
            this.textBoxFiltro.TabIndex = 11;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(48, 91);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(96, 13);
            this.labelFiltro.TabIndex = 12;
            this.labelFiltro.Text = "Buscar por nombre";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestablecer.Location = new System.Drawing.Point(427, 85);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(84, 23);
            this.btnRestablecer.TabIndex = 16;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // labelListadoArt
            // 
            this.labelListadoArt.AutoSize = true;
            this.labelListadoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListadoArt.Location = new System.Drawing.Point(45, 350);
            this.labelListadoArt.Name = "labelListadoArt";
            this.labelListadoArt.Size = new System.Drawing.Size(379, 24);
            this.labelListadoArt.TabIndex = 17;
            this.labelListadoArt.Text = "Listado de Artículos con Categoría (Cat)";
            // 
            // dataGridArticulosPorCategoria
            // 
            this.dataGridArticulosPorCategoria.AllowUserToAddRows = false;
            this.dataGridArticulosPorCategoria.AllowUserToDeleteRows = false;
            this.dataGridArticulosPorCategoria.AllowUserToResizeColumns = false;
            this.dataGridArticulosPorCategoria.AllowUserToResizeRows = false;
            this.dataGridArticulosPorCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArticulosPorCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArticulosPorCategoria.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridArticulosPorCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridArticulosPorCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridArticulosPorCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridArticulosPorCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridArticulosPorCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridArticulosPorCategoria.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridArticulosPorCategoria.Location = new System.Drawing.Point(51, 387);
            this.dataGridArticulosPorCategoria.MultiSelect = false;
            this.dataGridArticulosPorCategoria.Name = "dataGridArticulosPorCategoria";
            this.dataGridArticulosPorCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridArticulosPorCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridArticulosPorCategoria.Size = new System.Drawing.Size(731, 146);
            this.dataGridArticulosPorCategoria.StandardTab = true;
            this.dataGridArticulosPorCategoria.TabIndex = 18;
            this.dataGridArticulosPorCategoria.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArticulosPorCategoria_CellContentDoubleClick);
            this.dataGridArticulosPorCategoria.SelectionChanged += new System.EventHandler(this.dataGridArticulosPorCategoria_SelectionChanged);
            // 
            // btnVerArticulo
            // 
            this.btnVerArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerArticulo.Location = new System.Drawing.Point(189, 626);
            this.btnVerArticulo.Name = "btnVerArticulo";
            this.btnVerArticulo.Size = new System.Drawing.Size(161, 35);
            this.btnVerArticulo.TabIndex = 19;
            this.btnVerArticulo.Text = "Ver detalles";
            this.btnVerArticulo.UseVisualStyleBackColor = false;
            this.btnVerArticulo.Click += new System.EventHandler(this.btnVerArticulo_Click);
            // 
            // labelPrecioArticulo
            // 
            this.labelPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioArticulo.Location = new System.Drawing.Point(185, 603);
            this.labelPrecioArticulo.Name = "labelPrecioArticulo";
            this.labelPrecioArticulo.Size = new System.Drawing.Size(147, 20);
            this.labelPrecioArticulo.TabIndex = 24;
            this.labelPrecioArticulo.Text = "$ (PrecioArticulo)";
            // 
            // labelMarca
            // 
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(185, 583);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(141, 20);
            this.labelMarca.TabIndex = 23;
            this.labelMarca.Text = "(MarcaArticulo)";
            // 
            // labelCodigoArticulo
            // 
            this.labelCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoArticulo.Location = new System.Drawing.Point(185, 538);
            this.labelCodigoArticulo.Name = "labelCodigoArticulo";
            this.labelCodigoArticulo.Size = new System.Drawing.Size(141, 24);
            this.labelCodigoArticulo.TabIndex = 22;
            this.labelCodigoArticulo.Text = "Cod. #1111";
            // 
            // labelNombreArticulo
            // 
            this.labelNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreArticulo.Location = new System.Drawing.Point(185, 562);
            this.labelNombreArticulo.Name = "labelNombreArticulo";
            this.labelNombreArticulo.Size = new System.Drawing.Size(128, 20);
            this.labelNombreArticulo.TabIndex = 21;
            this.labelNombreArticulo.Text = "(NombreArticulo)";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxArticulo.Location = new System.Drawing.Point(51, 539);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(115, 112);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 20;
            this.pbxArticulo.TabStop = false;
            // 
            // frmListadoCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 697);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerArticulo);
            this.Controls.Add(this.labelPrecioArticulo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelCodigoArticulo);
            this.Controls.Add(this.labelNombreArticulo);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dataGridArticulosPorCategoria);
            this.Controls.Add(this.labelListadoArt);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.dataGrisCategorias);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.labelListadoCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoCategorias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGrisCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulosPorCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListadoCategorias;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dataGrisCategorias;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Label labelListadoArt;
        private System.Windows.Forms.DataGridView dataGridArticulosPorCategoria;
        private System.Windows.Forms.Button btnVerArticulo;
        private System.Windows.Forms.Label labelPrecioArticulo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCodigoArticulo;
        private System.Windows.Forms.Label labelNombreArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}