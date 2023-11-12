namespace Presentacion
{
    partial class producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(producto));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textnombrepro = new System.Windows.Forms.TextBox();
            this.textprovedor = new System.Windows.Forms.TextBox();
            this.btnguardarpro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(385, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(436, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ProductoID";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(584, 37);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(133, 23);
            this.txtproducto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(427, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "NombreProducto ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(436, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ProveedorID ";
            // 
            // textnombrepro
            // 
            this.textnombrepro.Location = new System.Drawing.Point(584, 92);
            this.textnombrepro.Name = "textnombrepro";
            this.textnombrepro.Size = new System.Drawing.Size(133, 23);
            this.textnombrepro.TabIndex = 9;
            // 
            // textprovedor
            // 
            this.textprovedor.Location = new System.Drawing.Point(585, 148);
            this.textprovedor.Name = "textprovedor";
            this.textprovedor.Size = new System.Drawing.Size(133, 23);
            this.textprovedor.TabIndex = 10;
            // 
            // btnguardarpro
            // 
            this.btnguardarpro.Location = new System.Drawing.Point(585, 212);
            this.btnguardarpro.Name = "btnguardarpro";
            this.btnguardarpro.Size = new System.Drawing.Size(132, 23);
            this.btnguardarpro.TabIndex = 11;
            this.btnguardarpro.Text = "Guardar";
            this.btnguardarpro.UseVisualStyleBackColor = true;
            this.btnguardarpro.Click += new System.EventHandler(this.btnguardarpro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 457);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguardarpro);
            this.Controls.Add(this.textprovedor);
            this.Controls.Add(this.textnombrepro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "producto";
            this.Text = "EmpleadoSeccion";
            this.Load += new System.EventHandler(this.producto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtproducto;
        private Label label2;
        private Label label3;
        private TextBox textnombrepro;
        private TextBox textprovedor;
        private Button btnguardarpro;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}