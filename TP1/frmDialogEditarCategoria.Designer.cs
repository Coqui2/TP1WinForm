namespace TP1
{
    partial class frmDialogEditarCategoria
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
            this.labelEditarCategoria = new System.Windows.Forms.Label();
            this.labelNombreCategoria = new System.Windows.Forms.Label();
            this.textBoxNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEditarCategoria
            // 
            this.labelEditarCategoria.AutoSize = true;
            this.labelEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarCategoria.Location = new System.Drawing.Point(132, 34);
            this.labelEditarCategoria.Name = "labelEditarCategoria";
            this.labelEditarCategoria.Size = new System.Drawing.Size(226, 31);
            this.labelEditarCategoria.TabIndex = 3;
            this.labelEditarCategoria.Text = "Editar Categoría";
            // 
            // labelNombreCategoria
            // 
            this.labelNombreCategoria.AutoSize = true;
            this.labelNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCategoria.Location = new System.Drawing.Point(39, 90);
            this.labelNombreCategoria.Name = "labelNombreCategoria";
            this.labelNombreCategoria.Size = new System.Drawing.Size(66, 18);
            this.labelNombreCategoria.TabIndex = 6;
            this.labelNombreCategoria.Text = "Nombre:";
            // 
            // textBoxNombreCategoria
            // 
            this.textBoxNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNombreCategoria.Location = new System.Drawing.Point(42, 111);
            this.textBoxNombreCategoria.Name = "textBoxNombreCategoria";
            this.textBoxNombreCategoria.Size = new System.Drawing.Size(418, 23);
            this.textBoxNombreCategoria.TabIndex = 7;
            this.textBoxNombreCategoria.Text = "NOMBRE_CATEGORIA";
            this.textBoxNombreCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombreCategoria_KeyDown);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnModificarCategoria.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnModificarCategoria.Location = new System.Drawing.Point(191, 151);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(269, 32);
            this.btnModificarCategoria.TabIndex = 21;
            this.btnModificarCategoria.Text = "MODIFICAR CATEGORÍA";
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVolver.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.Location = new System.Drawing.Point(42, 151);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(126, 32);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "VOLVER CATEGORIA";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmDialogEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 216);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.textBoxNombreCategoria);
            this.Controls.Add(this.labelNombreCategoria);
            this.Controls.Add(this.labelEditarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDialogEditarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Categoría";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDialogEditarCategoria_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditarCategoria;
        private System.Windows.Forms.Label labelNombreCategoria;
        private System.Windows.Forms.TextBox textBoxNombreCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnVolver;
    }
}