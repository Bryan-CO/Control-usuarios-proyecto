namespace Capa_Presentacion.GUI
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_autor = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_usuario_foto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.Label();
            this.panel_buscar = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_autor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.txt_busqueda);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 51);
            this.panel1.TabIndex = 0;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.txt_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_busqueda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.txt_busqueda.Location = new System.Drawing.Point(30, 16);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(267, 19);
            this.txt_busqueda.TabIndex = 1;
            this.txt_busqueda.Text = "Código de  usuario...";
            this.txt_busqueda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_busqueda_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(738, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.button1.Size = new System.Drawing.Size(133, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_autor
            // 
            this.pb_autor.Location = new System.Drawing.Point(184, 81);
            this.pb_autor.Name = "pb_autor";
            this.pb_autor.Size = new System.Drawing.Size(162, 198);
            this.pb_autor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_autor.TabIndex = 44;
            this.pb_autor.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(174, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 218);
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(189, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 218);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // txt_usuario_foto
            // 
            this.txt_usuario_foto.AutoSize = true;
            this.txt_usuario_foto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario_foto.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_usuario_foto.Location = new System.Drawing.Point(190, 31);
            this.txt_usuario_foto.Name = "txt_usuario_foto";
            this.txt_usuario_foto.Size = new System.Drawing.Size(71, 33);
            this.txt_usuario_foto.TabIndex = 57;
            this.txt_usuario_foto.Text = "uwu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(451, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Contraseña:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoSize = true;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_nombre.Location = new System.Drawing.Point(452, 272);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(46, 16);
            this.txt_nombre.TabIndex = 53;
            this.txt_nombre.Text = "label1";
            // 
            // txt_pass
            // 
            this.txt_pass.AutoSize = true;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_pass.Location = new System.Drawing.Point(450, 211);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(46, 16);
            this.txt_pass.TabIndex = 52;
            this.txt_pass.Text = "label1";
            this.txt_pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_apellido
            // 
            this.txt_apellido.AutoSize = true;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_apellido.Location = new System.Drawing.Point(453, 338);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(46, 16);
            this.txt_apellido.TabIndex = 51;
            this.txt_apellido.Text = "label1";
            // 
            // txt_codigo
            // 
            this.txt_codigo.AutoSize = true;
            this.txt_codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_codigo.Location = new System.Drawing.Point(452, 83);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(46, 16);
            this.txt_codigo.TabIndex = 50;
            this.txt_codigo.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(452, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 48;
            this.label8.Text = "Apellidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(452, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(452, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Código de usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(452, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 22);
            this.label10.TabIndex = 49;
            this.label10.Text = "Usuario";
            // 
            // txt_user
            // 
            this.txt_user.AutoSize = true;
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_user.Location = new System.Drawing.Point(455, 147);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(46, 16);
            this.txt_user.TabIndex = 55;
            this.txt_user.Text = "label1";
            // 
            // panel_buscar
            // 
            this.panel_buscar.Controls.Add(this.pb_autor);
            this.panel_buscar.Controls.Add(this.pictureBox2);
            this.panel_buscar.Controls.Add(this.pictureBox3);
            this.panel_buscar.Controls.Add(this.txt_usuario_foto);
            this.panel_buscar.Controls.Add(this.label1);
            this.panel_buscar.Controls.Add(this.txt_user);
            this.panel_buscar.Controls.Add(this.txt_nombre);
            this.panel_buscar.Controls.Add(this.txt_pass);
            this.panel_buscar.Controls.Add(this.txt_apellido);
            this.panel_buscar.Controls.Add(this.txt_codigo);
            this.panel_buscar.Controls.Add(this.label10);
            this.panel_buscar.Controls.Add(this.label8);
            this.panel_buscar.Controls.Add(this.label7);
            this.panel_buscar.Controls.Add(this.label5);
            this.panel_buscar.Location = new System.Drawing.Point(6, 5);
            this.panel_buscar.Name = "panel_buscar";
            this.panel_buscar.Size = new System.Drawing.Size(850, 388);
            this.panel_buscar.TabIndex = 60;
            this.panel_buscar.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(315, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(253, 257);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(871, 443);
            this.Controls.Add(this.panel_buscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_autor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_buscar.ResumeLayout(false);
            this.panel_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_autor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label txt_usuario_foto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.Label txt_pass;
        private System.Windows.Forms.Label txt_apellido;
        private System.Windows.Forms.Label txt_codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_user;
        private System.Windows.Forms.Panel panel_buscar;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}