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
            this.listaCategoria = new System.Windows.Forms.ListView();
            this.labelListadoCategorias = new System.Windows.Forms.Label();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.labelNombreCategoria = new System.Windows.Forms.Label();
            this.labelCodigoCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaCategoria
            // 
            this.listaCategoria.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaCategoria.FullRowSelect = true;
            this.listaCategoria.GridLines = true;
            this.listaCategoria.HideSelection = false;
            this.listaCategoria.Location = new System.Drawing.Point(51, 85);
            this.listaCategoria.Name = "listaCategoria";
            this.listaCategoria.Size = new System.Drawing.Size(477, 159);
            this.listaCategoria.TabIndex = 1;
            this.listaCategoria.UseCompatibleStateImageBehavior = false;
            this.listaCategoria.View = System.Windows.Forms.View.List;
            this.listaCategoria.SelectedIndexChanged += new System.EventHandler(this.listaMarcas_SelectedIndexChanged);
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
            this.btnModificarCategoria.Location = new System.Drawing.Point(358, 259);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCategoria.TabIndex = 3;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(453, 259);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 4;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(51, 259);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarCategoria.TabIndex = 5;
            this.btnAgregarCategoria.Text = "Agregar categoría";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            // 
            // labelNombreCategoria
            // 
            this.labelNombreCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombreCategoria.AutoSize = true;
            this.labelNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCategoria.Location = new System.Drawing.Point(585, 88);
            this.labelNombreCategoria.Name = "labelNombreCategoria";
            this.labelNombreCategoria.Size = new System.Drawing.Size(144, 20);
            this.labelNombreCategoria.TabIndex = 7;
            this.labelNombreCategoria.Text = "(NombreCategoria)";
            // 
            // labelCodigoCategoria
            // 
            this.labelCodigoCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCodigoCategoria.AutoSize = true;
            this.labelCodigoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoCategoria.Location = new System.Drawing.Point(585, 47);
            this.labelCodigoCategoria.Name = "labelCodigoCategoria";
            this.labelCodigoCategoria.Size = new System.Drawing.Size(80, 24);
            this.labelCodigoCategoria.TabIndex = 8;
            this.labelCodigoCategoria.Text = "Id #1111";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelCodigoCategoria);
            this.Controls.Add(this.labelNombreCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.labelListadoCategorias);
            this.Controls.Add(this.listaCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listaCategoria;
        private System.Windows.Forms.Label labelListadoCategorias;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label labelNombreCategoria;
        private System.Windows.Forms.Label labelCodigoCategoria;
    }
}