namespace Proyecto
{
    partial class principal
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
            this.departamentos = new System.Windows.Forms.Button();
            this.empleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departamentos
            // 
            this.departamentos.Location = new System.Drawing.Point(98, 113);
            this.departamentos.Name = "departamentos";
            this.departamentos.Size = new System.Drawing.Size(203, 129);
            this.departamentos.TabIndex = 0;
            this.departamentos.Text = "Departamentos";
            this.departamentos.UseVisualStyleBackColor = true;
            this.departamentos.Click += new System.EventHandler(this.button1_Click);
            // 
            // empleados
            // 
            this.empleados.Location = new System.Drawing.Point(454, 113);
            this.empleados.Name = "empleados";
            this.empleados.Size = new System.Drawing.Size(206, 129);
            this.empleados.TabIndex = 1;
            this.empleados.Text = "Empleados";
            this.empleados.UseVisualStyleBackColor = true;
            this.empleados.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.empleados);
            this.Controls.Add(this.departamentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button departamentos;
        private System.Windows.Forms.Button empleados;
    }
}

