namespace Ejemplo2
{
    partial class Form1
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
            this.BtnAreaC = new System.Windows.Forms.Button();
            this.BtnTabla = new System.Windows.Forms.Button();
            this.BtnDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // BtnAreaC
            // 
            this.BtnAreaC.Location = new System.Drawing.Point(57, 75);
            this.BtnAreaC.Name = "BtnAreaC";
            this.BtnAreaC.Size = new System.Drawing.Size(192, 45);
            this.BtnAreaC.TabIndex = 1;
            this.BtnAreaC.Text = "Area Círculo";
            this.BtnAreaC.UseVisualStyleBackColor = true;
            this.BtnAreaC.Click += new System.EventHandler(this.BtnAreaC_Click);
            // 
            // BtnTabla
            // 
            this.BtnTabla.Location = new System.Drawing.Point(57, 131);
            this.BtnTabla.Name = "BtnTabla";
            this.BtnTabla.Size = new System.Drawing.Size(192, 45);
            this.BtnTabla.TabIndex = 2;
            this.BtnTabla.Text = "Tabla de Multiplicación";
            this.BtnTabla.UseVisualStyleBackColor = true;
            this.BtnTabla.Click += new System.EventHandler(this.BtnTabla_Click);
            // 
            // BtnDatos
            // 
            this.BtnDatos.Location = new System.Drawing.Point(57, 191);
            this.BtnDatos.Name = "BtnDatos";
            this.BtnDatos.Size = new System.Drawing.Size(192, 45);
            this.BtnDatos.TabIndex = 3;
            this.BtnDatos.Text = "Datos de un Empleado";
            this.BtnDatos.UseVisualStyleBackColor = true;
            this.BtnDatos.Click += new System.EventHandler(this.BtnDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 303);
            this.Controls.Add(this.BtnDatos);
            this.Controls.Add(this.BtnTabla);
            this.Controls.Add(this.BtnAreaC);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAreaC;
        private System.Windows.Forms.Button BtnTabla;
        private System.Windows.Forms.Button BtnDatos;
    }
}

