using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BussinessLayer;

namespace Projekti_TI1_MenaxhimiTermineveTeFutbollit
{
    public partial class AddFushaForm : Form
    {
        public AddFushaForm()
        {
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                string gjatesia = txtGjatesia.Text;
                string gjeresia = txtGjeresia.Text;
                double cmimi = double.Parse(txtcmimiifushes.Text);
                bool fushaEmbuluar = false;
                if (fmbuluar_PO.IsChecked) { fushaEmbuluar = true; }
                if (fmbuluar_JO.IsChecked) { fushaEmbuluar = false; }

                bool bariartificial = false;
                if (bartificial_PO.IsChecked) { bariartificial = true; }
                if (bartificial_JO.IsChecked) { bariartificial = false; }

                if (String.IsNullOrEmpty(gjatesia) || String.IsNullOrEmpty(gjeresia) || String.IsNullOrEmpty(txtcmimiifushes.Text))
                {
                    MessageBox.Show("Mbushini te gjitha hapsirat e kerkuara");
                }
                else
                {
                    Fusha newFusha = new Fusha()
                    {
                        BariArtificial = bariartificial,
                        FushaEMbuluar = fushaEmbuluar,
                        Gjatesia = gjatesia,
                        Gjeresia = gjeresia,
                        CmimiFushes = cmimi
                    };

                    BussinessFusha.InsertFusha(newFusha);
                    MessageBox.Show("U shtua nje fushe e re");
                    this.Close();
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Gabim ne tip te te dhenave");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ne kete forme duhet te zgjedhni per fushen e mbuluar dhe barin e fushes\n" +
            "Poashtu duhet te shtypni Gjatesine,Gjeresine dhe Cmimin per Fushe\nKujdes forma nuk duhet te kete hapsira te zbrasta",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
