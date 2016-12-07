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
using WindowsFormsApplication1;
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

            ListViewItem lvi = new ListViewItem("area_damaged");
            lvi.SubItems.Add(caso.area_damaged);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("canker_lesion");
            lvi.SubItems.Add(caso.canker_lesion);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("crop_hist");
            lvi.SubItems.Add(caso.crop_hist);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("date");
            lvi.SubItems.Add(caso.date);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("external_decay");
            lvi.SubItems.Add(caso.external_decay);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("fruiting_bodies");
            lvi.SubItems.Add(caso.fruiting_bodies);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("fruit_pods");
            lvi.SubItems.Add(caso.fruit_pods);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("fruit_spots");
            lvi.SubItems.Add(caso.fruit_spots);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("germination");
            lvi.SubItems.Add(caso.germination);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("hail");
            lvi.SubItems.Add(caso.hail);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("int_discolor");
            lvi.SubItems.Add(caso.int_discolor);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("leafspots_halo");
            lvi.SubItems.Add(caso.leafspots_halo);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("leafspots_marg");
            lvi.SubItems.Add(caso.leafspots_marg);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("leafspot_size");
            lvi.SubItems.Add(caso.leafspot_size);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("leaf_malf");
            lvi.SubItems.Add(caso.leaf_malf);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("leaf_mild");
            lvi.SubItems.Add(caso.leaf_mild);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("leaf_shread");
            lvi.SubItems.Add(caso.leaf_shread);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("leaves");
            lvi.SubItems.Add(caso.leaves);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("lodging");
            lvi.SubItems.Add(caso.lodging);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("mold_growth");
            lvi.SubItems.Add(caso.mold_growth);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("mycelium");
            lvi.SubItems.Add(caso.mycelium);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("plant_growth");
            lvi.SubItems.Add(caso.plant_growth);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("plant_stand");
            lvi.SubItems.Add(caso.plant_stand);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("precip");
            lvi.SubItems.Add(caso.precip);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("roots");
            lvi.SubItems.Add(caso.roots);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("sclerotia");
            lvi.SubItems.Add(caso.sclerotia);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("seed");
            lvi.SubItems.Add(caso.seed);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("seed_discolor");
            lvi.SubItems.Add(caso.seed_discolor);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("seed_size");
            lvi.SubItems.Add(caso.seed_size);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("seed_tmt");
            lvi.SubItems.Add(caso.seed_tmt);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("severity");
            lvi.SubItems.Add(caso.severity);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("shriveling");
            lvi.SubItems.Add(caso.shriveling);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("stem");
            lvi.SubItems.Add(caso.stem);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("stem_cankers");
            lvi.SubItems.Add(caso.stem_cankers);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("temp");
            lvi.SubItems.Add(caso.temp);
            listNovoCaso.Items.Add(lvi);

            //segunda lista

            lvi = new ListViewItem("area_damaged");
            lvi.SubItems.Add(casoN.area_damaged);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("canker_lesion");
            lvi.SubItems.Add(casoN.canker_lesion);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("crop_hist");
            lvi.SubItems.Add(casoN.crop_hist);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("date");
            lvi.SubItems.Add(casoN.date);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("external_decay");
            lvi.SubItems.Add(casoN.external_decay);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("fruiting_bodies");
            lvi.SubItems.Add(casoN.fruiting_bodies);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("fruit_pods");
            lvi.SubItems.Add(casoN.fruit_pods);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("fruit_spots");
            lvi.SubItems.Add(casoN.fruit_spots);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("germination");
            lvi.SubItems.Add(casoN.germination);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("hail");
            lvi.SubItems.Add(caso.hail);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("int_discolor");
            lvi.SubItems.Add(casoN.int_discolor);
            listSelecionado.Items.Add(lvi);


            lvi = new ListViewItem("leafspots_halo");
            lvi.SubItems.Add(casoN.leafspots_halo);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("leafspots_marg");
            lvi.SubItems.Add(caso.leafspots_marg);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("leafspot_size");
            lvi.SubItems.Add(caso.leafspot_size);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("leaf_malf");
            lvi.SubItems.Add(caso.leaf_malf);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("leaf_mild");
            lvi.SubItems.Add(casoN.leaf_mild);
            listSelecionado.Items.Add(lvi);


            lvi = new ListViewItem("leaf_shread");
            lvi.SubItems.Add(casoN.leaf_shread);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("leaves");
            lvi.SubItems.Add(casoN.leaves);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("lodging");
            lvi.SubItems.Add(casoN.lodging);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("mold_growth");
            lvi.SubItems.Add(caso.mold_growth);
            listNovoCaso.Items.Add(lvi);

            lvi = new ListViewItem("mycelium");
            lvi.SubItems.Add(caso.mycelium);
            listNovoCaso.Items.Add(lvi);


            lvi = new ListViewItem("plant_growth");
            lvi.SubItems.Add(casoN.plant_growth);
            listSelecionado.Items.Add(lvi);


            lvi = new ListViewItem("plant_stand");
            lvi.SubItems.Add(casoN.plant_stand);
            listSelecionado.Items.Add(lvi);


            lvi = new ListViewItem("precip");
            lvi.SubItems.Add(casoN.precip);
            listSelecionado.Items.Add(lvi);


            lvi = new ListViewItem("roots");
            lvi.SubItems.Add(casoN.roots);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("sclerotia");
            lvi.SubItems.Add(casoN.sclerotia);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("seed");
            lvi.SubItems.Add(casoN.seed);
            listSelecionado.Items.Add(lvi);


            lvi = new ListViewItem("seed_discolor");
            lvi.SubItems.Add(casoN.seed_discolor);
            listSelecionado.Items.Add(lvi);


            lvi = new ListViewItem("seed_size");
            lvi.SubItems.Add(casoN.seed_size);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("seed_tmt");
            lvi.SubItems.Add(casoN.seed_tmt);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("severity");
            lvi.SubItems.Add(casoN.severity);
            listSelecionado.Items.Add(lvi);


            lvi = new ListViewItem("shriveling");
            lvi.SubItems.Add(casoN.shriveling);
            listSelecionado.Items.Add(lvi);


            lvi = new ListViewItem("stem");
            lvi.SubItems.Add(casoN.stem);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("stem_cankers");
            lvi.SubItems.Add(casoN.stem_cankers);
            listSelecionado.Items.Add(lvi);

            lvi = new ListViewItem("temp");
            lvi.SubItems.Add(casoN.temp);
            listSelecionado.Items.Add(lvi);

            doenca_textbox.Text = casoN.doenca;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CNovoCaso controller = new CNovoCaso();

            CasoNovo casoN = CasoNovo.getInstance();
            CasoSingleton caso = CasoSingleton.getInstance();
            caso.doenca = doenca_textbox.Text;

            controller.gravaNovoCaso(caso);

            casoN.limpa();
            caso.limpa();

            this.Hide();
            Main main = new Main();
            main.Show();

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

        private void listSelecionado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
