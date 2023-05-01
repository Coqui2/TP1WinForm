namespace TP1
{
    partial class frmDialogAgregarMarca
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
            this.labelAgregarMarca = new System.Windows.Forms.Label();
            this.labelNombreMarca = new System.Windows.Forms.Label();
            this.textBoxNombreMarca = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAgregarMarca
            // 
            this.labelAgregarMarca.AutoSize = true;
            this.labelAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarMarca.Location = new System.Drawing.Point(140, 34);
            this.labelAgregarMarca.Name = "labelAgregarMarca";
            this.labelAgregarMarca.Size = new System.Drawing.Size(205, 31);
            this.labelAgregarMarca.TabIndex = 3;
            this.labelAgregarMarca.Text = "Agregar Marca";
            // 
            // labelNombreMarca
            // 
            this.labelNombreMarca.AutoSize = true;
            this.labelNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMarca.Location = new System.Drawing.Point(40, 91);
            this.labelNombreMarca.Name = "labelNombreMarca";
            this.labelNombreMarca.Size = new System.Drawing.Size(66, 18);
            this.labelNombreMarca.TabIndex = 6;
            this.labelNombreMarca.Text = "Nombre:";
            // 
            // textBoxNombreMarca
            // 
            this.textBoxNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNombreMarca.Location = new System.Drawing.Point(43, 112);
            this.textBoxNombreMarca.Name = "textBoxNombreMarca";
            this.textBoxNombreMarca.Size = new System.Drawing.Size(395, 23);
            this.textBoxNombreMarca.TabIndex = 7;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarMarca.Location = new System.Drawing.Point(190, 158);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(248, 32);
            this.btnAgregarMarca.TabIndex = 20;
            this.btnAgregarMarca.Text = "AGREGAR MARCA";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVolver.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.Location = new System.Drawing.Point(43, 158);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(126, 32);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmDialogAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 216);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.textBoxNombreMarca);
            this.Controls.Add(this.labelNombreMarca);
            this.Controls.Add(this.labelAgregarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDialogAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar una Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgregarMarca;
        private System.Windows.Forms.Label labelNombreMarca;
        private System.Windows.Forms.TextBox textBoxNombreMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnVolver;
    }
}