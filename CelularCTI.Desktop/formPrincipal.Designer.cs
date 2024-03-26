namespace CelularCTI.Desktop
{
    partial class formPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.textMin = new System.Windows.Forms.Label();
            this.numPrecoMaximo = new System.Windows.Forms.NumericUpDown();
            this.numPrecoMinimo = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisarPreco = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPesquisarModelo = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCelulares = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMinimo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFabricante);
            this.groupBox1.Controls.Add(this.lblMax);
            this.groupBox1.Controls.Add(this.textMin);
            this.groupBox1.Controls.Add(this.numPrecoMaximo);
            this.groupBox1.Controls.Add(this.numPrecoMinimo);
            this.groupBox1.Controls.Add(this.btnPesquisarPreco);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnPesquisarModelo);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(101, 71);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(251, 21);
            this.cmbFabricante.TabIndex = 13;
            this.cmbFabricante.SelectedIndexChanged += new System.EventHandler(this.cmbFabricante_SelectedIndexChanged);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(234, 114);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 12;
            this.lblMax.Text = "Max";
            // 
            // textMin
            // 
            this.textMin.AutoSize = true;
            this.textMin.Location = new System.Drawing.Point(98, 114);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(24, 13);
            this.textMin.TabIndex = 11;
            this.textMin.Text = "Min";
            // 
            // numPrecoMaximo
            // 
            this.numPrecoMaximo.DecimalPlaces = 2;
            this.numPrecoMaximo.Location = new System.Drawing.Point(264, 112);
            this.numPrecoMaximo.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numPrecoMaximo.Name = "numPrecoMaximo";
            this.numPrecoMaximo.Size = new System.Drawing.Size(88, 20);
            this.numPrecoMaximo.TabIndex = 10;
            this.numPrecoMaximo.ThousandsSeparator = true;
            // 
            // numPrecoMinimo
            // 
            this.numPrecoMinimo.DecimalPlaces = 2;
            this.numPrecoMinimo.Location = new System.Drawing.Point(128, 112);
            this.numPrecoMinimo.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numPrecoMinimo.Name = "numPrecoMinimo";
            this.numPrecoMinimo.Size = new System.Drawing.Size(88, 20);
            this.numPrecoMinimo.TabIndex = 9;
            this.numPrecoMinimo.ThousandsSeparator = true;
            this.numPrecoMinimo.ValueChanged += new System.EventHandler(this.numPrecoInicial_ValueChanged);
            // 
            // btnPesquisarPreco
            // 
            this.btnPesquisarPreco.Location = new System.Drawing.Point(377, 109);
            this.btnPesquisarPreco.Name = "btnPesquisarPreco";
            this.btnPesquisarPreco.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPreco.TabIndex = 8;
            this.btnPesquisarPreco.Text = ">>>>";
            this.btnPesquisarPreco.UseVisualStyleBackColor = true;
            this.btnPesquisarPreco.Click += new System.EventHandler(this.btnPesquisarPreco_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = ">>>>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarModelo
            // 
            this.btnPesquisarModelo.Location = new System.Drawing.Point(377, 27);
            this.btnPesquisarModelo.Name = "btnPesquisarModelo";
            this.btnPesquisarModelo.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarModelo.TabIndex = 6;
            this.btnPesquisarModelo.Text = ">>>>";
            this.btnPesquisarModelo.UseVisualStyleBackColor = true;
            this.btnPesquisarModelo.Click += new System.EventHandler(this.btnPesquisarModelo_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(101, 30);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(251, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCelulares);
            this.groupBox2.Location = new System.Drawing.Point(42, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Celulares";
            // 
            // lstCelulares
            // 
            this.lstCelulares.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCelulares.FormattingEnabled = true;
            this.lstCelulares.Location = new System.Drawing.Point(16, 29);
            this.lstCelulares.Name = "lstCelulares";
            this.lstCelulares.Size = new System.Drawing.Size(432, 173);
            this.lstCelulares.TabIndex = 0;
            this.lstCelulares.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.btnComprar);
            this.groupBox3.Location = new System.Drawing.Point(42, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 42);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(35, 13);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "&Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(195, 13);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(347, 13);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formPrincipal";
            this.Text = "SITEZADA";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMinimo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarPreco;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPesquisarModelo;
        private System.Windows.Forms.NumericUpDown numPrecoMinimo;
        private System.Windows.Forms.NumericUpDown numPrecoMaximo;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label textMin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstCelulares;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovo;
    }
}

