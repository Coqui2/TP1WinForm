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
            this.listaMarcas = new System.Windows.Forms.ListView();
            this.labelListadoMarcas = new System.Windows.Forms.Label();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.labelNombreMarca = new System.Windows.Forms.Label();
            this.labelCodigoMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaMarcas
            // 
            this.listaMarcas.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listaMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaMarcas.FullRowSelect = true;
            this.listaMarcas.GridLines = true;
            this.listaMarcas.HideSelection = false;
            this.listaMarcas.Location = new System.Drawing.Point(51, 85);
            this.listaMarcas.Name = "listaMarcas";
            this.listaMarcas.Size = new System.Drawing.Size(477, 159);
            this.listaMarcas.TabIndex = 1;
            this.listaMarcas.UseCompatibleStateImageBehavior = false;
            this.listaMarcas.View = System.Windows.Forms.View.List;
            this.listaMarcas.SelectedIndexChanged += new System.EventHandler(this.listaMarcas_SelectedIndexChanged);
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
            this.btnModificarMarca.Location = new System.Drawing.Point(358, 259);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMarca.TabIndex = 3;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEliminarMarca.Location = new System.Drawing.Point(453, 259);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 4;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarMarca.Location = new System.Drawing.Point(51, 259);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarMarca.TabIndex = 5;
            this.btnAgregarMarca.Text = "Agregar marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            // 
            // labelNombreMarca
            // 
            this.labelNombreMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombreMarca.AutoSize = true;
            this.labelNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMarca.Location = new System.Drawing.Point(585, 88);
            this.labelNombreMarca.Name = "labelNombreMarca";
            this.labelNombreMarca.Size = new System.Drawing.Size(119, 20);
            this.labelNombreMarca.TabIndex = 7;
            this.labelNombreMarca.Text = "(NombreMarca)";
            // 
            // labelCodigoMarca
            // 
            this.labelCodigoMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCodigoMarca.AutoSize = true;
            this.labelCodigoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoMarca.Location = new System.Drawing.Point(585, 47);
            this.labelCodigoMarca.Name = "labelCodigoMarca";
            this.labelCodigoMarca.Size = new System.Drawing.Size(80, 24);
            this.labelCodigoMarca.TabIndex = 8;
            this.labelCodigoMarca.Text = "Id #1111";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelCodigoMarca);
            this.Controls.Add(this.labelNombreMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.labelListadoMarcas);
            this.Controls.Add(this.listaMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listaMarcas;
        private System.Windows.Forms.Label labelListadoMarcas;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Label labelNombreMarca;
        private System.Windows.Forms.Label labelCodigoMarca;
    }
}