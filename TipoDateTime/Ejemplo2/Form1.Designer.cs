
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
            this.clFecha = new System.Windows.Forms.MonthCalendar();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnDtp = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clFecha
            // 
            this.clFecha.Location = new System.Drawing.Point(53, 111);
            this.clFecha.Name = "clFecha";
            this.clFecha.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(62, 50);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnDtp
            // 
            this.btnDtp.Location = new System.Drawing.Point(494, 50);
            this.btnDtp.Name = "btnDtp";
            this.btnDtp.Size = new System.Drawing.Size(84, 37);
            this.btnDtp.TabIndex = 2;
            this.btnDtp.Text = "Prueba 1";
            this.btnDtp.UseVisualStyleBackColor = true;
            this.btnDtp.Click += new System.EventHandler(this.btnDtp_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(494, 111);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(84, 34);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Prueba 2";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnDtp);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.clFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar clFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnDtp;
        private System.Windows.Forms.Button btnCal;
    }
}

