
namespace appRegistroPersona
{
    partial class frmRegistroPersona
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtbDNI = new System.Windows.Forms.TextBox();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbSoltero = new System.Windows.Forms.RadioButton();
            this.rdbDivorciado = new System.Windows.Forms.RadioButton();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.grbEsatdoCivil = new System.Windows.Forms.GroupBox();
            this.grbDomicilio = new System.Windows.Forms.GroupBox();
            this.txtbLocalidad = new System.Windows.Forms.TextBox();
            this.txtbProvincia = new System.Windows.Forms.TextBox();
            this.txtbNumeroCalle = new System.Windows.Forms.TextBox();
            this.txtbPiso = new System.Windows.Forms.TextBox();
            this.txtbDepto = new System.Windows.Forms.TextBox();
            this.txtbCalle = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.grbEsatdoCivil.SuspendLayout();
            this.grbDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Persona";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(188, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(252, 97);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(197, 22);
            this.txtbNombre.TabIndex = 2;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(252, 125);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(197, 22);
            this.txtbApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(188, 130);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(249, 158);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(128, 158);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(121, 17);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(212, 191);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 17);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "DNI";
            // 
            // txtbDNI
            // 
            this.txtbDNI.Location = new System.Drawing.Point(249, 186);
            this.txtbDNI.Name = "txtbDNI";
            this.txtbDNI.Size = new System.Drawing.Size(197, 22);
            this.txtbDNI.TabIndex = 8;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(0, 54);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(89, 21);
            this.rdbCasado.TabIndex = 9;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado/a";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbSoltero
            // 
            this.rdbSoltero.AutoSize = true;
            this.rdbSoltero.Location = new System.Drawing.Point(116, 54);
            this.rdbSoltero.Name = "rdbSoltero";
            this.rdbSoltero.Size = new System.Drawing.Size(86, 21);
            this.rdbSoltero.TabIndex = 10;
            this.rdbSoltero.TabStop = true;
            this.rdbSoltero.Text = "Soltero/a";
            this.rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbDivorciado
            // 
            this.rdbDivorciado.AutoSize = true;
            this.rdbDivorciado.Location = new System.Drawing.Point(226, 54);
            this.rdbDivorciado.Name = "rdbDivorciado";
            this.rdbDivorciado.Size = new System.Drawing.Size(108, 21);
            this.rdbDivorciado.TabIndex = 11;
            this.rdbDivorciado.TabStop = true;
            this.rdbDivorciado.Text = "Divorciado/a";
            this.rdbDivorciado.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(133, 18);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(81, 17);
            this.lblEstadoCivil.TabIndex = 12;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // grbEsatdoCivil
            // 
            this.grbEsatdoCivil.Controls.Add(this.rdbCasado);
            this.grbEsatdoCivil.Controls.Add(this.lblEstadoCivil);
            this.grbEsatdoCivil.Controls.Add(this.rdbSoltero);
            this.grbEsatdoCivil.Controls.Add(this.rdbDivorciado);
            this.grbEsatdoCivil.Location = new System.Drawing.Point(156, 269);
            this.grbEsatdoCivil.Name = "grbEsatdoCivil";
            this.grbEsatdoCivil.Size = new System.Drawing.Size(342, 100);
            this.grbEsatdoCivil.TabIndex = 13;
            this.grbEsatdoCivil.TabStop = false;
            // 
            // grbDomicilio
            // 
            this.grbDomicilio.Controls.Add(this.txtbLocalidad);
            this.grbDomicilio.Controls.Add(this.txtbProvincia);
            this.grbDomicilio.Controls.Add(this.txtbNumeroCalle);
            this.grbDomicilio.Controls.Add(this.txtbPiso);
            this.grbDomicilio.Controls.Add(this.txtbDepto);
            this.grbDomicilio.Controls.Add(this.txtbCalle);
            this.grbDomicilio.Controls.Add(this.lblProvincia);
            this.grbDomicilio.Controls.Add(this.lblDepto);
            this.grbDomicilio.Controls.Add(this.lblLocalidad);
            this.grbDomicilio.Controls.Add(this.lblNumero);
            this.grbDomicilio.Controls.Add(this.lblPiso);
            this.grbDomicilio.Controls.Add(this.lblCalle);
            this.grbDomicilio.Location = new System.Drawing.Point(12, 389);
            this.grbDomicilio.Name = "grbDomicilio";
            this.grbDomicilio.Size = new System.Drawing.Size(660, 172);
            this.grbDomicilio.TabIndex = 14;
            this.grbDomicilio.TabStop = false;
            this.grbDomicilio.Text = "Domicilio:";
            // 
            // txtbLocalidad
            // 
            this.txtbLocalidad.Location = new System.Drawing.Point(407, 40);
            this.txtbLocalidad.Name = "txtbLocalidad";
            this.txtbLocalidad.Size = new System.Drawing.Size(172, 22);
            this.txtbLocalidad.TabIndex = 11;
            // 
            // txtbProvincia
            // 
            this.txtbProvincia.Location = new System.Drawing.Point(407, 73);
            this.txtbProvincia.Name = "txtbProvincia";
            this.txtbProvincia.Size = new System.Drawing.Size(172, 22);
            this.txtbProvincia.TabIndex = 10;
            // 
            // txtbNumeroCalle
            // 
            this.txtbNumeroCalle.Location = new System.Drawing.Point(81, 75);
            this.txtbNumeroCalle.Name = "txtbNumeroCalle";
            this.txtbNumeroCalle.Size = new System.Drawing.Size(100, 22);
            this.txtbNumeroCalle.TabIndex = 9;
            // 
            // txtbPiso
            // 
            this.txtbPiso.Location = new System.Drawing.Point(81, 107);
            this.txtbPiso.Name = "txtbPiso";
            this.txtbPiso.Size = new System.Drawing.Size(100, 22);
            this.txtbPiso.TabIndex = 8;
            // 
            // txtbDepto
            // 
            this.txtbDepto.Location = new System.Drawing.Point(81, 135);
            this.txtbDepto.Name = "txtbDepto";
            this.txtbDepto.Size = new System.Drawing.Size(100, 22);
            this.txtbDepto.TabIndex = 7;
            // 
            // txtbCalle
            // 
            this.txtbCalle.Location = new System.Drawing.Point(81, 40);
            this.txtbCalle.Name = "txtbCalle";
            this.txtbCalle.Size = new System.Drawing.Size(100, 22);
            this.txtbCalle.TabIndex = 6;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(332, 78);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(70, 17);
            this.lblProvincia.TabIndex = 5;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(32, 140);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(46, 17);
            this.lblDepto.TabIndex = 4;
            this.lblDepto.Text = "Depto";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(332, 43);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(69, 17);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(32, 78);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(24, 17);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "N°";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(32, 110);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(35, 17);
            this.lblPiso.TabIndex = 1;
            this.lblPiso.Text = "Piso";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(32, 43);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(43, 17);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(193, 587);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(340, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(249, 222);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(197, 22);
            this.txtbEmail.TabIndex = 18;
            // 
            // frmRegistroPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 636);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grbDomicilio);
            this.Controls.Add(this.grbEsatdoCivil);
            this.Controls.Add(this.txtbDNI);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.grbEsatdoCivil.ResumeLayout(false);
            this.grbEsatdoCivil.PerformLayout();
            this.grbDomicilio.ResumeLayout(false);
            this.grbDomicilio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtbDNI;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSoltero;
        private System.Windows.Forms.RadioButton rdbDivorciado;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.GroupBox grbEsatdoCivil;
        private System.Windows.Forms.GroupBox grbDomicilio;
        private System.Windows.Forms.TextBox txtbLocalidad;
        private System.Windows.Forms.TextBox txtbProvincia;
        private System.Windows.Forms.TextBox txtbNumeroCalle;
        private System.Windows.Forms.TextBox txtbPiso;
        private System.Windows.Forms.TextBox txtbDepto;
        private System.Windows.Forms.TextBox txtbCalle;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbEmail;
    }
}

