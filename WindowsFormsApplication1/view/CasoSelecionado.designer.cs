namespace TelasIA
{
    partial class CasoSelecionado
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listCasoInserido = new System.Windows.Forms.ListView();
            this.Atributo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GridViewCasoscomSimilaridade = new System.Windows.Forms.DataGridView();
            this.Caso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.similaridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_avançar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCasoscomSimilaridade)).BeginInit();
            this.SuspendLayout();
            // 
            // listCasoInserido
            // 
            this.listCasoInserido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCasoInserido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Atributo,
            this.Valor});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.listCasoInserido.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listCasoInserido.Location = new System.Drawing.Point(13, 13);
            this.listCasoInserido.Name = "listCasoInserido";
            this.listCasoInserido.Size = new System.Drawing.Size(676, 232);
            this.listCasoInserido.TabIndex = 0;
            this.listCasoInserido.UseCompatibleStateImageBehavior = false;
            // 
            // GridViewCasoscomSimilaridade
            // 
            this.GridViewCasoscomSimilaridade.AllowUserToAddRows = false;
            this.GridViewCasoscomSimilaridade.AllowUserToDeleteRows = false;
            this.GridViewCasoscomSimilaridade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCasoscomSimilaridade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caso,
            this.doenca,
            this.similaridade,
            this.Selecionar});
            this.GridViewCasoscomSimilaridade.Location = new System.Drawing.Point(127, 251);
            this.GridViewCasoscomSimilaridade.Name = "GridViewCasoscomSimilaridade";
            this.GridViewCasoscomSimilaridade.ReadOnly = true;
            this.GridViewCasoscomSimilaridade.Size = new System.Drawing.Size(445, 150);
            this.GridViewCasoscomSimilaridade.TabIndex = 2;
            // 
            // Caso
            // 
            this.Caso.HeaderText = "Caso";
            this.Caso.Name = "Caso";
            this.Caso.ReadOnly = true;
            // 
            // doenca
            // 
            this.doenca.HeaderText = "Doenca";
            this.doenca.Name = "doenca";
            this.doenca.ReadOnly = true;
            // 
            // similaridade
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.similaridade.DefaultCellStyle = dataGridViewCellStyle1;
            this.similaridade.HeaderText = "Similaridade";
            this.similaridade.Name = "similaridade";
            this.similaridade.ReadOnly = true;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(12, 419);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(223, 78);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(241, 419);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(240, 78);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_avançar
            // 
            this.btn_avançar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avançar.Location = new System.Drawing.Point(487, 419);
            this.btn_avançar.Name = "btn_avançar";
            this.btn_avançar.Size = new System.Drawing.Size(202, 78);
            this.btn_avançar.TabIndex = 6;
            this.btn_avançar.Text = "Avançar";
            this.btn_avançar.UseVisualStyleBackColor = true;
            this.btn_avançar.Click += new System.EventHandler(this.btn_avançar_Click);
            // 
            // CasoSelecionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(694, 509);
            this.Controls.Add(this.btn_avançar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.GridViewCasoscomSimilaridade);
            this.Controls.Add(this.listCasoInserido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CasoSelecionado";
            this.Text = "CasoSelecionado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCasoscomSimilaridade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listCasoInserido;
        private System.Windows.Forms.DataGridView GridViewCasoscomSimilaridade;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_avançar;
        private System.Windows.Forms.ColumnHeader Atributo;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caso;
        private System.Windows.Forms.DataGridViewTextBoxColumn doenca;
        private System.Windows.Forms.DataGridViewTextBoxColumn similaridade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
    }
}

