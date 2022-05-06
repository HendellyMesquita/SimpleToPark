
namespace SimpleToPark
{
    partial class SimpleToPark
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LbValor = new System.Windows.Forms.TableLayoutPanel();
            this.LbTotal = new System.Windows.Forms.Label();
            this.DgvEstaacionado = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnConfg = new System.Windows.Forms.Button();
            this.lbHora = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.LbValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstaacionado)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.69892F));
            this.tableLayoutPanel1.Controls.Add(this.LbValor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LbValor
            // 
            this.LbValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbValor.ColumnCount = 1;
            this.LbValor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LbValor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LbValor.Controls.Add(this.DgvEstaacionado, 0, 0);
            this.LbValor.Controls.Add(this.LbTotal, 0, 1);
            this.LbValor.Location = new System.Drawing.Point(125, 3);
            this.LbValor.Name = "LbValor";
            this.LbValor.RowCount = 2;
            this.LbValor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.12639F));
            this.LbValor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.873614F));
            this.LbValor.Size = new System.Drawing.Size(728, 451);
            this.LbValor.TabIndex = 0;
            // 
            // LbTotal
            // 
            this.LbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTotal.AutoSize = true;
            this.LbTotal.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.Location = new System.Drawing.Point(559, 426);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(173, 25);
            this.LbTotal.TabIndex = 0;
            this.LbTotal.Text = "Valor Total R$ 0,00";
            // 
            // DgvEstaacionado
            // 
            this.DgvEstaacionado.AllowUserToAddRows = false;
            this.DgvEstaacionado.AllowUserToDeleteRows = false;
            this.DgvEstaacionado.AllowUserToOrderColumns = true;
            this.DgvEstaacionado.AllowUserToResizeColumns = false;
            this.DgvEstaacionado.AllowUserToResizeRows = false;
            this.DgvEstaacionado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvEstaacionado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEstaacionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstaacionado.Location = new System.Drawing.Point(3, 3);
            this.DgvEstaacionado.Name = "DgvEstaacionado";
            this.DgvEstaacionado.ReadOnly = true;
            this.DgvEstaacionado.RowHeadersVisible = false;
            this.DgvEstaacionado.Size = new System.Drawing.Size(786, 414);
            this.DgvEstaacionado.TabIndex = 1;
            this.DgvEstaacionado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstaacionado_CellDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbHora, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCad, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnConfg, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.816381F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.3653F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.818313F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(116, 451);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnCad
            // 
            this.btnCad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCad.Location = new System.Drawing.Point(3, 3);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(110, 24);
            this.btnCad.TabIndex = 0;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnConfg
            // 
            this.btnConfg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfg.Location = new System.Drawing.Point(3, 422);
            this.btnConfg.Name = "btnConfg";
            this.btnConfg.Size = new System.Drawing.Size(110, 26);
            this.btnConfg.TabIndex = 1;
            this.btnConfg.Text = "Configurar";
            this.btnConfg.UseVisualStyleBackColor = true;
            this.btnConfg.Click += new System.EventHandler(this.btnConfg_Click);
            // 
            // lbHora
            // 
            this.lbHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(3, 369);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(110, 50);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "Valor Hora R$ 0,00";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SimpleToPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SimpleToPark";
            this.ShowIcon = false;
            this.Text = "Park";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.LbValor.ResumeLayout(false);
            this.LbValor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstaacionado)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel LbValor;
        private System.Windows.Forms.DataGridView DgvEstaacionado;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnConfg;
    }
}

