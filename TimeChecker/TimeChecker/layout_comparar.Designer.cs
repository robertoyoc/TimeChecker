namespace TimeChecker
{
    partial class layout_comparar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(layout_comparar));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.cmb_nombres = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.grd_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_comparar = new System.Windows.Forms.Button();
            this.btnActualizarCmb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time Checker ©. 2017. Diseñado por Talentics ®. Todos los derechos reservados.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_salir
            // 
            this.btn_salir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_salir.Image = global::TimeChecker.Properties.Resources.Izquierda;
            this.btn_salir.Location = new System.Drawing.Point(3, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(60, 60);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 5;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // cmb_nombres
            // 
            this.cmb_nombres.FormattingEnabled = true;
            this.cmb_nombres.Location = new System.Drawing.Point(238, 41);
            this.cmb_nombres.Name = "cmb_nombres";
            this.cmb_nombres.Size = new System.Drawing.Size(212, 21);
            this.cmb_nombres.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecciona la persona:";
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(238, 69);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_incluir.TabIndex = 8;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(489, 20);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(112, 44);
            this.btn_insertar.TabIndex = 9;
            this.btn_insertar.Text = "Añadir Nueva Persona";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grd_Nombre,
            this.grd_eliminar});
            this.grd.Location = new System.Drawing.Point(165, 126);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(393, 150);
            this.grd.TabIndex = 10;
            // 
            // grd_Nombre
            // 
            this.grd_Nombre.HeaderText = "Nombre";
            this.grd_Nombre.MinimumWidth = 100;
            this.grd_Nombre.Name = "grd_Nombre";
            this.grd_Nombre.ReadOnly = true;
            this.grd_Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Nombre.Width = 250;
            // 
            // grd_eliminar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Eliminar";
            this.grd_eliminar.DefaultCellStyle = dataGridViewCellStyle1;
            this.grd_eliminar.HeaderText = "Eliminación";
            this.grd_eliminar.Name = "grd_eliminar";
            this.grd_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_eliminar.Text = "Eliminar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccionados actualmente";
            // 
            // btn_comparar
            // 
            this.btn_comparar.Location = new System.Drawing.Point(324, 282);
            this.btn_comparar.Name = "btn_comparar";
            this.btn_comparar.Size = new System.Drawing.Size(75, 23);
            this.btn_comparar.TabIndex = 12;
            this.btn_comparar.Text = "Comparar";
            this.btn_comparar.UseVisualStyleBackColor = true;
            this.btn_comparar.Click += new System.EventHandler(this.btn_comparar_Click);
            // 
            // btnActualizarCmb
            // 
            this.btnActualizarCmb.Location = new System.Drawing.Point(358, 69);
            this.btnActualizarCmb.Name = "btnActualizarCmb";
            this.btnActualizarCmb.Size = new System.Drawing.Size(92, 23);
            this.btnActualizarCmb.TabIndex = 13;
            this.btnActualizarCmb.Text = "Actualizar Lista";
            this.btnActualizarCmb.UseVisualStyleBackColor = true;
            this.btnActualizarCmb.Click += new System.EventHandler(this.btnActualizarCmb_Click);
            // 
            // layout_comparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 367);
            this.Controls.Add(this.btnActualizarCmb);
            this.Controls.Add(this.btn_comparar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_nombres);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "layout_comparar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Checker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.layout_comparar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.ComboBox cmb_nombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn grd_Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn grd_eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_comparar;
        private System.Windows.Forms.Button btnActualizarCmb;
    }
}