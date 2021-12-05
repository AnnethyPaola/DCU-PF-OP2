
namespace PF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnguardardatos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtvacuna = new System.Windows.Forms.TextBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btncapturar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LBCANTIDAD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 47);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SlateBlue;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(709, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro vacunacion";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(532, 87);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(200, 35);
            this.txtnombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(532, 165);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(200, 35);
            this.txtapellido.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(389, 259);
            this.txtcorreo.Multiline = true;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(311, 35);
            this.txtcorreo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(353, 165);
            this.txttelefono.Multiline = true;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(153, 35);
            this.txttelefono.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Estado:";
            // 
            // btnguardardatos
            // 
            this.btnguardardatos.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnguardardatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnguardardatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardardatos.BorderRadius = 7;
            this.btnguardardatos.ButtonText = "Guardar datos";
            this.btnguardardatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardardatos.DisabledColor = System.Drawing.Color.Gray;
            this.btnguardardatos.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardardatos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguardardatos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnguardardatos.Iconimage")));
            this.btnguardardatos.Iconimage_right = null;
            this.btnguardardatos.Iconimage_right_Selected = null;
            this.btnguardardatos.Iconimage_Selected = null;
            this.btnguardardatos.IconMarginLeft = 0;
            this.btnguardardatos.IconMarginRight = 0;
            this.btnguardardatos.IconRightVisible = true;
            this.btnguardardatos.IconRightZoom = 0D;
            this.btnguardardatos.IconVisible = true;
            this.btnguardardatos.IconZoom = 90D;
            this.btnguardardatos.IsTab = false;
            this.btnguardardatos.Location = new System.Drawing.Point(407, 322);
            this.btnguardardatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnguardardatos.Name = "btnguardardatos";
            this.btnguardardatos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnguardardatos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnguardardatos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardardatos.selected = false;
            this.btnguardardatos.Size = new System.Drawing.Size(301, 66);
            this.btnguardardatos.TabIndex = 17;
            this.btnguardardatos.Text = "Guardar datos";
            this.btnguardardatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnguardardatos.Textcolor = System.Drawing.Color.White;
            this.btnguardardatos.TextFont = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardardatos.Click += new System.EventHandler(this.btnguardardatos_Click);
            // 
            // txtvacuna
            // 
            this.txtvacuna.Location = new System.Drawing.Point(353, 87);
            this.txtvacuna.Multiline = true;
            this.txtvacuna.Name = "txtvacuna";
            this.txtvacuna.Size = new System.Drawing.Size(153, 35);
            this.txtvacuna.TabIndex = 18;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(27, 87);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(280, 245);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "Tabla de personas registradas";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(434, 470);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(266, 38);
            this.bunifuFlatButton2.TabIndex = 19;
            this.bunifuFlatButton2.Text = "Tabla de personas registradas";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(27, 400);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(186, 131);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Persona a registrar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Captura";
            // 
            // btncapturar
            // 
            this.btncapturar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btncapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncapturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncapturar.BorderRadius = 7;
            this.btncapturar.ButtonText = "Capturar";
            this.btncapturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncapturar.DisabledColor = System.Drawing.Color.Gray;
            this.btncapturar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapturar.Iconcolor = System.Drawing.Color.Transparent;
            this.btncapturar.Iconimage = null;
            this.btncapturar.Iconimage_right = null;
            this.btncapturar.Iconimage_right_Selected = null;
            this.btncapturar.Iconimage_Selected = null;
            this.btncapturar.IconMarginLeft = 0;
            this.btncapturar.IconMarginRight = 0;
            this.btncapturar.IconRightVisible = true;
            this.btncapturar.IconRightZoom = 0D;
            this.btncapturar.IconVisible = true;
            this.btncapturar.IconZoom = 90D;
            this.btncapturar.IsTab = false;
            this.btncapturar.Location = new System.Drawing.Point(27, 339);
            this.btncapturar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncapturar.Name = "btncapturar";
            this.btncapturar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncapturar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncapturar.OnHoverTextColor = System.Drawing.Color.White;
            this.btncapturar.selected = false;
            this.btncapturar.Size = new System.Drawing.Size(280, 35);
            this.btncapturar.TabIndex = 22;
            this.btncapturar.Text = "Capturar";
            this.btncapturar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncapturar.Textcolor = System.Drawing.Color.White;
            this.btncapturar.TextFont = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapturar.Click += new System.EventHandler(this.btncapturar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.BorderRadius = 7;
            this.btncancelar.ButtonText = "Cancelar";
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btncancelar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btncancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncancelar.Iconimage")));
            this.btncancelar.Iconimage_right = null;
            this.btncancelar.Iconimage_right_Selected = null;
            this.btncancelar.Iconimage_Selected = null;
            this.btncancelar.IconMarginLeft = 0;
            this.btncancelar.IconMarginRight = 0;
            this.btncancelar.IconRightVisible = true;
            this.btncancelar.IconRightZoom = 0D;
            this.btncancelar.IconVisible = true;
            this.btncancelar.IconZoom = 90D;
            this.btncancelar.IsTab = false;
            this.btncancelar.Location = new System.Drawing.Point(407, 396);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btncancelar.selected = false;
            this.btncancelar.Size = new System.Drawing.Size(301, 66);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancelar.Textcolor = System.Drawing.Color.White;
            this.btncancelar.TextFont = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 548);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 228);
            this.dataGridView1.TabIndex = 24;
            // 
            // LBCANTIDAD
            // 
            this.LBCANTIDAD.AutoSize = true;
            this.LBCANTIDAD.Location = new System.Drawing.Point(220, 412);
            this.LBCANTIDAD.Name = "LBCANTIDAD";
            this.LBCANTIDAD.Size = new System.Drawing.Size(107, 13);
            this.LBCANTIDAD.TabIndex = 25;
            this.LBCANTIDAD.Text = "Personas dectetadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 788);
            this.Controls.Add(this.LBCANTIDAD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncapturar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.txtvacuna);
            this.Controls.Add(this.btnguardardatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardardatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtvacuna;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btncapturar;
        private Bunifu.Framework.UI.BunifuFlatButton btncancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBCANTIDAD;
    }
}

