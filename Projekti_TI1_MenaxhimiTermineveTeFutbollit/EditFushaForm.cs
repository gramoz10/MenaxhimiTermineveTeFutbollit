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
    public partial class EditFushaForm : Form
    {
        int fushaid;
        Fusha fusha;

        public EditFushaForm(int id)
        {
            InitializeComponent();
            fushaid = id;
            lblfushaid.Text += fushaid.ToString();
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            try
            {
                if(bartificial_PO.IsChecked == true) { fusha.BariArtificial = true; }
                else if(bartificial_JO.IsChecked == true) { fusha.BariArtificial = false; }

                if (fmbuluar_PO.IsChecked == true) { fusha.FushaEMbuluar = true; }
                else if (fmbuluar_JO.IsChecked == true) { fusha.FushaEMbuluar = false; }

                fusha.Gjatesia = txtGjatesia.Text;
                fusha.Gjeresia = txtGjeresia.Text;
                fusha.CmimiFushes = double.Parse(txtcmimiifushes.Text);

                BussinessFusha.EditFusha(fusha.FushaID, fusha);
                MessageBox.Show("Fusha u editua me sukses");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Show()
        {
            try
            {
                fusha = BussinessFusha.GetFushaById(fushaid);

                if(fusha.FushaEMbuluar == true)
                    fmbuluar_PO.IsChecked = true;

                if(fusha.FushaEMbuluar == false)
                    fmbuluar_JO.IsChecked = true;

                if(fusha.BariArtificial == true)
                    bartificial_PO.IsChecked = true;

                if(fusha.BariArtificial == false)
                    bartificial_JO.IsChecked = true;

                txtGjatesia.Text = fusha.Gjatesia;
                txtGjeresia.Text = fusha.Gjeresia;
                txtcmimiifushes.Text = fusha.CmimiFushes.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditFushaForm_Load(object sender, EventArgs e)
        {
            Show();
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
