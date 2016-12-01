using SojaaApp.Control;
using SojaApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.view;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            //this.Close();
            SelecionaAtributos st = new SelecionaAtributos();
            st.Show();
            this.Hide();
        }
        private void btnSair_Click(Object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
