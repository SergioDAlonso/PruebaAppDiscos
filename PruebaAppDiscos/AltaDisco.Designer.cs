namespace PruebaAppDiscos
{
    partial class frmAltaDisco
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
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxEstilo = new System.Windows.Forms.ComboBox();
            this.txbUrlImagenTapa = new System.Windows.Forms.TextBox();
            this.lblUrlImagenTapa = new System.Windows.Forms.Label();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.txbCantCanc = new System.Windows.Forms.TextBox();
            this.pcbTapa = new System.Windows.Forms.PictureBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.lblTedi = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblCantCanc = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(126, 249);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(144, 21);
            this.cbxTipo.TabIndex = 51;
            // 
            // cbxEstilo
            // 
            this.cbxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstilo.FormattingEnabled = true;
            this.cbxEstilo.Location = new System.Drawing.Point(126, 209);
            this.cbxEstilo.Name = "cbxEstilo";
            this.cbxEstilo.Size = new System.Drawing.Size(144, 21);
            this.cbxEstilo.TabIndex = 50;
            // 
            // txbUrlImagenTapa
            // 
            this.txbUrlImagenTapa.Location = new System.Drawing.Point(126, 171);
            this.txbUrlImagenTapa.Name = "txbUrlImagenTapa";
            this.txbUrlImagenTapa.Size = new System.Drawing.Size(144, 20);
            this.txbUrlImagenTapa.TabIndex = 49;
            this.txbUrlImagenTapa.Leave += new System.EventHandler(this.txbUrlImagenTapa_Leave);
            // 
            // lblUrlImagenTapa
            // 
            this.lblUrlImagenTapa.AutoSize = true;
            this.lblUrlImagenTapa.Location = new System.Drawing.Point(45, 174);
            this.lblUrlImagenTapa.Name = "lblUrlImagenTapa";
            this.lblUrlImagenTapa.Size = new System.Drawing.Size(83, 13);
            this.lblUrlImagenTapa.TabIndex = 48;
            this.lblUrlImagenTapa.Text = "UrlImagenTapa:";
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(486, 340);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 46;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // bttAgregar
            // 
            this.bttAgregar.AllowDrop = true;
            this.bttAgregar.Location = new System.Drawing.Point(227, 340);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttAgregar.TabIndex = 45;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // txbCantCanc
            // 
            this.txbCantCanc.Location = new System.Drawing.Point(126, 127);
            this.txbCantCanc.Name = "txbCantCanc";
            this.txbCantCanc.Size = new System.Drawing.Size(144, 20);
            this.txbCantCanc.TabIndex = 44;
            // 
            // pcbTapa
            // 
            this.pcbTapa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbTapa.Location = new System.Drawing.Point(289, 52);
            this.pcbTapa.Name = "pcbTapa";
            this.pcbTapa.Size = new System.Drawing.Size(246, 250);
            this.pcbTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTapa.TabIndex = 43;
            this.pcbTapa.TabStop = false;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(126, 49);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(144, 20);
            this.txbTitulo.TabIndex = 42;
            // 
            // lblTedi
            // 
            this.lblTedi.AutoSize = true;
            this.lblTedi.Location = new System.Drawing.Point(36, 252);
            this.lblTedi.Name = "lblTedi";
            this.lblTedi.Size = new System.Drawing.Size(84, 13);
            this.lblTedi.TabIndex = 40;
            this.lblTedi.Text = "Tipo de Edicion:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(85, 212);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(35, 13);
            this.lblEstilo.TabIndex = 39;
            this.lblEstilo.Text = "Estilo:";
            // 
            // lblCantCanc
            // 
            this.lblCantCanc.AutoSize = true;
            this.lblCantCanc.Location = new System.Drawing.Point(8, 130);
            this.lblCantCanc.Name = "lblCantCanc";
            this.lblCantCanc.Size = new System.Drawing.Size(120, 13);
            this.lblCantCanc.TabIndex = 38;
            this.lblCantCanc.Text = "Cantidad de Canciones:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(84, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(8, 88);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 13);
            this.lblFecha.TabIndex = 37;
            this.lblFecha.Text = "Fecha de Lanzamiento:";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(126, 82);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(144, 20);
            this.dtFecha.TabIndex = 52;
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 387);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxEstilo);
            this.Controls.Add(this.txbUrlImagenTapa);
            this.Controls.Add(this.lblUrlImagenTapa);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.txbCantCanc);
            this.Controls.Add(this.pcbTapa);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.lblTedi);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblCantCanc);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaDisco";
            this.Text = "AltaDisco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxEstilo;
        private System.Windows.Forms.TextBox txbUrlImagenTapa;
        private System.Windows.Forms.Label lblUrlImagenTapa;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.TextBox txbCantCanc;
        private System.Windows.Forms.PictureBox pcbTapa;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label lblTedi;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblCantCanc;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}