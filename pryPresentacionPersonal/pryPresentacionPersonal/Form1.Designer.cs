namespace pryPresentacionPersonal
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
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.btnPresentar = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(155, 43);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(257, 39);
            this.lblPresentacion.TabIndex = 0;
            this.lblPresentacion.Text = "Mi presentación";
            this.lblPresentacion.Click += new System.EventHandler(this.lblPresentacion_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(32, 109);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(32, 159);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(32, 207);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(32, 251);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(66, 20);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Carrera";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 109);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 29);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(119, 159);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(172, 29);
            this.txtApellido.TabIndex = 9;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(119, 207);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 29);
            this.txtEdad.TabIndex = 10;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(119, 251);
            this.txtCarrera.Multiline = true;
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(172, 29);
            this.txtCarrera.TabIndex = 11;
            // 
            // btnPresentar
            // 
            this.btnPresentar.Location = new System.Drawing.Point(119, 313);
            this.btnPresentar.Name = "btnPresentar";
            this.btnPresentar.Size = new System.Drawing.Size(376, 37);
            this.btnPresentar.TabIndex = 12;
            this.btnPresentar.Text = "Presentar";
            this.btnPresentar.UseVisualStyleBackColor = true;
            this.btnPresentar.Click += new System.EventHandler(this.btnPresentar_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(35, 384);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 20);
            this.lblMostrar.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 501);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnPresentar);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPresentacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Button btnPresentar;
        private System.Windows.Forms.Label lblMostrar;
    }
}

