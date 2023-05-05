namespace TP1
{
    partial class frmDialogEditarMarca
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
            this.labelEditarMarca = new System.Windows.Forms.Label();
            this.labelNombreMarca = new System.Windows.Forms.Label();
            this.textBoxNombreMarca = new System.Windows.Forms.TextBox();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEditarMarca
            // 
            this.labelEditarMarca.AutoSize = true;
            this.labelEditarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarMarca.Location = new System.Drawing.Point(152, 34);
            this.labelEditarMarca.Name = "labelEditarMarca";
            this.labelEditarMarca.Size = new System.Drawing.Size(179, 31);
            this.labelEditarMarca.TabIndex = 3;
            this.labelEditarMarca.Text = "Editar Marca";
            // 
            // labelNombreMarca
            // 
            this.labelNombreMarca.AutoSize = true;
            this.labelNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMarca.Location = new System.Drawing.Point(39, 90);
            this.labelNombreMarca.Name = "labelNombreMarca";
            this.labelNombreMarca.Size = new System.Drawing.Size(66, 18);
            this.labelNombreMarca.TabIndex = 6;
            this.labelNombreMarca.Text = "Nombre:";
            // 
            // textBoxNombreMarca
            // 
            this.textBoxNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNombreMarca.Location = new System.Drawing.Point(42, 111);
            this.textBoxNombreMarca.Name = "textBoxNombreMarca";
            this.textBoxNombreMarca.Size = new System.Drawing.Size(418, 23);
            this.textBoxNombreMarca.TabIndex = 7;
            this.textBoxNombreMarca.Text = "NOMBRE_MARCA";
            this.textBoxNombreMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onTxtBoxKeyDown);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnModificarMarca.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnModificarMarca.Location = new System.Drawing.Point(191, 151);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(269, 32);
            this.btnModificarMarca.TabIndex = 21;
            this.btnModificarMarca.Text = "MODIFICAR MARCA";
            this.btnModificarMarca.UseVisualStyleBackColor = false;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
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
            // frmDialogEditarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 216);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.textBoxNombreMarca);
            this.Controls.Add(this.labelNombreMarca);
            this.Controls.Add(this.labelEditarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDialogEditarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar una Marca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditarMarca;
        private System.Windows.Forms.Label labelNombreMarca;
        private System.Windows.Forms.TextBox textBoxNombreMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnVolver;
    }
}