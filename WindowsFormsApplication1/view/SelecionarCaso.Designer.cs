namespace WindowsFormsApplication1.view
{
    partial class SelecionarCaso
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
        
        private System.Windows.Forms.ListView listCasoInserido;
        private System.Windows.Forms.ColumnHeader Atributo;
        private System.Windows.Forms.ColumnHeader Valor;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listCasoInserido = new System.Windows.Forms.ListView();
            this.Atributo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // SelecionarCaso
            // 
            this.ClientSize = new System.Drawing.Size(758, 516);
            this.Name = "SelecionarCaso";
            this.Load += new System.EventHandler(this.SelecionarCaso_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}