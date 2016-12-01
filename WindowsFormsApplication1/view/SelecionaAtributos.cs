using SojaApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasIA;
using WindowsFormsApplication1.Control;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.view
{
    public partial class SelecionaAtributos : Form
    {
        public SelecionaAtributos()
        {
            InitializeComponent();
           
        }

        private void SelecionaAtributos_Load(object sender, EventArgs e)
        {
            CGetAtrib casos = new CGetAtrib();

            Hashtable table = casos.getAtrib();


            List<String> date = (List<String>) table["date"];
            Date.Items.AddRange(date.ToArray());

            List<String> area = (List<String>)table["area-damaged"];
            Area_Damaged.Items.AddRange(area.ToArray());

            List<String> canker_lesion = (List<String>)table["canker-lesion"];
            Canker_Lesion.Items.AddRange(canker_lesion.ToArray());


            List<String> crop_hist = (List<String>)table["crop-hist"];
            Crop_Hist.Items.AddRange(canker_lesion.ToArray());

            List<String> external_decay = (List<String>)table["external-decay"];
            External_Decay.Items.AddRange(external_decay.ToArray());

            List<String> fruit_spots = (List<String>)table["fruit-spots"];
            Fruit_Sports.Items.AddRange(fruit_spots.ToArray());

            List<String> fruiting_bodies  = (List<String>)table["fruiting-bodies"];
            Fruit_Bodies.Items.AddRange(fruiting_bodies.ToArray());

            List<String> fruit_pods = (List<String>)table["fruit-pods"];
            Fruit_Pods.Items.AddRange(fruit_pods.ToArray());

            List<String> germination = (List<String>)table["germination"];
            Germination.Items.AddRange(germination.ToArray());

            List<String> hail = (List<String>)table["hail"];
            Hail.Items.AddRange(hail.ToArray());

            List<String> int_discolor = (List<String>)table["int-discolor"];
            Int_Discolor.Items.AddRange(int_discolor.ToArray());

            List<String> leaf_malf = (List<String>)table["leaf-malf"];
            Leaf_Malf.Items.AddRange(leaf_malf.ToArray());

            List<String> leaf_mild = (List<String>)table["leaf-mild"];
            Leaf_Mild.Items.AddRange(leaf_mild.ToArray());

            List<String> leaf_shread = (List<String>)table["leaf-shread"];
            Leaf_Shared.Items.AddRange(leaf_shread.ToArray());

            List<String> leafspots_halo = (List<String>)table["leafspots-halo"];
            Leafspots_Halo.Items.AddRange(leafspots_halo.ToArray());


            List<String> leafspot_size = (List<String>)table["leafspots-size"];
            Leafspot_Size.Items.AddRange(leafspot_size.ToArray());

            List<String> leafspots_marg = (List<String>)table["leafspots-marg"];
            Leafspot_Marg.Items.AddRange(leafspots_marg.ToArray());

            List<String> leaves = (List<String>)table["leaves"];
            Leaves.Items.AddRange(leaves.ToArray());

            List<String> lodging = (List<String>)table["lodging"];
            Lodging.Items.AddRange(lodging.ToArray());

            List<String> mold_growth = (List<String>)table["mold-growth"];
            Mold_Growth.Items.AddRange(mold_growth.ToArray());

            List<String> mycelium = (List<String>)table["mycelium"];
            Mycelium.Items.AddRange(mycelium.ToArray());

            List<String> plant_growth = (List<String>)table["plant-growth"];
            Plant_Growth.Items.AddRange(plant_growth.ToArray());

            List<String> plant_stand = (List<String>)table["plant-stand"];
            Plant_Stand.Items.AddRange(plant_stand.ToArray());

            List<String> precip = (List<String>)table["precip"];
            Precip.Items.AddRange(plant_stand.ToArray());

            List<String> roots = (List<String>)table["roots"];
            Roots.Items.AddRange(roots.ToArray());

            List<String> sclerotia = (List<String>)table["sclerotia"];
            Sclerotia.Items.AddRange(sclerotia.ToArray());


            List<String> seed = (List<String>)table["seed"];
            Seed.Items.AddRange(seed.ToArray());

            List<String> seed_discolor = (List<String>)table["seed-discolor"];
            Seed_Discolor.Items.AddRange(seed_discolor.ToArray());

            List<String> seed_size = (List<String>)table["seed-size"];
            Seed_Size.Items.AddRange(seed_discolor.ToArray());

            List<String> seed_tmt = (List<String>)table["seed-tmt"];
            Seed_Tmt.Items.AddRange(seed_tmt.ToArray());

            List<String> severity = (List<String>)table["severity"];
            Severity.Items.AddRange(severity.ToArray());

            List<String> shriveling = (List<String>)table["shriveling"];
            Shriveling.Items.AddRange(shriveling.ToArray());

            List<String> stem = (List<String>)table["stem"];
            Stem.Items.AddRange(shriveling.ToArray());

            List<String> stem_cankers = (List<String>)table["stem-cankers"];
            Stem_Cankers.Items.AddRange(stem_cankers.ToArray());

            List<String> temp = (List<String>)table["temp"];
            Temp.Items.AddRange(temp.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CasoSingleton casosSel = CasoSingleton.getInstance();

            casosSel.area_damaged = Area_Damaged.Text;
            casosSel.canker_lesion = Canker_Lesion.Text;
            casosSel.crop_hist = Crop_Hist.Text;
            casosSel.date = Date.Text;
            casosSel.external_decay = External_Decay.Text;
            casosSel.fruiting_bodies = Fruit_Bodies.Text;
            casosSel.fruit_pods = Fruit_Pods.Text;
            casosSel.fruit_spots = Fruit_Sports.Text;
            casosSel.germination = Germination.Text;
            casosSel.hail = Hail.Text;
            casosSel.int_discolor = Int_Discolor.Text;
            casosSel.leaf_shread = Leaf_Shared.Text;
            casosSel.leafspots_halo = Leafspots_Halo.Text;
            casosSel.leafspots_marg = Leafspot_Marg.Text;
            casosSel.leafspots_size = Leafspot_Size.Text;
            casosSel.leaf_malf = Leaf_Malf.Text;
            casosSel.leaf_mild = Leaf_Mild.Text;
            casosSel.leaves = Leaves.Text;
            casosSel.lodging = Lodging.Text;
            casosSel.mold_growth = Mold_Growth.Text;
            casosSel.mycelium = Mycelium.Text;
            casosSel.plant_stand = Plant_Stand.Text;
            casosSel.plant_growth = Plant_Growth.Text;
            casosSel.precip = Precip.Text;
            casosSel.roots = Roots.Text;
            casosSel.sclerotia = Sclerotia.Text;
            casosSel.seed = Seed.Text;
            casosSel.seed_discolor = Seed_Discolor.Text;
            casosSel.seed_size = Seed_Size.Text;
            casosSel.seed_tmt = Seed_Tmt.Text;
            casosSel.severity = Severity.Text;
            casosSel.shriveling = Shriveling.Text;
            casosSel.stem = Stem.Text;
            casosSel.stem_cankers = Stem_Cankers.Text;
            casosSel.temp = Temp.Text;

            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }
    }
}
