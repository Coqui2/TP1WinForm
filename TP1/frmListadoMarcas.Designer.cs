namespace TP1
{
    partial class frmListadoMarcas
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
            this.labelListadoMarcas = new System.Windows.Forms.Label();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.listaMarcas = new System.Windows.Forms.DataGridView();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.dataGridArticulosPorCategoria = new System.Windows.Forms.DataGridView();
            this.labelListadoArt = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulosPorCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListadoMarcas
            // 
            this.labelListadoMarcas.AutoSize = true;
            this.labelListadoMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListadoMarcas.Location = new System.Drawing.Point(45, 37);
            this.labelListadoMarcas.Name = "labelListadoMarcas";
            this.labelListadoMarcas.Size = new System.Drawing.Size(252, 31);
            this.labelListadoMarcas.TabIndex = 2;
            this.labelListadoMarcas.Text = "Listado de Marcas";
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMarca.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnModificarMarca.Location = new System.Drawing.Point(430, 283);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMarca.TabIndex = 4;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEliminarMarca.Location = new System.Drawing.Point(525, 283);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 5;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarMarca.Location = new System.Drawing.Point(51, 283);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarMarca.TabIndex = 3;
            this.btnAgregarMarca.Text = "Agregar marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // listaMarcas
            // 
            this.listaMarcas.AllowUserToAddRows = false;
            this.listaMarcas.AllowUserToDeleteRows = false;
            this.listaMarcas.AllowUserToResizeColumns = false;
            this.listaMarcas.AllowUserToResizeRows = false;
            this.listaMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaMarcas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listaMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listaMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listaMarcas.GridColor = System.Drawing.SystemColors.Control;
            this.listaMarcas.Location = new System.Drawing.Point(51, 120);
            this.listaMarcas.MultiSelect = false;
            this.listaMarcas.Name = "listaMarcas";
            this.listaMarcas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listaMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaMarcas.Size = new System.Drawing.Size(549, 146);
            this.listaMarcas.StandardTab = true;
            this.listaMarcas.TabIndex = 2;
            this.listaMarcas.SelectionChanged += new System.EventHandler(this.listaMarcas_SelectionChanged);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(51, 94);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(96, 13);
            this.labelFiltro.TabIndex = 10;
            this.labelFiltro.Text = "Buscar por nombre";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(163, 91);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(218, 20);
            this.textBoxFiltro.TabIndex = 0;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.onTextChange);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridArticulosPorCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridArticulosPorCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridArticulosPorCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridArticulosPorCategoria.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridArticulosPorCategoria.Location = new System.Drawing.Point(55, 389);
            this.dataGridArticulosPorCategoria.MultiSelect = false;
            this.dataGridArticulosPorCategoria.Name = "dataGridArticulosPorCategoria";
            this.dataGridArticulosPorCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridArticulosPorCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridArticulosPorCategoria.Size = new System.Drawing.Size(638, 178);
            this.dataGridArticulosPorCategoria.StandardTab = true;
            this.dataGridArticulosPorCategoria.TabIndex = 6;
            // 
            // labelListadoArt
            // 
            this.labelListadoArt.AutoSize = true;
            this.labelListadoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListadoArt.Location = new System.Drawing.Point(49, 352);
            this.labelListadoArt.Name = "labelListadoArt";
            this.labelListadoArt.Size = new System.Drawing.Size(374, 24);
            this.labelListadoArt.TabIndex = 19;
            this.labelListadoArt.Text = "Listado de Artículos con Marca (Marca)";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestablecer.Location = new System.Drawing.Point(420, 88);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(84, 23);
            this.btnRestablecer.TabIndex = 1;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // frmListadoMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.ControlBox = false;
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.dataGridArticulosPorCategoria);
            this.Controls.Add(this.labelListadoArt);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.listaMarcas);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.labelListadoMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoMarcas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.listaMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulosPorCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListadoMarcas;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.DataGridView listaMarcas;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.DataGridView dataGridArticulosPorCategoria;
        private System.Windows.Forms.Label labelListadoArt;
        private System.Windows.Forms.Button btnRestablecer;
    }
}