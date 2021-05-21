namespace ProyectoPOO
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
            this.botonPuntos = new System.Windows.Forms.Button();
            this.botonTiempo = new System.Windows.Forms.Button();
            this.botonTutorial = new System.Windows.Forms.Button();
            this.botonExit = new System.Windows.Forms.PictureBox();
            this.logoLetras = new System.Windows.Forms.PictureBox();
            this.logoGato = new System.Windows.Forms.PictureBox();
            this.botonConfiguracion = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.botonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoGato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonConfiguracion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonPuntos
            // 
            this.botonPuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(169)))), ((int)(((byte)(245)))));
            this.botonPuntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPuntos.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPuntos.ForeColor = System.Drawing.Color.White;
            this.botonPuntos.Location = new System.Drawing.Point(254, 225);
            this.botonPuntos.Name = "botonPuntos";
            this.botonPuntos.Size = new System.Drawing.Size(248, 60);
            this.botonPuntos.TabIndex = 0;
            this.botonPuntos.Text = "Jugar por Puntos";
            this.botonPuntos.UseVisualStyleBackColor = false;
            // 
            // botonTiempo
            // 
            this.botonTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(30)))));
            this.botonTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTiempo.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonTiempo.ForeColor = System.Drawing.Color.White;
            this.botonTiempo.Location = new System.Drawing.Point(254, 291);
            this.botonTiempo.Name = "botonTiempo";
            this.botonTiempo.Size = new System.Drawing.Size(248, 60);
            this.botonTiempo.TabIndex = 1;
            this.botonTiempo.Text = "Jugar por Tiempo";
            this.botonTiempo.UseVisualStyleBackColor = false;
            // 
            // botonTutorial
            // 
            this.botonTutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(201)))), ((int)(((byte)(66)))));
            this.botonTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTutorial.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonTutorial.ForeColor = System.Drawing.Color.White;
            this.botonTutorial.Location = new System.Drawing.Point(254, 357);
            this.botonTutorial.Name = "botonTutorial";
            this.botonTutorial.Size = new System.Drawing.Size(248, 60);
            this.botonTutorial.TabIndex = 2;
            this.botonTutorial.Text = "Tutorial";
            this.botonTutorial.UseVisualStyleBackColor = false;
            // 
            // botonExit
            // 
            this.botonExit.BackColor = System.Drawing.Color.Transparent;
            this.botonExit.Image = global::ProyectoPOO.Properties.Resources.exit;
            this.botonExit.Location = new System.Drawing.Point(12, 377);
            this.botonExit.Name = "botonExit";
            this.botonExit.Size = new System.Drawing.Size(76, 70);
            this.botonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonExit.TabIndex = 6;
            this.botonExit.TabStop = false;
            this.botonExit.Click += new System.EventHandler(this.botonExit_Click);
            // 
            // logoLetras
            // 
            this.logoLetras.BackColor = System.Drawing.Color.Transparent;
            this.logoLetras.Image = global::ProyectoPOO.Properties.Resources.logotipo;
            this.logoLetras.Location = new System.Drawing.Point(203, 0);
            this.logoLetras.Name = "logoLetras";
            this.logoLetras.Size = new System.Drawing.Size(367, 205);
            this.logoLetras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoLetras.TabIndex = 5;
            this.logoLetras.TabStop = false;
            // 
            // logoGato
            // 
            this.logoGato.BackColor = System.Drawing.Color.Transparent;
            this.logoGato.Image = global::ProyectoPOO.Properties.Resources.michi3;
            this.logoGato.Location = new System.Drawing.Point(604, 199);
            this.logoGato.Name = "logoGato";
            this.logoGato.Size = new System.Drawing.Size(184, 239);
            this.logoGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoGato.TabIndex = 4;
            this.logoGato.TabStop = false;
            // 
            // botonConfiguracion
            // 
            this.botonConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.botonConfiguracion.Image = global::ProyectoPOO.Properties.Resources.gear;
            this.botonConfiguracion.Location = new System.Drawing.Point(12, 301);
            this.botonConfiguracion.Name = "botonConfiguracion";
            this.botonConfiguracion.Size = new System.Drawing.Size(76, 70);
            this.botonConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonConfiguracion.TabIndex = 3;
            this.botonConfiguracion.TabStop = false;
            this.botonConfiguracion.Click += new System.EventHandler(this.botonConfiguracion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botonConfiguracion);
            this.panel1.Controls.Add(this.logoLetras);
            this.panel1.Controls.Add(this.botonExit);
            this.panel1.Controls.Add(this.logoGato);
            this.panel1.Controls.Add(this.botonTutorial);
            this.panel1.Controls.Add(this.botonPuntos);
            this.panel1.Controls.Add(this.botonTiempo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "LinceABC";
            ((System.ComponentModel.ISupportInitialize)(this.botonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoGato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonConfiguracion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonPuntos;
        private System.Windows.Forms.Button botonTiempo;
        private System.Windows.Forms.Button botonTutorial;
        private System.Windows.Forms.PictureBox logoGato;
        private System.Windows.Forms.PictureBox logoLetras;
        private System.Windows.Forms.PictureBox botonExit;
        private System.Windows.Forms.PictureBox botonConfiguracion;
        private System.Windows.Forms.Panel panel1;
    }
}

