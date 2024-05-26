
namespace ejemplo1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.LvElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chbChocolate = new System.Windows.Forms.CheckBox();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rdtMuggle = new System.Windows.Forms.RadioButton();
            this.rdtSquibs = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboFavorito = new System.Windows.Forms.ComboBox();
            this.numNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroFavorito = new System.Windows.Forms.Label();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(184, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(45, 623);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // LvElementos
            // 
            this.LvElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvElementos.HideSelection = false;
            this.LvElementos.Location = new System.Drawing.Point(45, 493);
            this.LvElementos.Name = "LvElementos";
            this.LvElementos.Size = new System.Drawing.Size(302, 124);
            this.LvElementos.TabIndex = 6;
            this.LvElementos.UseCompatibleStateImageBehavior = false;
            this.LvElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(42, 136);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(129, 17);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Nacimiento: ";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(184, 136);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(69, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 39);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // chbChocolate
            // 
            this.chbChocolate.AutoSize = true;
            this.chbChocolate.Location = new System.Drawing.Point(184, 195);
            this.chbChocolate.Name = "chbChocolate";
            this.chbChocolate.Size = new System.Drawing.Size(174, 21);
            this.chbChocolate.TabIndex = 2;
            this.chbChocolate.Text = "Te gusta el chocolate?";
            this.chbChocolate.UseVisualStyleBackColor = true;
            // 
            // rbtWizard
            // 
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Checked = true;
            this.rbtWizard.Location = new System.Drawing.Point(21, 32);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(73, 21);
            this.rbtWizard.TabIndex = 0;
            this.rbtWizard.TabStop = true;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rdtMuggle
            // 
            this.rdtMuggle.AutoSize = true;
            this.rdtMuggle.Location = new System.Drawing.Point(159, 32);
            this.rdtMuggle.Name = "rdtMuggle";
            this.rdtMuggle.Size = new System.Drawing.Size(75, 21);
            this.rdtMuggle.TabIndex = 1;
            this.rdtMuggle.Text = "muggle";
            this.rdtMuggle.UseVisualStyleBackColor = true;
            // 
            // rdtSquibs
            // 
            this.rdtSquibs.AutoSize = true;
            this.rdtSquibs.Location = new System.Drawing.Point(307, 32);
            this.rdtSquibs.Name = "rdtSquibs";
            this.rdtSquibs.Size = new System.Drawing.Size(72, 21);
            this.rdtSquibs.TabIndex = 2;
            this.rdtSquibs.Text = "Squibs";
            this.rdtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxTipo.Controls.Add(this.rdtSquibs);
            this.gbxTipo.Controls.Add(this.rbtWizard);
            this.gbxTipo.Controls.Add(this.rdtMuggle);
            this.gbxTipo.Location = new System.Drawing.Point(45, 242);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(423, 83);
            this.gbxTipo.TabIndex = 11;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(42, 355);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(130, 21);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color Favorito: ";
            // 
            // cboFavorito
            // 
            this.cboFavorito.FormattingEnabled = true;
            this.cboFavorito.Location = new System.Drawing.Point(184, 352);
            this.cboFavorito.Name = "cboFavorito";
            this.cboFavorito.Size = new System.Drawing.Size(200, 24);
            this.cboFavorito.TabIndex = 3;
            // 
            // numNumeroFavorito
            // 
            this.numNumeroFavorito.Location = new System.Drawing.Point(184, 399);
            this.numNumeroFavorito.Name = "numNumeroFavorito";
            this.numNumeroFavorito.Size = new System.Drawing.Size(135, 22);
            this.numNumeroFavorito.TabIndex = 4;
            // 
            // lblNumeroFavorito
            // 
            this.lblNumeroFavorito.AutoSize = true;
            this.lblNumeroFavorito.Location = new System.Drawing.Point(42, 401);
            this.lblNumeroFavorito.Name = "lblNumeroFavorito";
            this.lblNumeroFavorito.Size = new System.Drawing.Size(146, 21);
            this.lblNumeroFavorito.TabIndex = 15;
            this.lblNumeroFavorito.Text = "Numero favorito: ";
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPerfil.FlatAppearance.BorderSize = 2;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(45, 453);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 34);
            this.btnPerfil.TabIndex = 7;
            this.btnPerfil.Text = "Ver &Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 737);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.lblNumeroFavorito);
            this.Controls.Add(this.numNumeroFavorito);
            this.Controls.Add(this.cboFavorito);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.chbChocolate);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.LvElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximumSize = new System.Drawing.Size(1110, 876);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(888, 784);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView LvElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox chbChocolate;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rdtMuggle;
        private System.Windows.Forms.RadioButton rdtSquibs;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboFavorito;
        private System.Windows.Forms.NumericUpDown numNumeroFavorito;
        private System.Windows.Forms.Label lblNumeroFavorito;
        private System.Windows.Forms.Button btnPerfil;
    }
}

