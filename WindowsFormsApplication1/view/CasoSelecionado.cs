using SojaApp.DAO;
using SojaApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Control;
using WindowsFormsApplication1.Model;
using WindowsFormsApplication1.view;

namespace TelasIA
{
    public partial class CasoSelecionado : Form
    {
        public CasoSelecionado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            CCalculaSimilaridade c = new CCalculaSimilaridade();

            CasoSingleton caso = CasoSingleton.getInstance();

            List<Caso> casos_calculados = c.calculaSimilaridadeLocal(caso);

            //PropertyInfo[] valAtb = caso.GetType().GetProperties();


            //listCasoInserido.Columns.Add("teste", caso.area_damaged);


            /*DaoCaso dao = new DaoCaso();

            List<Caso> casos = dao.getAll();

            for(int i = 0; i < casos.Count; i++)
            {

            }*/

            //Atributo.Text = valAtb[1].ToString();
            //Valor.Text = caso.area_damaged;
        }

        private void btn_avançar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFinal final = new TelaFinal();
            final.Show();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelecionaAtributos at = new SelecionaAtributos();
            at.Show();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
