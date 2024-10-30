namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnSupermercado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(102, 168);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(142, 35);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnSupermercado
            // 
            this.btnSupermercado.Location = new System.Drawing.Point(102, 127);
            this.btnSupermercado.Name = "btnSupermercado";
            this.btnSupermercado.Size = new System.Drawing.Size(142, 35);
            this.btnSupermercado.TabIndex = 3;
            this.btnSupermercado.Text = "Ver Supermercado";
            this.btnSupermercado.UseVisualStyleBackColor = true;
            this.btnSupermercado.Click += new System.EventHandler(this.btnSupermercado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(102, 209);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(102, 86);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(142, 35);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Ver Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 277);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSupermercado);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "Form Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnSupermercado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProductos;
    }
}

