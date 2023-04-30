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
            this.listaArticulos = new System.Windows.Forms.ListView();
            this.labelListadoArticulos = new System.Windows.Forms.Label();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNombreArticulo = new System.Windows.Forms.Label();
            this.labelCodigoArticulo = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPrecioArticulo = new System.Windows.Forms.Label();
            this.btnVerArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaArticulos
            // 
            this.listaArticulos.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaArticulos.FullRowSelect = true;
            this.listaArticulos.GridLines = true;
            this.listaArticulos.HideSelection = false;
            this.listaArticulos.Location = new System.Drawing.Point(51, 85);
            this.listaArticulos.Name = "listaArticulos";
            this.listaArticulos.Size = new System.Drawing.Size(477, 159);
            this.listaArticulos.TabIndex = 1;
            this.listaArticulos.UseCompatibleStateImageBehavior = false;
            this.listaArticulos.View = System.Windows.Forms.View.List;
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
            this.btnModificarArticulo.Location = new System.Drawing.Point(358, 259);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(453, 259);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(51, 259);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarArticulo.TabIndex = 5;
            this.btnAgregarArticulo.Text = "Agregar artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(589, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 93);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelNombreArticulo
            // 
            this.labelNombreArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombreArticulo.AutoSize = true;
            this.labelNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreArticulo.Location = new System.Drawing.Point(585, 191);
            this.labelNombreArticulo.Name = "labelNombreArticulo";
            this.labelNombreArticulo.Size = new System.Drawing.Size(128, 20);
            this.labelNombreArticulo.TabIndex = 7;
            this.labelNombreArticulo.Text = "(NombreArticulo)";
            // 
            // labelCodigoArticulo
            // 
            this.labelCodigoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCodigoArticulo.AutoSize = true;
            this.labelCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoArticulo.Location = new System.Drawing.Point(585, 47);
            this.labelCodigoArticulo.Name = "labelCodigoArticulo";
            this.labelCodigoArticulo.Size = new System.Drawing.Size(105, 24);
            this.labelCodigoArticulo.TabIndex = 8;
            this.labelCodigoArticulo.Text = "Cod. #1111";
            // 
            // labelCategoria
            // 
            this.labelCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(585, 211);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(141, 20);
            this.labelCategoria.TabIndex = 9;
            this.labelCategoria.Text = "(CategoriaArticulo)";
            // 
            // labelPrecioArticulo
            // 
            this.labelPrecioArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrecioArticulo.AutoSize = true;
            this.labelPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioArticulo.Location = new System.Drawing.Point(585, 231);
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
            this.btnVerArticulo.Location = new System.Drawing.Point(603, 259);
            this.btnVerArticulo.Name = "btnVerArticulo";
            this.btnVerArticulo.Size = new System.Drawing.Size(123, 23);
            this.btnVerArticulo.TabIndex = 11;
            this.btnVerArticulo.Text = "Ver detalles";
            this.btnVerArticulo.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerArticulo);
            this.Controls.Add(this.labelPrecioArticulo);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelCodigoArticulo);
            this.Controls.Add(this.labelNombreArticulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.labelListadoArticulos);
            this.Controls.Add(this.listaArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listaArticulos;
        private System.Windows.Forms.Label labelListadoArticulos;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombreArticulo;
        private System.Windows.Forms.Label labelCodigoArticulo;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPrecioArticulo;
        private System.Windows.Forms.Button btnVerArticulo;
    }
}