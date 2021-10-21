
namespace PRESENTACION.pruebas
{
    partial class FormtipoEditar
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo De Prueba";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(221, 291);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(376, 291);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Descripción";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(181, 157);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(436, 113);
            this.txtdescripcion.TabIndex = 32;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(197, 81);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(115, 20);
            this.txtnombre.TabIndex = 26;
            this.txtnombre.TextChanged += new System.EventHandler(this.txttelempresa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nombre";
            // 
            // FormtipoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 395);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label1);
            this.Name = "FormtipoEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Tipo De Prueba";
            this.Load += new System.EventHandler(this.Formclientea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
    }
}