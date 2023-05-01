namespace TP1
{
    partial class frmDialogEliminarCategoria
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
            this.labelEliminarCategoria = new System.Windows.Forms.Label();
            this.labelNombreCategoria = new System.Windows.Forms.Label();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEliminarCategoria
            // 
            this.labelEliminarCategoria.AutoSize = true;
            this.labelEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarCategoria.Location = new System.Drawing.Point(122, 34);
            this.labelEliminarCategoria.Name = "labelEliminarCategoria";
            this.labelEliminarCategoria.Size = new System.Drawing.Size(254, 31);
            this.labelEliminarCategoria.TabIndex = 3;
            this.labelEliminarCategoria.Text = "Eliminar Categoría";
            // 
            // labelNombreCategoria
            // 
            this.labelNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.labelNombreCategoria.Location = new System.Drawing.Point(42, 92);
            this.labelNombreCategoria.Name = "labelNombreCategoria";
            this.labelNombreCategoria.Size = new System.Drawing.Size(418, 45);
            this.labelNombreCategoria.TabIndex = 6;
            this.labelNombreCategoria.Text = "¿Desea eliminar la categoría (NOMBRE_CAT)?";
            this.labelNombreCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnModificarCategoria.ForeColor = System.Drawing.Color.Firebrick;
            this.btnModificarCategoria.Location = new System.Drawing.Point(191, 151);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(269, 32);
            this.btnModificarCategoria.TabIndex = 21;
            this.btnModificarCategoria.Text = "ELIMINAR CATEGORÍA";
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
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
            this.btnVolver.Text = "VOLVER MARCA";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmDialogEliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 216);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.labelNombreCategoria);
            this.Controls.Add(this.labelEliminarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDialogEliminarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEliminarCategoria;
        private System.Windows.Forms.Label labelNombreCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnVolver;
    }
}