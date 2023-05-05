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
            this.labelListadoMarcas = new System.Windows.Forms.Label();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.labelNombreMarca = new System.Windows.Forms.Label();
            this.labelCodigoMarca = new System.Windows.Forms.Label();
            this.listaMarcas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaMarcas)).BeginInit();
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
            this.btnModificarMarca.Location = new System.Drawing.Point(358, 298);
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
            this.btnEliminarMarca.Location = new System.Drawing.Point(453, 298);
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
            this.btnAgregarMarca.Location = new System.Drawing.Point(51, 298);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarMarca.TabIndex = 3;
            this.btnAgregarMarca.Text = "Agregar marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // labelNombreMarca
            // 
            this.labelNombreMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMarca.Location = new System.Drawing.Point(606, 146);
            this.labelNombreMarca.Name = "labelNombreMarca";
            this.labelNombreMarca.Size = new System.Drawing.Size(119, 20);
            this.labelNombreMarca.TabIndex = 7;
            this.labelNombreMarca.Text = "(NombreMarca)";
            // 
            // labelCodigoMarca
            // 
            this.labelCodigoMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCodigoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoMarca.Location = new System.Drawing.Point(606, 105);
            this.labelCodigoMarca.Name = "labelCodigoMarca";
            this.labelCodigoMarca.Size = new System.Drawing.Size(80, 24);
            this.labelCodigoMarca.TabIndex = 8;
            this.labelCodigoMarca.Text = "Id #1111";
            // 
            // listaMarcas
            // 
            this.listaMarcas.AllowUserToAddRows = false;
            this.listaMarcas.AllowUserToDeleteRows = false;
            this.listaMarcas.AllowUserToResizeColumns = false;
            this.listaMarcas.AllowUserToResizeRows = false;
            this.listaMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listaMarcas.Location = new System.Drawing.Point(51, 104);
            this.listaMarcas.MultiSelect = false;
            this.listaMarcas.Name = "listaMarcas";
            this.listaMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaMarcas.Size = new System.Drawing.Size(477, 178);
            this.listaMarcas.StandardTab = true;
            this.listaMarcas.TabIndex = 1;
            this.listaMarcas.SelectionChanged += new System.EventHandler(this.onSelectionChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro:";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(93, 82);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(218, 20);
            this.textBoxFiltro.TabIndex = 2;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre: ";
            // 
            // frmListadoMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaMarcas);
            this.Controls.Add(this.labelCodigoMarca);
            this.Controls.Add(this.labelNombreMarca);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListadoMarcas;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Label labelNombreMarca;
        private System.Windows.Forms.Label labelCodigoMarca;
        private System.Windows.Forms.DataGridView listaMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}