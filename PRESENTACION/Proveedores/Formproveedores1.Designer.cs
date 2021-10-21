
namespace PRESENTACION.clientes
{
    partial class Formproveedores1
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
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttelempresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelcontacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(159, 31);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(187, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(159, 109);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(187, 20);
            this.txtcontacto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contacto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txttelempresa
            // 
            this.txttelempresa.Location = new System.Drawing.Point(159, 57);
            this.txttelempresa.MaxLength = 8;
            this.txttelempresa.Name = "txttelempresa";
            this.txttelempresa.Size = new System.Drawing.Size(187, 20);
            this.txttelempresa.TabIndex = 7;
            this.txttelempresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelempresa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel de empresa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txttelcontacto
            // 
            this.txttelcontacto.Location = new System.Drawing.Point(159, 135);
            this.txttelcontacto.MaxLength = 8;
            this.txttelcontacto.Name = "txttelcontacto";
            this.txttelcontacto.Size = new System.Drawing.Size(187, 20);
            this.txttelcontacto.TabIndex = 9;
            this.txttelcontacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelcontacto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tel. de contacto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(159, 83);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(187, 20);
            this.txtcorreo.TabIndex = 11;
            this.txtcorreo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dirección";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(159, 161);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(187, 20);
            this.txtdireccion.TabIndex = 15;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = global::PRESENTACION.Properties.Resources.add5;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.Location = new System.Drawing.Point(181, 248);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(91, 38);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::PRESENTACION.Properties.Resources.danger;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(397, 248);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(89, 38);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttelempresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcontacto);
            this.groupBox1.Controls.Add(this.txttelcontacto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 200);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Proveedor";
            // 
            // Formproveedores1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label1);
            this.Name = "Formproveedores1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Proveedor";
            this.Load += new System.EventHandler(this.Formclientea_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttelempresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttelcontacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}