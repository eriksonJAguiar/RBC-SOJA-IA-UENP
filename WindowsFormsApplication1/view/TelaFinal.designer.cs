namespace TelasIA
{
    partial class TelaFinal
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
            this.listNovoCaso = new System.Windows.Forms.ListView();
            this.listSelecionado = new System.Windows.Forms.ListView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doenca_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Atributo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Atributo2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listNovoCaso
            // 
            this.listNovoCaso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Atributo2,
            this.Valor2});
            this.listNovoCaso.Location = new System.Drawing.Point(12, 26);
            this.listNovoCaso.Name = "listNovoCaso";
            this.listNovoCaso.Size = new System.Drawing.Size(337, 318);
            this.listNovoCaso.TabIndex = 0;
            this.listNovoCaso.UseCompatibleStateImageBehavior = false;
            this.listNovoCaso.View = System.Windows.Forms.View.Details;
            // 
            // listSelecionado
            // 
            this.listSelecionado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Atributo,
            this.Valor});
            this.listSelecionado.Location = new System.Drawing.Point(370, 26);
            this.listSelecionado.Name = "listSelecionado";
            this.listSelecionado.Size = new System.Drawing.Size(321, 318);
            this.listSelecionado.TabIndex = 1;
            this.listSelecionado.UseCompatibleStateImageBehavior = false;
            this.listSelecionado.View = System.Windows.Forms.View.Details;
            this.listSelecionado.SelectedIndexChanged += new System.EventHandler(this.listSelecionado_SelectedIndexChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(333, 26);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 318);
            this.vScrollBar1.TabIndex = 2;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(674, 26);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(20, 318);
            this.vScrollBar2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caso Novo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caso Selecionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doença";
            // 
            // doenca_textbox
            // 
            this.doenca_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doenca_textbox.Location = new System.Drawing.Point(256, 370);
            this.doenca_textbox.Name = "doenca_textbox";
            this.doenca_textbox.Size = new System.Drawing.Size(205, 38);
            this.doenca_textbox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 79);
            this.button1.TabIndex = 8;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(256, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 79);
            this.button2.TabIndex = 9;
            this.button2.Text = "Nova Consulta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(518, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 79);
            this.button3.TabIndex = 10;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Atributo
            // 
            this.Atributo.Text = "Atributo";
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            // 
            // Atributo2
            // 
            this.Atributo2.Text = "Atributo";
            // 
            // Valor2
            // 
            this.Valor2.Text = "Valor";
            // 
            // TelaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 533);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doenca_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.listSelecionado);
            this.Controls.Add(this.listNovoCaso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaFinal";
            this.Text = "TelaFinal";
            this.Load += new System.EventHandler(this.TelaFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listNovoCaso;
        private System.Windows.Forms.ListView listSelecionado;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doenca_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader Atributo2;
        private System.Windows.Forms.ColumnHeader Valor2;
        private System.Windows.Forms.ColumnHeader Atributo;
        private System.Windows.Forms.ColumnHeader Valor;
    }
}