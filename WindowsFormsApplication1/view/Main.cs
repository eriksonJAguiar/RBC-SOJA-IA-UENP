using SojaApp.DAO;
using SojaApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormsApplication1.Control;
using WindowsFormsApplication1.Model;
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

            DaoCaso dao = new DaoCaso();

            List<Caso> casos = dao.getAll();

            CMaxMin maxMin = new CMaxMin();

            PropertyInfo[] nomeAtribs = casos[0].GetType().GetProperties();

            MaxMinimos mm = MaxMinimos.getInstance();


            for (int i = 3; i < nomeAtribs.Length-1; i++)
            {
                List<double> valores = new List<double>();

                valores = maxMin.maxMinCol(casos, nomeAtribs[i]);

                mm.table.Add(nomeAtribs[i].Name, valores);
            }

            

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
