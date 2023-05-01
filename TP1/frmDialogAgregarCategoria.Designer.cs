namespace TP1
{
    partial class frmDialogAgregarCategoria
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
            this.labelAgregarCategoria = new System.Windows.Forms.Label();
            this.labelNombreCategoria = new System.Windows.Forms.Label();
            this.textBoxNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAgregarCategoria
            // 
            this.labelAgregarCategoria.AutoSize = true;
            this.labelAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarCategoria.Location = new System.Drawing.Point(120, 34);
            this.labelAgregarCategoria.Name = "labelAgregarCategoria";
            this.labelAgregarCategoria.Size = new System.Drawing.Size(252, 31);
            this.labelAgregarCategoria.TabIndex = 3;
            this.labelAgregarCategoria.Text = "Agregar Categoría";
            // 
            // labelNombreCategoria
            // 
            this.labelNombreCategoria.AutoSize = true;
            this.labelNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCategoria.Location = new System.Drawing.Point(40, 91);
            this.labelNombreCategoria.Name = "labelNombreCategoria";
            this.labelNombreCategoria.Size = new System.Drawing.Size(66, 18);
            this.labelNombreCategoria.TabIndex = 6;
            this.labelNombreCategoria.Text = "Nombre:";
            // 
            // textBoxNombreCategoria
            // 
            this.textBoxNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNombreCategoria.Location = new System.Drawing.Point(43, 112);
            this.textBoxNombreCategoria.Name = "textBoxNombreCategoria";
            this.textBoxNombreCategoria.Size = new System.Drawing.Size(395, 23);
            this.textBoxNombreCategoria.TabIndex = 7;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(188, 157);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(250, 32);
            this.btnAgregarCategoria.TabIndex = 20;
            this.btnAgregarCategoria.Text = "AGREGAR CATEGORÍA";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVolver.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.Location = new System.Drawing.Point(43, 157);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(126, 32);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmDialogAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 216);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.textBoxNombreCategoria);
            this.Controls.Add(this.labelNombreCategoria);
            this.Controls.Add(this.labelAgregarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDialogAgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar una Categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgregarCategoria;
        private System.Windows.Forms.Label labelNombreCategoria;
        private System.Windows.Forms.TextBox textBoxNombreCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnVolver;
    }
}