namespace TP1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelListadoArticulos = new System.Windows.Forms.Label();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.labelNombreArticulo = new System.Windows.Forms.Label();
            this.labelCodigoArticulo = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPrecioArticulo = new System.Windows.Forms.Label();
            this.btnVerArticulo = new System.Windows.Forms.Button();
            this.dataGridArticulos = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelCampo = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.labelFiltroAvanzado = new System.Windows.Forms.Label();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelFiltrado = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListadoArticulos
            // 
            this.labelListadoArticulos.AutoSize = true;
            this.labelListadoArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListadoArticulos.Location = new System.Drawing.Point(45, 37);
            this.labelListadoArticulos.Name = "labelListadoArticulos";
            this.labelListadoArticulos.Size = new System.Drawing.Size(271, 31);
            this.labelListadoArticulos.TabIndex = 2;
            this.labelListadoArticulos.Text = "Listado de Artículos";
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArticulo.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnModificarArticulo.Location = new System.Drawing.Point(425, 283);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarArticulo.TabIndex = 4;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(525, 283);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarArticulo.TabIndex = 5;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(51, 283);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarArticulo.TabIndex = 3;
            this.btnAgregarArticulo.Text = "Agregar artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxArticulo.Location = new System.Drawing.Point(626, 122);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(115, 112);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 6;
            this.pbxArticulo.TabStop = false;
            // 
            // labelNombreArticulo
            // 
            this.labelNombreArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreArticulo.Location = new System.Drawing.Point(622, 246);
            this.labelNombreArticulo.Name = "labelNombreArticulo";
            this.labelNombreArticulo.Size = new System.Drawing.Size(128, 20);
            this.labelNombreArticulo.TabIndex = 7;
            this.labelNombreArticulo.Text = "(NombreArticulo)";
            // 
            // labelCodigoArticulo
            // 
            this.labelCodigoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoArticulo.Location = new System.Drawing.Point(622, 86);
            this.labelCodigoArticulo.Name = "labelCodigoArticulo";
            this.labelCodigoArticulo.Size = new System.Drawing.Size(105, 24);
            this.labelCodigoArticulo.TabIndex = 8;
            this.labelCodigoArticulo.Text = "Cod. #1111";
            // 
            // labelCategoria
            // 
            this.labelCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(622, 266);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(141, 20);
            this.labelCategoria.TabIndex = 9;
            this.labelCategoria.Text = "(CategoriaArticulo)";
            // 
            // labelPrecioArticulo
            // 
            this.labelPrecioArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioArticulo.Location = new System.Drawing.Point(622, 286);
            this.labelPrecioArticulo.Name = "labelPrecioArticulo";
            this.labelPrecioArticulo.Size = new System.Drawing.Size(147, 20);
            this.labelPrecioArticulo.TabIndex = 10;
            this.labelPrecioArticulo.Text = "$ (PrecioArticulo)";
            // 
            // btnVerArticulo
            // 
            this.btnVerArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerArticulo.Location = new System.Drawing.Point(627, 318);
            this.btnVerArticulo.Name = "btnVerArticulo";
            this.btnVerArticulo.Size = new System.Drawing.Size(123, 23);
            this.btnVerArticulo.TabIndex = 2;
            this.btnVerArticulo.Text = "Ver detalles";
            this.btnVerArticulo.UseVisualStyleBackColor = false;
            this.btnVerArticulo.Click += new System.EventHandler(this.btnVerArticulo_Click);
            // 
            // dataGridArticulos
            // 
            this.dataGridArticulos.AllowUserToAddRows = false;
            this.dataGridArticulos.AllowUserToDeleteRows = false;
            this.dataGridArticulos.AllowUserToResizeColumns = false;
            this.dataGridArticulos.AllowUserToResizeRows = false;
            this.dataGridArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridArticulos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridArticulos.Location = new System.Drawing.Point(51, 120);
            this.dataGridArticulos.MultiSelect = false;
            this.dataGridArticulos.Name = "dataGridArticulos";
            this.dataGridArticulos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridArticulos.Size = new System.Drawing.Size(549, 146);
            this.dataGridArticulos.StandardTab = true;
            this.dataGridArticulos.TabIndex = 1;
            this.dataGridArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArticulos_CellDoubleClick);
            this.dataGridArticulos.SelectionChanged += new System.EventHandler(this.dataGridArticulos_SelectionChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(51, 94);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(146, 13);
            this.lblFiltro.TabIndex = 13;
            this.lblFiltro.Text = "Buscar por código o nombre: ";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(205, 91);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(251, 20);
            this.textBoxFiltro.TabIndex = 0;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.onTxtChange);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(54, 358);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(40, 13);
            this.labelCampo.TabIndex = 14;
            this.labelCampo.Text = "Campo";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(57, 374);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(104, 21);
            this.comboBoxCampo.TabIndex = 6;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(183, 374);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(109, 21);
            this.comboBoxCriterio.TabIndex = 7;
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(180, 358);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(39, 13);
            this.labelCriterio.TabIndex = 16;
            this.labelCriterio.Text = "Criterio";
            // 
            // labelFiltroAvanzado
            // 
            this.labelFiltroAvanzado.AutoSize = true;
            this.labelFiltroAvanzado.Location = new System.Drawing.Point(304, 358);
            this.labelFiltroAvanzado.Name = "labelFiltroAvanzado";
            this.labelFiltroAvanzado.Size = new System.Drawing.Size(45, 13);
            this.labelFiltroAvanzado.TabIndex = 18;
            this.labelFiltroAvanzado.Text = "Término";
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(307, 374);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(124, 20);
            this.textBoxFiltroAvanzado.TabIndex = 8;
            this.textBoxFiltroAvanzado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFiltroAvanzado_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(448, 371);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelFiltrado
            // 
            this.labelFiltrado.AutoSize = true;
            this.labelFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrado.Location = new System.Drawing.Point(50, 322);
            this.labelFiltrado.Name = "labelFiltrado";
            this.labelFiltrado.Size = new System.Drawing.Size(145, 24);
            this.labelFiltrado.TabIndex = 21;
            this.labelFiltrado.Text = "Filtrar productos";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestablecer.Location = new System.Drawing.Point(489, 87);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(84, 23);
            this.btnRestablecer.TabIndex = 22;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.labelFiltrado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBoxFiltroAvanzado);
            this.Controls.Add(this.labelFiltroAvanzado);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dataGridArticulos);
            this.Controls.Add(this.btnVerArticulo);
            this.Controls.Add(this.labelPrecioArticulo);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelCodigoArticulo);
            this.Controls.Add(this.labelNombreArticulo);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.labelListadoArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListadoArticulos;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label labelNombreArticulo;
        private System.Windows.Forms.Label labelCodigoArticulo;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPrecioArticulo;
        private System.Windows.Forms.Button btnVerArticulo;
        private System.Windows.Forms.DataGridView dataGridArticulos;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelFiltroAvanzado;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelFiltrado;
        private System.Windows.Forms.Button btnRestablecer;
    }
}