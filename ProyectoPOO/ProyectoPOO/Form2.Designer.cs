namespace ProyectoPOO
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioOscuro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botonExit = new System.Windows.Forms.PictureBox();
            this.logoLetras = new System.Windows.Forms.PictureBox();
            this.botonCambiar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.botonNueva = new System.Windows.Forms.Button();
            this.radioClaro = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.botonOscuro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLetras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioOscuro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.botonExit);
            this.panel1.Controls.Add(this.logoLetras);
            this.panel1.Controls.Add(this.botonCambiar);
            this.panel1.Controls.Add(this.botonBorrar);
            this.panel1.Controls.Add(this.botonNueva);
            this.panel1.Controls.Add(this.radioClaro);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.botonOscuro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 20;
            // 
            // radioOscuro
            // 
            this.radioOscuro.AutoSize = true;
            this.radioOscuro.BackColor = System.Drawing.Color.Transparent;
            this.radioOscuro.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOscuro.Location = new System.Drawing.Point(220, 70);
            this.radioOscuro.Name = "radioOscuro";
            this.radioOscuro.Size = new System.Drawing.Size(115, 37);
            this.radioOscuro.TabIndex = 30;
            this.radioOscuro.Text = "Oscuro";
            this.radioOscuro.UseVisualStyleBackColor = false;
            this.radioOscuro.CheckedChanged += new System.EventHandler(this.radioOscuro_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 45);
            this.label1.TabIndex = 27;
            this.label1.Text = "TEMAS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(232)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(543, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 34);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // botonExit
            // 
            this.botonExit.BackColor = System.Drawing.Color.Transparent;
            this.botonExit.Image = global::ProyectoPOO.Properties.Resources.exit;
            this.botonExit.Location = new System.Drawing.Point(37, 368);
            this.botonExit.Name = "botonExit";
            this.botonExit.Size = new System.Drawing.Size(76, 70);
            this.botonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonExit.TabIndex = 24;
            this.botonExit.TabStop = false;
            this.botonExit.Click += new System.EventHandler(this.botonExit_Click_1);
            // 
            // logoLetras
            // 
            this.logoLetras.BackColor = System.Drawing.Color.Transparent;
            this.logoLetras.Image = global::ProyectoPOO.Properties.Resources.logotipo;
            this.logoLetras.Location = new System.Drawing.Point(37, 12);
            this.logoLetras.Name = "logoLetras";
            this.logoLetras.Size = new System.Drawing.Size(76, 66);
            this.logoLetras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoLetras.TabIndex = 23;
            this.logoLetras.TabStop = false;
            // 
            // botonCambiar
            // 
            this.botonCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(201)))), ((int)(((byte)(66)))));
            this.botonCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCambiar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCambiar.ForeColor = System.Drawing.Color.White;
            this.botonCambiar.Location = new System.Drawing.Point(174, 368);
            this.botonCambiar.Name = "botonCambiar";
            this.botonCambiar.Size = new System.Drawing.Size(248, 42);
            this.botonCambiar.TabIndex = 22;
            this.botonCambiar.Text = "Cambiar de Cuenta";
            this.botonCambiar.UseVisualStyleBackColor = false;
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(30)))));
            this.botonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBorrar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.ForeColor = System.Drawing.Color.White;
            this.botonBorrar.Location = new System.Drawing.Point(174, 319);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(248, 43);
            this.botonBorrar.TabIndex = 21;
            this.botonBorrar.Text = "Borrar una Cuenta";
            this.botonBorrar.UseVisualStyleBackColor = false;
            // 
            // botonNueva
            // 
            this.botonNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(169)))), ((int)(((byte)(245)))));
            this.botonNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonNueva.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNueva.ForeColor = System.Drawing.Color.White;
            this.botonNueva.Location = new System.Drawing.Point(174, 266);
            this.botonNueva.Name = "botonNueva";
            this.botonNueva.Size = new System.Drawing.Size(248, 45);
            this.botonNueva.TabIndex = 20;
            this.botonNueva.Text = "Crear Cuenta Nueva";
            this.botonNueva.UseVisualStyleBackColor = false;
            // 
            // radioClaro
            // 
            this.radioClaro.AutoSize = true;
            this.radioClaro.BackColor = System.Drawing.Color.Transparent;
            this.radioClaro.Checked = true;
            this.radioClaro.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioClaro.Location = new System.Drawing.Point(603, 70);
            this.radioClaro.Name = "radioClaro";
            this.radioClaro.Size = new System.Drawing.Size(94, 37);
            this.radioClaro.TabIndex = 29;
            this.radioClaro.TabStop = true;
            this.radioClaro.Text = "Claro";
            this.radioClaro.UseVisualStyleBackColor = false;
            this.radioClaro.CheckedChanged += new System.EventHandler(this.radioClaro_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 45);
            this.label4.TabIndex = 28;
            this.label4.Text = "CUENTAS";
            // 
            // botonOscuro
            // 
            this.botonOscuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.botonOscuro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonOscuro.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonOscuro.ForeColor = System.Drawing.Color.White;
            this.botonOscuro.Location = new System.Drawing.Point(174, 113);
            this.botonOscuro.Name = "botonOscuro";
            this.botonOscuro.Size = new System.Drawing.Size(221, 34);
            this.botonOscuro.TabIndex = 25;
            this.botonOscuro.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Configuracion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLetras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioOscuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox botonExit;
        private System.Windows.Forms.PictureBox logoLetras;
        private System.Windows.Forms.Button botonCambiar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button botonNueva;
        private System.Windows.Forms.RadioButton radioClaro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonOscuro;
    }
}