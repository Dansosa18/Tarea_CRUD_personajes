namespace DB_1
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
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.numericUpDownNivelPoder = new System.Windows.Forms.NumericUpDown();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.dateTimePickerFecha_Creacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxHistoria = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(215, 12);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(83, 33);
            this.buttonPrueba.TabIndex = 0;
            this.buttonPrueba.Text = "Prueba";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.Prueba_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(37, 51);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(695, 150);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(342, 10);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(112, 35);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel_Poder";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(37, 236);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(92, 20);
            this.textBoxId.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(151, 236);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(92, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(254, 236);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(92, 20);
            this.textBoxRaza.TabIndex = 9;
            // 
            // numericUpDownNivelPoder
            // 
            this.numericUpDownNivelPoder.Location = new System.Drawing.Point(365, 237);
            this.numericUpDownNivelPoder.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDownNivelPoder.Name = "numericUpDownNivelPoder";
            this.numericUpDownNivelPoder.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNivelPoder.TabIndex = 11;
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(747, 66);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(78, 22);
            this.buttoninsertar.TabIndex = 12;
            this.buttoninsertar.Text = "Crear";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // dateTimePickerFecha_Creacion
            // 
            this.dateTimePickerFecha_Creacion.Location = new System.Drawing.Point(515, 235);
            this.dateTimePickerFecha_Creacion.Name = "dateTimePickerFecha_Creacion";
            this.dateTimePickerFecha_Creacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha_Creacion.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha_Creacion";
            // 
            // richTextBoxHistoria
            // 
            this.richTextBoxHistoria.Location = new System.Drawing.Point(254, 278);
            this.richTextBoxHistoria.Name = "richTextBoxHistoria";
            this.richTextBoxHistoria.Size = new System.Drawing.Size(302, 84);
            this.richTextBoxHistoria.TabIndex = 15;
            this.richTextBoxHistoria.Text = "";
            this.richTextBoxHistoria.TextChanged += new System.EventHandler(this.richTextBoxHistoria_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Historia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxHistoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerFecha_Creacion);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.numericUpDownNivelPoder);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.buttonPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.NumericUpDown numericUpDownNivelPoder;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha_Creacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxHistoria;
        private System.Windows.Forms.Label label6;
    }
}

