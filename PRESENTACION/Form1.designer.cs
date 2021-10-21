
namespace PRESENTACION
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnacceder = new System.Windows.Forms.Button();
            this.lbmerror = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 312);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtusuario.Location = new System.Drawing.Point(318, 90);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(250, 13);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.Text = "USUARIO";
            this.txtusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtusuario.Enter += new System.EventHandler(this.btnusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(318, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "_________________________________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(318, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "_________________________________________________________";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtcontraseña.Location = new System.Drawing.Point(318, 163);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(250, 13);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.Text = "CONTRASEÑA";
            this.txtcontraseña.Enter += new System.EventHandler(this.txtcontraseña_Enter);
            this.txtcontraseña.Leave += new System.EventHandler(this.txtcontraseña_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(346, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "INICIO DE SESIÓN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnacceder
            // 
            this.btnacceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnacceder.FlatAppearance.BorderSize = 0;
            this.btnacceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnacceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceder.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnacceder.Location = new System.Drawing.Point(318, 233);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(250, 35);
            this.btnacceder.TabIndex = 3;
            this.btnacceder.Text = "ACCEDER";
            this.btnacceder.UseVisualStyleBackColor = false;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // lbmerror
            // 
            this.lbmerror.AutoSize = true;
            this.lbmerror.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbmerror.ForeColor = System.Drawing.Color.DarkRed;
            this.lbmerror.Location = new System.Drawing.Point(318, 202);
            this.lbmerror.Name = "lbmerror";
            this.lbmerror.Size = new System.Drawing.Size(130, 21);
            this.lbmerror.TabIndex = 10;
            this.lbmerror.Text = "Mensaje De Error";
            this.lbmerror.UseMnemonic = false;
            this.lbmerror.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PRESENTACION.Properties.Resources.USERturque;
            this.pictureBox3.Location = new System.Drawing.Point(37, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRESENTACION.Properties.Resources.boton_x_blanco1;
            this.pictureBox1.Location = new System.Drawing.Point(643, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(669, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbmerror);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbmerror;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

