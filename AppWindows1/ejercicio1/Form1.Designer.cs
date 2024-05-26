
namespace ejercicio1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.txtSaludo = new System.Windows.Forms.TextBox();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaludo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaludo.Image = ((System.Drawing.Image)(resources.GetObject("btnSaludo.Image")));
            this.btnSaludo.Location = new System.Drawing.Point(170, 141);
            this.btnSaludo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(56, 52);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Saludo";
            this.btnSaludo.UseVisualStyleBackColor = false;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaludo.Location = new System.Drawing.Point(113, 49);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(56, 15);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.Text = "Saludo: ";
            this.lblSaludo.MouseLeave += new System.EventHandler(this.lblSaludo_MouseLeave);
            this.lblSaludo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSaludo_MouseMove);
            // 
            // txtSaludo
            // 
            this.txtSaludo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaludo.Location = new System.Drawing.Point(276, 141);
            this.txtSaludo.MaxLength = 5;
            this.txtSaludo.Name = "txtSaludo";
            this.txtSaludo.Size = new System.Drawing.Size(100, 20);
            this.txtSaludo.TabIndex = 2;
            this.txtSaludo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaludo_KeyPress);
            // 
            // txtOtro
            // 
            this.txtOtro.Location = new System.Drawing.Point(276, 239);
            this.txtOtro.Multiline = true;
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOtro.Size = new System.Drawing.Size(100, 20);
            this.txtOtro.TabIndex = 3;
            this.txtOtro.Leave += new System.EventHandler(this.txtOtro_Leave);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(642, 434);
            this.Controls.Add(this.txtOtro);
            this.Controls.Add(this.txtSaludo);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.btnSaludo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Click += new System.EventHandler(this.frmPrincipal_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.TextBox txtSaludo;
        private System.Windows.Forms.TextBox txtOtro;
    }
}

