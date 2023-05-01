namespace TP1
{
    partial class frmBuscarArticulo
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
            this.labelBuscarArtCodigo = new System.Windows.Forms.Label();
            this.btnBuscarArtNombre = new System.Windows.Forms.Button();
            this.listaResultados = new System.Windows.Forms.ListView();
            this.textBoxBusquedaCodigoArt = new System.Windows.Forms.TextBox();
            this.labelIngreseCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarArtCodigo = new System.Windows.Forms.Button();
            this.labelPorCodigo = new System.Windows.Forms.Label();
            this.labelPorNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBuscarArtCodigo
            // 
            this.labelBuscarArtCodigo.AutoSize = true;
            this.labelBuscarArtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarArtCodigo.Location = new System.Drawing.Point(45, 37);
            this.labelBuscarArtCodigo.Name = "labelBuscarArtCodigo";
            this.labelBuscarArtCodigo.Size = new System.Drawing.Size(212, 31);
            this.labelBuscarArtCodigo.TabIndex = 2;
            this.labelBuscarArtCodigo.Text = "Buscar Artículo";
            // 
            // btnBuscarArtNombre
            // 
            this.btnBuscarArtNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarArtNombre.Location = new System.Drawing.Point(679, 130);
            this.btnBuscarArtNombre.Name = "btnBuscarArtNombre";
            this.btnBuscarArtNombre.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarArtNombre.TabIndex = 5;
            this.btnBuscarArtNombre.Text = "Buscar";
            this.btnBuscarArtNombre.UseVisualStyleBackColor = false;
            // 
            // listaResultados
            // 
            this.listaResultados.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listaResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaResultados.FullRowSelect = true;
            this.listaResultados.GridLines = true;
            this.listaResultados.HideSelection = false;
            this.listaResultados.Location = new System.Drawing.Point(54, 204);
            this.listaResultados.Name = "listaResultados";
            this.listaResultados.Size = new System.Drawing.Size(688, 159);
            this.listaResultados.TabIndex = 1;
            this.listaResultados.UseCompatibleStateImageBehavior = false;
            this.listaResultados.View = System.Windows.Forms.View.List;
            // 
            // textBoxBusquedaCodigoArt
            // 
            this.textBoxBusquedaCodigoArt.Location = new System.Drawing.Point(388, 133);
            this.textBoxBusquedaCodigoArt.Name = "textBoxBusquedaCodigoArt";
            this.textBoxBusquedaCodigoArt.Size = new System.Drawing.Size(270, 20);
            this.textBoxBusquedaCodigoArt.TabIndex = 6;
            // 
            // labelIngreseCodigo
            // 
            this.labelIngreseCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelIngreseCodigo.Location = new System.Drawing.Point(385, 107);
            this.labelIngreseCodigo.Name = "labelIngreseCodigo";
            this.labelIngreseCodigo.Size = new System.Drawing.Size(240, 20);
            this.labelIngreseCodigo.TabIndex = 7;
            this.labelIngreseCodigo.Text = "Ingrese el nombre del artículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(51, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultados de la búsqueda:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(51, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese el código del artículo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btnBuscarArtCodigo
            // 
            this.btnBuscarArtCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArtCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarArtCodigo.Location = new System.Drawing.Point(264, 130);
            this.btnBuscarArtCodigo.Name = "btnBuscarArtCodigo";
            this.btnBuscarArtCodigo.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarArtCodigo.TabIndex = 11;
            this.btnBuscarArtCodigo.Text = "Buscar";
            this.btnBuscarArtCodigo.UseVisualStyleBackColor = false;
            // 
            // labelPorCodigo
            // 
            this.labelPorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorCodigo.Location = new System.Drawing.Point(51, 87);
            this.labelPorCodigo.Name = "labelPorCodigo";
            this.labelPorCodigo.Size = new System.Drawing.Size(208, 20);
            this.labelPorCodigo.TabIndex = 12;
            this.labelPorCodigo.Text = "Por Código";
            // 
            // labelPorNombre
            // 
            this.labelPorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorNombre.Location = new System.Drawing.Point(384, 87);
            this.labelPorNombre.Name = "labelPorNombre";
            this.labelPorNombre.Size = new System.Drawing.Size(208, 20);
            this.labelPorNombre.TabIndex = 13;
            this.labelPorNombre.Text = "Por Nombre";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelPorNombre);
            this.Controls.Add(this.labelPorCodigo);
            this.Controls.Add(this.btnBuscarArtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIngreseCodigo);
            this.Controls.Add(this.textBoxBusquedaCodigoArt);
            this.Controls.Add(this.btnBuscarArtNombre);
            this.Controls.Add(this.labelBuscarArtCodigo);
            this.Controls.Add(this.listaResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBuscarArtCodigo;
        private System.Windows.Forms.Button btnBuscarArtNombre;
        private System.Windows.Forms.ListView listaResultados;
        private System.Windows.Forms.TextBox textBoxBusquedaCodigoArt;
        private System.Windows.Forms.Label labelIngreseCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarArtCodigo;
        private System.Windows.Forms.Label labelPorCodigo;
        private System.Windows.Forms.Label labelPorNombre;
    }
}