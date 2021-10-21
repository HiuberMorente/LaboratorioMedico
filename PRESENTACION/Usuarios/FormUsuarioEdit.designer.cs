
namespace PRESENTACION.usuarios
{
    partial class FormUsuarioEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdpi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(175, 76);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(115, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(496, 78);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(115, 20);
            this.txtapellido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(175, 138);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(115, 20);
            this.txtedad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtdpi
            // 
            this.txtdpi.Location = new System.Drawing.Point(496, 138);
            this.txtdpi.Name = "txtdpi";
            this.txtdpi.Size = new System.Drawing.Size(115, 20);
            this.txtdpi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "DPI";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(175, 208);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(115, 20);
            this.txtnit.TabIndex = 11;
            this.txtnit.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "NIT";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(496, 210);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(115, 20);
            this.txttelefono.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Teléfono";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(175, 273);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(115, 20);
            this.txtdireccion.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dirección";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(496, 275);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(115, 20);
            this.txtcorreo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Correo";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(190, 345);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(345, 345);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(12, 9);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(115, 20);
            this.txtid.TabIndex = 20;
            this.txtid.Visible = false;
            // 
            // Formclienteedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 395);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdpi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formclienteedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formclientea";
            this.Load += new System.EventHandler(this.Formclientea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdpi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtid;
    }
}