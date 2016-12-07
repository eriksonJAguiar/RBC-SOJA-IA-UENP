using SojaApp.DAO;
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
using WindowsFormsApplication1.Control;
using WindowsFormsApplication1.Model;

namespace TelasIA
{
    public partial class TelaFinal : Form
    {
        public TelaFinal()
        {
            InitializeComponent();
        }

        private void TelaFinal_Load(object sender, EventArgs e)
        {
            CasoNovo casoN = CasoNovo.getInstance();
            CasoSingleton caso = CasoSingleton.getInstance();

            doenca_textbox.Text = caso.doenca;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CNovoCaso controller = new CNovoCaso();

            CasoNovo casoN = CasoNovo.getInstance();
            CasoSingleton caso = CasoSingleton.getInstance();

            controller.gravaNovoCaso(caso);

            casoN.limpa();
            caso.limpa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CNovoCaso controller = new CNovoCaso();

            controller.gravaNovoCaso(CasoSingleton.getInstance());

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CasoSelecionado form = new CasoSelecionado();
            CasoNovo caso = CasoNovo.getInstance();
            caso.limpa();

        }

       
    }
}
