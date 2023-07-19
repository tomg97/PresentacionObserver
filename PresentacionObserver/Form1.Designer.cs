namespace PresentacionObserver {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cbAddP = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnAddP = new System.Windows.Forms.Button();
            this.cbAddComp = new System.Windows.Forms.ComboBox();
            this.cbAddS = new System.Windows.Forms.ComboBox();
            this.btnAddS = new System.Windows.Forms.Button();
            this.btnRemP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAddP
            // 
            this.cbAddP.FormattingEnabled = true;
            this.cbAddP.Items.AddRange(new object[] {
            "Celular",
            "Libro",
            "Pelicula",
            "Video juego"});
            this.cbAddP.Location = new System.Drawing.Point(232, 13);
            this.cbAddP.Name = "cbAddP";
            this.cbAddP.Size = new System.Drawing.Size(149, 21);
            this.cbAddP.TabIndex = 0;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(8, 14);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(218, 20);
            this.txtProducto.TabIndex = 1;
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(387, 11);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(110, 23);
            this.btnAddP.TabIndex = 2;
            this.btnAddP.Text = "Agregar Producto";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAddComp
            // 
            this.cbAddComp.FormattingEnabled = true;
            this.cbAddComp.Items.AddRange(new object[] {
            "Comprador 1",
            "Comprador 2",
            "Comprador 3",
            "Comprador 4",
            "Comprador 5"});
            this.cbAddComp.Location = new System.Drawing.Point(8, 64);
            this.cbAddComp.Name = "cbAddComp";
            this.cbAddComp.Size = new System.Drawing.Size(218, 21);
            this.cbAddComp.TabIndex = 3;
            // 
            // cbAddS
            // 
            this.cbAddS.FormattingEnabled = true;
            this.cbAddS.Items.AddRange(new object[] {
            "Celular",
            "Libro",
            "Pelicula",
            "Video juego"});
            this.cbAddS.Location = new System.Drawing.Point(232, 64);
            this.cbAddS.Name = "cbAddS";
            this.cbAddS.Size = new System.Drawing.Size(149, 21);
            this.cbAddS.TabIndex = 4;
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(387, 53);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(110, 23);
            this.btnAddS.TabIndex = 5;
            this.btnAddS.Text = "Subscribir";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // btnRemP
            // 
            this.btnRemP.Location = new System.Drawing.Point(387, 82);
            this.btnRemP.Name = "btnRemP";
            this.btnRemP.Size = new System.Drawing.Size(110, 23);
            this.btnRemP.TabIndex = 8;
            this.btnRemP.Text = "Desubscribir";
            this.btnRemP.UseVisualStyleBackColor = true;
            this.btnRemP.Click += new System.EventHandler(this.btnRemP_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 416);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRemP);
            this.Controls.Add(this.btnAddS);
            this.Controls.Add(this.cbAddS);
            this.Controls.Add(this.cbAddComp);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.cbAddP);
            this.Name = "Form1";
            this.Text = "Presentación Observer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAddP;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.ComboBox cbAddComp;
        private System.Windows.Forms.ComboBox cbAddS;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.Button btnRemP;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

