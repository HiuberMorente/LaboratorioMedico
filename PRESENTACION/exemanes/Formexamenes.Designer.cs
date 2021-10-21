
namespace PRESENTACION.exemanes
{
    partial class Formexamenes
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
            this.dtsolicitud = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbpasciente = new System.Windows.Forms.ComboBox();
            this.cbprueba = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtrealizado = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtsolicitud
            // 
            this.dtsolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtsolicitud.Location = new System.Drawing.Point(147, 89);
            this.dtsolicitud.Name = "dtsolicitud";
            this.dtsolicitud.Size = new System.Drawing.Size(213, 20);
            this.dtsolicitud.TabIndex = 0;
            this.dtsolicitud.ValueChanged += new System.EventHandler(this.dtsolicitud_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 136);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasciente";
            // 
            // cbpasciente
            // 
            this.cbpasciente.FormattingEnabled = true;
            this.cbpasciente.Location = new System.Drawing.Point(147, 26);
            this.cbpasciente.Name = "cbpasciente";
            this.cbpasciente.Size = new System.Drawing.Size(213, 21);
            this.cbpasciente.TabIndex = 3;
            // 
            // cbprueba
            // 
            this.cbprueba.FormattingEnabled = true;
            this.cbprueba.Location = new System.Drawing.Point(147, 57);
            this.cbprueba.Name = "cbprueba";
            this.cbprueba.Size = new System.Drawing.Size(213, 21);
            this.cbprueba.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prueba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha De Solicitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de entrega";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtrealizado
            // 
            this.dtrealizado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtrealizado.Location = new System.Drawing.Point(147, 120);
            this.dtrealizado.Name = "dtrealizado";
            this.dtrealizado.Size = new System.Drawing.Size(213, 20);
            this.dtrealizado.TabIndex = 7;
            this.dtrealizado.ValueChanged += new System.EventHandler(this.dtrealizado_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(512, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observaciones";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.Image = global::PRESENTACION.Properties.Resources.send1;
            this.btngenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngenerar.Location = new System.Drawing.Point(493, 209);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(97, 33);
            this.btngenerar.TabIndex = 10;
            this.btngenerar.Text = "Generar ";
            this.btngenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(209, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Examen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbpasciente);
            this.groupBox1.Controls.Add(this.dtsolicitud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbprueba);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtrealizado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 165);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pruebas";
            // 
            // Formexamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(610, 268);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Name = "Formexamenes";
            this.Text = "Formexamenes";
            this.Load += new System.EventHandler(this.Formexamenes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtsolicitud;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbpasciente;
        private System.Windows.Forms.ComboBox cbprueba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtrealizado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}