namespace TP1
{
    partial class frmBuscarMarca
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
            this.btnBuscarArtCodigo = new System.Windows.Forms.Button();
            this.listaResultados = new System.Windows.Forms.ListView();
            this.textBoxBusquedaCodigoArt = new System.Windows.Forms.TextBox();
            this.labelIngreseCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBuscarArtCodigo
            // 
            this.labelBuscarArtCodigo.AutoSize = true;
            this.labelBuscarArtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarArtCodigo.Location = new System.Drawing.Point(45, 37);
            this.labelBuscarArtCodigo.Name = "labelBuscarArtCodigo";
            this.labelBuscarArtCodigo.Size = new System.Drawing.Size(208, 31);
            this.labelBuscarArtCodigo.TabIndex = 2;
            this.labelBuscarArtCodigo.Text = "Buscar Marcas";
            // 
            // btnBuscarArtCodigo
            // 
            this.btnBuscarArtCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArtCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarArtCodigo.Location = new System.Drawing.Point(468, 100);
            this.btnBuscarArtCodigo.Name = "btnBuscarArtCodigo";
            this.btnBuscarArtCodigo.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarArtCodigo.TabIndex = 5;
            this.btnBuscarArtCodigo.Text = "Buscar";
            this.btnBuscarArtCodigo.UseVisualStyleBackColor = false;
            // 
            // listaResultados
            // 
            this.listaResultados.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listaResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaResultados.FullRowSelect = true;
            this.listaResultados.GridLines = true;
            this.listaResultados.HideSelection = false;
            this.listaResultados.Location = new System.Drawing.Point(54, 167);
            this.listaResultados.Name = "listaResultados";
            this.listaResultados.Size = new System.Drawing.Size(688, 159);
            this.listaResultados.TabIndex = 1;
            this.listaResultados.UseCompatibleStateImageBehavior = false;
            this.listaResultados.View = System.Windows.Forms.View.List;
            // 
            // textBoxBusquedaCodigoArt
            // 
            this.textBoxBusquedaCodigoArt.Location = new System.Drawing.Point(54, 103);
            this.textBoxBusquedaCodigoArt.Name = "textBoxBusquedaCodigoArt";
            this.textBoxBusquedaCodigoArt.Size = new System.Drawing.Size(388, 20);
            this.textBoxBusquedaCodigoArt.TabIndex = 6;
            // 
            // labelIngreseCodigo
            // 
            this.labelIngreseCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelIngreseCodigo.Location = new System.Drawing.Point(51, 80);
            this.labelIngreseCodigo.Name = "labelIngreseCodigo";
            this.labelIngreseCodigo.Size = new System.Drawing.Size(391, 20);
            this.labelIngreseCodigo.TabIndex = 7;
            this.labelIngreseCodigo.Text = "Ingrese el nombre de la marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(51, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultados de la búsqueda:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIngreseCodigo);
            this.Controls.Add(this.textBoxBusquedaCodigoArt);
            this.Controls.Add(this.btnBuscarArtCodigo);
            this.Controls.Add(this.labelBuscarArtCodigo);
            this.Controls.Add(this.listaResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
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
        private System.Windows.Forms.Button btnBuscarArtCodigo;
        private System.Windows.Forms.ListView listaResultados;
        private System.Windows.Forms.TextBox textBoxBusquedaCodigoArt;
        private System.Windows.Forms.Label labelIngreseCodigo;
        private System.Windows.Forms.Label label2;
    }
}