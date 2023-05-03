namespace Barcos
{
    partial class FormJuego
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTrampa = new System.Windows.Forms.Button();
            this.lbTurnoQuien = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.pbCanon = new System.Windows.Forms.PictureBox();
            this.pOponente = new System.Windows.Forms.Panel();
            this.pJugador = new System.Windows.Forms.Panel();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.btnCargarBarcos = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pbVidaOponente = new System.Windows.Forms.ProgressBar();
            this.lbNombreJugador = new System.Windows.Forms.Label();
            this.pbVidaJugador = new System.Windows.Forms.ProgressBar();
            this.pbOponente = new System.Windows.Forms.PictureBox();
            this.lbTextoPj = new System.Windows.Forms.Label();
            this.pbJugador = new System.Windows.Forms.PictureBox();
            this.lbNombreOponente = new System.Windows.Forms.Label();
            this.btnDisparar = new System.Windows.Forms.Button();
            this.lbEjeY = new System.Windows.Forms.Label();
            this.lbEjeX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOponente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Barcos.Properties.Resources.barcoOscuro;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.btnTrampa);
            this.splitContainer1.Panel1.Controls.Add(this.lbTurnoQuien);
            this.splitContainer1.Panel1.Controls.Add(this.lbTiempo);
            this.splitContainer1.Panel1.Controls.Add(this.pbCanon);
            this.splitContainer1.Panel1.Controls.Add(this.pOponente);
            this.splitContainer1.Panel1.Controls.Add(this.pJugador);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.BackgroundImage = global::Barcos.Properties.Resources.ActionBarBarcos2;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.nudY);
            this.splitContainer1.Panel2.Controls.Add(this.nudX);
            this.splitContainer1.Panel2.Controls.Add(this.btnCargarBarcos);
            this.splitContainer1.Panel2.Controls.Add(this.btnIniciar);
            this.splitContainer1.Panel2.Controls.Add(this.lbTitulo);
            this.splitContainer1.Panel2.Controls.Add(this.pbVidaOponente);
            this.splitContainer1.Panel2.Controls.Add(this.lbNombreJugador);
            this.splitContainer1.Panel2.Controls.Add(this.pbVidaJugador);
            this.splitContainer1.Panel2.Controls.Add(this.pbOponente);
            this.splitContainer1.Panel2.Controls.Add(this.lbTextoPj);
            this.splitContainer1.Panel2.Controls.Add(this.pbJugador);
            this.splitContainer1.Panel2.Controls.Add(this.lbNombreOponente);
            this.splitContainer1.Panel2.Controls.Add(this.btnDisparar);
            this.splitContainer1.Panel2.Controls.Add(this.lbEjeY);
            this.splitContainer1.Panel2.Controls.Add(this.lbEjeX);
            this.splitContainer1.Size = new System.Drawing.Size(1163, 676);
            this.splitContainer1.SplitterDistance = 538;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnTrampa
            // 
            this.btnTrampa.BackColor = System.Drawing.Color.Transparent;
            this.btnTrampa.FlatAppearance.BorderSize = 0;
            this.btnTrampa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTrampa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTrampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrampa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrampa.Location = new System.Drawing.Point(523, 521);
            this.btnTrampa.Name = "btnTrampa";
            this.btnTrampa.Size = new System.Drawing.Size(107, 10);
            this.btnTrampa.TabIndex = 27;
            this.btnTrampa.UseVisualStyleBackColor = false;
            this.btnTrampa.Click += new System.EventHandler(this.btnTrampa_Click);
            // 
            // lbTurnoQuien
            // 
            this.lbTurnoQuien.AutoSize = true;
            this.lbTurnoQuien.BackColor = System.Drawing.Color.Transparent;
            this.lbTurnoQuien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurnoQuien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbTurnoQuien.Location = new System.Drawing.Point(520, 87);
            this.lbTurnoQuien.Name = "lbTurnoQuien";
            this.lbTurnoQuien.Size = new System.Drawing.Size(52, 18);
            this.lbTurnoQuien.TabIndex = 26;
            this.lbTurnoQuien.Text = "Turno";
            this.lbTurnoQuien.Visible = false;
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbTiempo.Location = new System.Drawing.Point(559, 33);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(46, 31);
            this.lbTiempo.TabIndex = 25;
            this.lbTiempo.Text = "15";
            this.lbTiempo.Visible = false;
            // 
            // pbCanon
            // 
            this.pbCanon.BackColor = System.Drawing.Color.Transparent;
            this.pbCanon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCanon.Location = new System.Drawing.Point(526, 225);
            this.pbCanon.Name = "pbCanon";
            this.pbCanon.Size = new System.Drawing.Size(104, 94);
            this.pbCanon.TabIndex = 20;
            this.pbCanon.TabStop = false;
            // 
            // pOponente
            // 
            this.pOponente.BackColor = System.Drawing.Color.Transparent;
            this.pOponente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOponente.Location = new System.Drawing.Point(636, 3);
            this.pOponente.Name = "pOponente";
            this.pOponente.Size = new System.Drawing.Size(520, 528);
            this.pOponente.TabIndex = 20;
            // 
            // pJugador
            // 
            this.pJugador.BackColor = System.Drawing.Color.Transparent;
            this.pJugador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pJugador.Location = new System.Drawing.Point(3, 3);
            this.pJugador.Name = "pJugador";
            this.pJugador.Size = new System.Drawing.Size(517, 528);
            this.pJugador.TabIndex = 11;
            // 
            // nudY
            // 
            this.nudY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nudY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudY.Location = new System.Drawing.Point(637, 95);
            this.nudY.Name = "nudY";
            this.nudY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudY.Size = new System.Drawing.Size(67, 25);
            this.nudY.TabIndex = 35;
            this.nudY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudY.Visible = false;
            // 
            // nudX
            // 
            this.nudX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nudX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudX.Location = new System.Drawing.Point(457, 96);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(67, 25);
            this.nudX.TabIndex = 34;
            this.nudX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudX.Visible = false;
            // 
            // btnCargarBarcos
            // 
            this.btnCargarBarcos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCargarBarcos.FlatAppearance.BorderSize = 0;
            this.btnCargarBarcos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarBarcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarBarcos.Location = new System.Drawing.Point(135, 93);
            this.btnCargarBarcos.Name = "btnCargarBarcos";
            this.btnCargarBarcos.Size = new System.Drawing.Size(98, 23);
            this.btnCargarBarcos.TabIndex = 30;
            this.btnCargarBarcos.Text = "Cargar barcos";
            this.btnCargarBarcos.UseVisualStyleBackColor = false;
            this.btnCargarBarcos.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(895, 94);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(56, 23);
            this.btnIniciar.TabIndex = 20;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Visible = false;
            this.btnIniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(534, 3);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(0, 16);
            this.lbTitulo.TabIndex = 28;
            this.lbTitulo.UseCompatibleTextRendering = true;
            // 
            // pbVidaOponente
            // 
            this.pbVidaOponente.Location = new System.Drawing.Point(1031, 4);
            this.pbVidaOponente.Name = "pbVidaOponente";
            this.pbVidaOponente.Size = new System.Drawing.Size(125, 17);
            this.pbVidaOponente.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbVidaOponente.TabIndex = 27;
            // 
            // lbNombreJugador
            // 
            this.lbNombreJugador.AutoSize = true;
            this.lbNombreJugador.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreJugador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbNombreJugador.Location = new System.Drawing.Point(37, 112);
            this.lbNombreJugador.Name = "lbNombreJugador";
            this.lbNombreJugador.Size = new System.Drawing.Size(0, 16);
            this.lbNombreJugador.TabIndex = 26;
            // 
            // pbVidaJugador
            // 
            this.pbVidaJugador.Location = new System.Drawing.Point(1, 3);
            this.pbVidaJugador.Name = "pbVidaJugador";
            this.pbVidaJugador.Size = new System.Drawing.Size(125, 17);
            this.pbVidaJugador.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbVidaJugador.TabIndex = 25;
            // 
            // pbOponente
            // 
            this.pbOponente.BackColor = System.Drawing.Color.Transparent;
            this.pbOponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOponente.Location = new System.Drawing.Point(1029, 21);
            this.pbOponente.Name = "pbOponente";
            this.pbOponente.Size = new System.Drawing.Size(125, 94);
            this.pbOponente.TabIndex = 24;
            this.pbOponente.TabStop = false;
            // 
            // lbTextoPj
            // 
            this.lbTextoPj.BackColor = System.Drawing.Color.Transparent;
            this.lbTextoPj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbTextoPj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoPj.Location = new System.Drawing.Point(400, 21);
            this.lbTextoPj.Name = "lbTextoPj";
            this.lbTextoPj.Size = new System.Drawing.Size(466, 47);
            this.lbTextoPj.TabIndex = 21;
            this.lbTextoPj.UseCompatibleTextRendering = true;
            // 
            // pbJugador
            // 
            this.pbJugador.BackColor = System.Drawing.Color.Transparent;
            this.pbJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJugador.Location = new System.Drawing.Point(0, 23);
            this.pbJugador.Name = "pbJugador";
            this.pbJugador.Size = new System.Drawing.Size(125, 94);
            this.pbJugador.TabIndex = 20;
            this.pbJugador.TabStop = false;
            // 
            // lbNombreOponente
            // 
            this.lbNombreOponente.AutoSize = true;
            this.lbNombreOponente.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreOponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreOponente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbNombreOponente.Location = new System.Drawing.Point(1059, 112);
            this.lbNombreOponente.Name = "lbNombreOponente";
            this.lbNombreOponente.Size = new System.Drawing.Size(0, 16);
            this.lbNombreOponente.TabIndex = 16;
            // 
            // btnDisparar
            // 
            this.btnDisparar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDisparar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisparar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisparar.Location = new System.Drawing.Point(544, 97);
            this.btnDisparar.Name = "btnDisparar";
            this.btnDisparar.Size = new System.Drawing.Size(75, 23);
            this.btnDisparar.TabIndex = 14;
            this.btnDisparar.Text = "Disparar";
            this.btnDisparar.UseVisualStyleBackColor = false;
            this.btnDisparar.Visible = false;
            // 
            // lbEjeY
            // 
            this.lbEjeY.AutoSize = true;
            this.lbEjeY.BackColor = System.Drawing.Color.Transparent;
            this.lbEjeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEjeY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbEjeY.Location = new System.Drawing.Point(709, 96);
            this.lbEjeY.Name = "lbEjeY";
            this.lbEjeY.Size = new System.Drawing.Size(29, 24);
            this.lbEjeY.TabIndex = 18;
            this.lbEjeY.Text = ":Y";
            this.lbEjeY.Visible = false;
            // 
            // lbEjeX
            // 
            this.lbEjeX.AutoSize = true;
            this.lbEjeX.BackColor = System.Drawing.Color.Transparent;
            this.lbEjeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEjeX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbEjeX.Location = new System.Drawing.Point(423, 96);
            this.lbEjeX.Name = "lbEjeX";
            this.lbEjeX.Size = new System.Drawing.Size(31, 24);
            this.lbEjeX.TabIndex = 17;
            this.lbEjeX.Text = "X:";
            this.lbEjeX.Visible = false;
            // 
            // FormJuego
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 676);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJuego";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOponente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pJugador;
        private System.Windows.Forms.Button btnDisparar;
        private System.Windows.Forms.Label lbNombreOponente;
        private System.Windows.Forms.Label lbEjeY;
        private System.Windows.Forms.Label lbEjeX;
        private System.Windows.Forms.Panel pOponente;
        private System.Windows.Forms.PictureBox pbJugador;
        private System.Windows.Forms.Label lbTextoPj;
        private System.Windows.Forms.PictureBox pbOponente;
        private System.Windows.Forms.ProgressBar pbVidaOponente;
        private System.Windows.Forms.Label lbNombreJugador;
        private System.Windows.Forms.ProgressBar pbVidaJugador;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pbCanon;
        private System.Windows.Forms.Button btnCargarBarcos;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label lbTurnoQuien;
        private System.Windows.Forms.Button btnTrampa;
    }
}

