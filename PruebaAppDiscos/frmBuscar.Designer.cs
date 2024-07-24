namespace PruebaAppDiscos
{
    partial class frmBuscar
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.bttModificar = new System.Windows.Forms.Button();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttEliFisico = new System.Windows.Forms.Button();
            this.bttEliLogi = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblFiltrosimple = new System.Windows.Forms.Label();
            this.lblFiltroAvan = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.bttBuscarAvan = new System.Windows.Forms.Button();
            this.txbBuscarSimple = new System.Windows.Forms.TextBox();
            this.cbxBuscarSimple = new System.Windows.Forms.ComboBox();
            this.txbFiltroAvan = new System.Windows.Forms.TextBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscos.Location = new System.Drawing.Point(12, 67);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(653, 291);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // bttAceptar
            // 
            this.bttAceptar.Location = new System.Drawing.Point(23, 374);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttAceptar.TabIndex = 1;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(590, 374);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 2;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // bttModificar
            // 
            this.bttModificar.Location = new System.Drawing.Point(231, 374);
            this.bttModificar.Name = "bttModificar";
            this.bttModificar.Size = new System.Drawing.Size(75, 23);
            this.bttModificar.TabIndex = 3;
            this.bttModificar.Text = "Modificar";
            this.bttModificar.UseVisualStyleBackColor = true;
            this.bttModificar.Click += new System.EventHandler(this.bttModificar_Click);
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(150, 374);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttAgregar.TabIndex = 4;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttEliFisico
            // 
            this.bttEliFisico.Location = new System.Drawing.Point(415, 374);
            this.bttEliFisico.Name = "bttEliFisico";
            this.bttEliFisico.Size = new System.Drawing.Size(100, 23);
            this.bttEliFisico.TabIndex = 5;
            this.bttEliFisico.Text = "Eliminar Fisico";
            this.bttEliFisico.UseVisualStyleBackColor = true;
            this.bttEliFisico.Click += new System.EventHandler(this.bttEliFisico_Click);
            // 
            // bttEliLogi
            // 
            this.bttEliLogi.Location = new System.Drawing.Point(312, 374);
            this.bttEliLogi.Name = "bttEliLogi";
            this.bttEliLogi.Size = new System.Drawing.Size(97, 23);
            this.bttEliLogi.TabIndex = 6;
            this.bttEliLogi.Text = "Eliminar Logico";
            this.bttEliLogi.UseVisualStyleBackColor = true;
            this.bttEliLogi.Click += new System.EventHandler(this.bttEliLogi_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(38, 40);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar:";
            // 
            // lblFiltrosimple
            // 
            this.lblFiltrosimple.AutoSize = true;
            this.lblFiltrosimple.Location = new System.Drawing.Point(20, 14);
            this.lblFiltrosimple.Name = "lblFiltrosimple";
            this.lblFiltrosimple.Size = new System.Drawing.Size(61, 13);
            this.lblFiltrosimple.TabIndex = 8;
            this.lblFiltrosimple.Text = "Buscar por:";
            // 
            // lblFiltroAvan
            // 
            this.lblFiltroAvan.AutoSize = true;
            this.lblFiltroAvan.Location = new System.Drawing.Point(254, 14);
            this.lblFiltroAvan.Name = "lblFiltroAvan";
            this.lblFiltroAvan.Size = new System.Drawing.Size(83, 13);
            this.lblFiltroAvan.TabIndex = 9;
            this.lblFiltroAvan.Text = "Filtro Avanzado:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(294, 43);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(457, 40);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 11;
            this.lblCriterio.Text = "Criterio:";
            // 
            // bttBuscarAvan
            // 
            this.bttBuscarAvan.Location = new System.Drawing.Point(637, 5);
            this.bttBuscarAvan.Name = "bttBuscarAvan";
            this.bttBuscarAvan.Size = new System.Drawing.Size(28, 29);
            this.bttBuscarAvan.TabIndex = 12;
            this.bttBuscarAvan.Text = "+";
            this.bttBuscarAvan.UseVisualStyleBackColor = true;
            // 
            // txbBuscarSimple
            // 
            this.txbBuscarSimple.Location = new System.Drawing.Point(87, 37);
            this.txbBuscarSimple.Name = "txbBuscarSimple";
            this.txbBuscarSimple.Size = new System.Drawing.Size(153, 20);
            this.txbBuscarSimple.TabIndex = 13;
            // 
            // cbxBuscarSimple
            // 
            this.cbxBuscarSimple.FormattingEnabled = true;
            this.cbxBuscarSimple.Location = new System.Drawing.Point(87, 10);
            this.cbxBuscarSimple.Name = "cbxBuscarSimple";
            this.cbxBuscarSimple.Size = new System.Drawing.Size(75, 21);
            this.cbxBuscarSimple.TabIndex = 14;
            // 
            // txbFiltroAvan
            // 
            this.txbFiltroAvan.Location = new System.Drawing.Point(343, 10);
            this.txbFiltroAvan.Name = "txbFiltroAvan";
            this.txbFiltroAvan.Size = new System.Drawing.Size(288, 20);
            this.txbFiltroAvan.TabIndex = 15;
            // 
            // cbxCampo
            // 
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(343, 36);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(111, 21);
            this.cbxCampo.TabIndex = 16;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(505, 36);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(126, 21);
            this.cbxCriterio.TabIndex = 17;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 409);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.txbFiltroAvan);
            this.Controls.Add(this.cbxBuscarSimple);
            this.Controls.Add(this.txbBuscarSimple);
            this.Controls.Add(this.bttBuscarAvan);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblFiltroAvan);
            this.Controls.Add(this.lblFiltrosimple);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.bttEliLogi);
            this.Controls.Add(this.bttEliFisico);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.bttModificar);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Button bttModificar;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttEliFisico;
        private System.Windows.Forms.Button bttEliLogi;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblFiltrosimple;
        private System.Windows.Forms.Label lblFiltroAvan;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Button bttBuscarAvan;
        private System.Windows.Forms.TextBox txbBuscarSimple;
        private System.Windows.Forms.ComboBox cbxBuscarSimple;
        private System.Windows.Forms.TextBox txbFiltroAvan;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
    }
}