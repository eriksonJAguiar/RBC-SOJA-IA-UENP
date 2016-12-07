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
            System.GC.Collect();

            CCalculaSimilaridade c = new CCalculaSimilaridade();

            CasoSingleton caso = CasoSingleton.getInstance();

            List<Caso> casos_calculados = c.calculaSimilaridadeLocal(caso);


            ListViewItem lvi = new ListViewItem("area_damaged");
            lvi.SubItems.Add(caso.area_damaged);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("canker_lesion");
            lvi.SubItems.Add(caso.canker_lesion);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("crop_hist");
            lvi.SubItems.Add(caso.crop_hist);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("date");
            lvi.SubItems.Add(caso.date);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("external_decay");
            lvi.SubItems.Add(caso.external_decay);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("fruiting_bodies");
            lvi.SubItems.Add(caso.fruiting_bodies);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("fruit_pods");
            lvi.SubItems.Add(caso.fruit_pods);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("fruit_spots");
            lvi.SubItems.Add(caso.fruit_spots);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("germination");
            lvi.SubItems.Add(caso.germination);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("hail");
            lvi.SubItems.Add(caso.hail);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("int_discolor");
            lvi.SubItems.Add(caso.int_discolor);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("leafspots_halo");
            lvi.SubItems.Add(caso.leafspots_halo);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("leafspots_marg");
            lvi.SubItems.Add(caso.leafspots_marg);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("leafspot_size");
            lvi.SubItems.Add(caso.leafspot_size);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("leaf_malf");
            lvi.SubItems.Add(caso.leaf_malf);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("leaf_mild");
            lvi.SubItems.Add(caso.leaf_mild);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("leaf_shread");
            lvi.SubItems.Add(caso.leaf_shread);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("leaves");
            lvi.SubItems.Add(caso.leaves);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("lodging");
            lvi.SubItems.Add(caso.lodging);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("mold_growth");
            lvi.SubItems.Add(caso.mold_growth);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("mycelium");
            lvi.SubItems.Add(caso.mycelium);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("plant_growth");
            lvi.SubItems.Add(caso.plant_growth);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("plant_stand");
            lvi.SubItems.Add(caso.plant_stand);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("precip");
            lvi.SubItems.Add(caso.precip);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("roots");
            lvi.SubItems.Add(caso.roots);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("sclerotia");
            lvi.SubItems.Add(caso.sclerotia);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("seed");
            lvi.SubItems.Add(caso.seed);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("seed_discolor");
            lvi.SubItems.Add(caso.seed_discolor);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("seed_size");
            lvi.SubItems.Add(caso.seed_size);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("seed_tmt");
            lvi.SubItems.Add(caso.seed_tmt);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("severity");
            lvi.SubItems.Add(caso.severity);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("shriveling");
            lvi.SubItems.Add(caso.shriveling);
            listCasoInserido.Items.Add(lvi);


            lvi = new ListViewItem("stem");
            lvi.SubItems.Add(caso.stem);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("stem_cankers");
            lvi.SubItems.Add(caso.stem_cankers);
            listCasoInserido.Items.Add(lvi);

            lvi = new ListViewItem("temp");
            lvi.SubItems.Add(caso.temp);
            listCasoInserido.Items.Add(lvi);


            //PropertyInfo[] valAtb = caso.GetType().GetProperties();


            //listCasoInserido.Columns.Add("teste", caso.area_damaged);


            /*DaoCaso dao = new DaoCaso();

            List<Caso> casos = dao.getAll();

            for(int i = 0; i < casos.Count; i++)
            {

            }*/

            //Atributo.Text = valAtb[1].ToString();
            //Valor.Text = caso.area_damaged;


            List<Caso> casos = c.selecionaMelhores(casos_calculados);

            for(int i=0;i<casos.Count;i++)
            {
                GridViewCasoscomSimilaridade.Rows.Add(casos[i].caso, casos[i].doenca,casos[i].SimilaridadeGlobal); 
            }
        }

        private void btn_avançar_Click(object sender, EventArgs e)
        {
            DaoCaso dao = new DaoCaso();

            Caso novoCaso = new Caso();

            novoCaso.caso = Convert.ToInt32(GridViewCasoscomSimilaridade.SelectedCells[0].Value.ToString());

            novoCaso = dao.search(novoCaso);

            CasoNovo casoSel = CasoNovo.getInstance();

            casoSel._id = novoCaso._id;
            casoSel.area_damaged = novoCaso.area_damaged;
            casoSel.canker_lesion = novoCaso.canker_lesion;
            casoSel.caso = novoCaso.caso;
            casoSel.crop_hist = novoCaso.crop_hist;
            casoSel.date = novoCaso.date;
            casoSel.doenca = novoCaso.doenca;
            casoSel.external_decay = novoCaso.external_decay;
            casoSel.fruiting_bodies = novoCaso.fruiting_bodies;
            casoSel.fruit_pods = novoCaso.fruit_pods;
            casoSel.fruit_spots = novoCaso.fruit_spots;
            casoSel.germination = novoCaso.germination;
            casoSel.hail = novoCaso.hail;
            casoSel.int_discolor = novoCaso.int_discolor;
            casoSel.leafspots_halo = novoCaso.leafspots_halo;
            casoSel.leafspots_marg = novoCaso.leafspots_marg;
            casoSel.leafspot_size = novoCaso.leafspot_size;
            casoSel.leaf_malf = novoCaso.leaf_malf;
            casoSel.leaf_mild = novoCaso.leaf_mild;
            casoSel.leaf_shread = novoCaso.leaf_shread;
            casoSel.leaves = novoCaso.leaves;
            casoSel.lodging = novoCaso.lodging;
            casoSel.mold_growth = novoCaso.mold_growth;
            casoSel.mycelium = novoCaso.mycelium;
            casoSel.plant_growth = novoCaso.plant_growth;
            casoSel.plant_stand = novoCaso.plant_stand;
            casoSel.precip = novoCaso.precip;
            casoSel.roots = novoCaso.precip;
            casoSel.roots = novoCaso.roots;
            casoSel.sclerotia = novoCaso.sclerotia;
            casoSel.seed = novoCaso.seed;
            casoSel.seed_discolor = novoCaso.seed_discolor;
            casoSel.seed_size = novoCaso.seed_size;
            casoSel.seed_tmt = novoCaso.seed_tmt;
            casoSel.severity = novoCaso.severity;
            casoSel.shriveling = novoCaso.shriveling;
            casoSel.stem = novoCaso.stem;
            casoSel.stem_cankers = novoCaso.stem_cankers;
            casoSel.temp = casoSel.temp;

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
