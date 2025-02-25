namespace CalculadoraMelhoradaMelhora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperResult = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.btMais = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.btExp = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.oP2 = new System.Windows.Forms.NumericUpDown();
            this.oP1 = new System.Windows.Forms.NumericUpDown();
            this.btSegue = new System.Windows.Forms.Button();
            this.btLimpa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oP1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operador 2";
            // 
            // lblOperResult
            // 
            this.lblOperResult.BackColor = System.Drawing.Color.Transparent;
            this.lblOperResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperResult.Location = new System.Drawing.Point(77, 369);
            this.lblOperResult.Name = "lblOperResult";
            this.lblOperResult.Size = new System.Drawing.Size(635, 50);
            this.lblOperResult.TabIndex = 2;
            this.lblOperResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOper
            // 
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(718, 171);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(73, 47);
            this.lblOper.TabIndex = 3;
            this.lblOper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMais
            // 
            this.btMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMais.Location = new System.Drawing.Point(77, 171);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(122, 47);
            this.btMais.TabIndex = 5;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // btMenos
            // 
            this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.Location = new System.Drawing.Point(205, 171);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(123, 47);
            this.btMenos.TabIndex = 6;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(334, 171);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(122, 47);
            this.btDiv.TabIndex = 7;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btMulti
            // 
            this.btMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMulti.Location = new System.Drawing.Point(462, 171);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(122, 47);
            this.btMulti.TabIndex = 8;
            this.btMulti.Text = "x";
            this.btMulti.UseVisualStyleBackColor = true;
            this.btMulti.Click += new System.EventHandler(this.btMulti_Click);
            // 
            // btExp
            // 
            this.btExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExp.Location = new System.Drawing.Point(590, 171);
            this.btExp.Name = "btExp";
            this.btExp.Size = new System.Drawing.Size(122, 47);
            this.btExp.TabIndex = 9;
            this.btExp.Text = "^";
            this.btExp.UseVisualStyleBackColor = true;
            this.btExp.Click += new System.EventHandler(this.btExp_Click);
            // 
            // btResult
            // 
            this.btResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResult.Location = new System.Drawing.Point(334, 241);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(122, 47);
            this.btResult.TabIndex = 13;
            this.btResult.Text = "Operar";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // oP2
            // 
            this.oP2.Location = new System.Drawing.Point(334, 318);
            this.oP2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.oP2.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.oP2.Name = "oP2";
            this.oP2.Size = new System.Drawing.Size(120, 20);
            this.oP2.TabIndex = 14;
            this.oP2.ValueChanged += new System.EventHandler(this.oP2_ValueChanged);
            // 
            // oP1
            // 
            this.oP1.Location = new System.Drawing.Point(336, 95);
            this.oP1.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.oP1.Minimum = new decimal(new int[] {
            -727379968,
            232,
            0,
            -2147483648});
            this.oP1.Name = "oP1";
            this.oP1.Size = new System.Drawing.Size(120, 20);
            this.oP1.TabIndex = 15;
            this.oP1.ValueChanged += new System.EventHandler(this.oP1_ValueChanged);
            // 
            // btSegue
            // 
            this.btSegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSegue.Location = new System.Drawing.Point(479, 95);
            this.btSegue.Name = "btSegue";
            this.btSegue.Size = new System.Drawing.Size(81, 35);
            this.btSegue.TabIndex = 16;
            this.btSegue.Text = "Seguirr";
            this.btSegue.UseVisualStyleBackColor = true;
            this.btSegue.Click += new System.EventHandler(this.btSegue_Click);
            // 
            // btLimpa
            // 
            this.btLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpa.Location = new System.Drawing.Point(566, 95);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(83, 35);
            this.btLimpa.TabIndex = 17;
            this.btLimpa.Text = "Limpar";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.btLimpa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.btSegue);
            this.Controls.Add(this.oP1);
            this.Controls.Add(this.oP2);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.btExp);
            this.Controls.Add(this.btMulti);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.lblOperResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperResult;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button btExp;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.NumericUpDown oP2;
        private System.Windows.Forms.NumericUpDown oP1;
        private System.Windows.Forms.Button btSegue;
        private System.Windows.Forms.Button btLimpa;
    }
}

