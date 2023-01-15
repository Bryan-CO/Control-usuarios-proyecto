namespace Capa_Presentacion.GUI
{
    partial class Datos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_control = new System.Windows.Forms.Label();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(138)))), ((int)(((byte)(152)))));
            this.lbl_fecha.Location = new System.Drawing.Point(315, 362);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(74, 24);
            this.lbl_fecha.TabIndex = 14;
            this.lbl_fecha.Text = "label2";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_hora.Location = new System.Drawing.Point(355, 311);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(112, 39);
            this.lbl_hora.TabIndex = 13;
            this.lbl_hora.Text = "label2";
            // 
            // lbl_control
            // 
            this.lbl_control.AutoSize = true;
            this.lbl_control.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control.ForeColor = System.Drawing.Color.White;
            this.lbl_control.Location = new System.Drawing.Point(282, 64);
            this.lbl_control.Name = "lbl_control";
            this.lbl_control.Size = new System.Drawing.Size(290, 36);
            this.lbl_control.TabIndex = 12;
            this.lbl_control.Text = "Control de Usuarios";
            // 
            // pb_imagen
            // 
            this.pb_imagen.Image = ((System.Drawing.Image)(resources.GetObject("pb_imagen.Image")));
            this.pb_imagen.Location = new System.Drawing.Point(325, 116);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(195, 192);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagen.TabIndex = 11;
            this.pb_imagen.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_control);
            this.Controls.Add(this.pb_imagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datos";
            this.Text = "Datos";
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.Label lbl_hora;
        public System.Windows.Forms.Label lbl_control;
        public System.Windows.Forms.PictureBox pb_imagen;
        private System.Windows.Forms.Timer timer1;
    }
}