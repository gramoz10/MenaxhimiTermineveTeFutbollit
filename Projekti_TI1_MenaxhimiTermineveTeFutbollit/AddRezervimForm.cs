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
    public partial class AddRezervimForm : Form
    {
        public AddRezervimForm()
        {
            InitializeComponent();
            ShowCmbs();
        }

        void ShowCmbs()
        {
            cmbUsers.DataSource = BussinessLayer.BussinessUser.GetAllUsers();
            cmbUsers.DisplayMember = "FullName";
            cmbUsers.ValueMember = "UserID";

            cmbFushat.DataSource = BussinessLayer.BussinessFusha.GetAllFushat();
            cmbFushat.DisplayMember = "FushaID";
            cmbFushat.ValueMember = "FushaID";

            cmbKlientat.DataSource = BussinessLayer.BussinessKlienti.GetAllKlientat();
            cmbKlientat.ValueMember = "KlientiID";
            cmbKlientat.DisplayMember = "FullName";
        }

        private void AddRezervimForm_Load(object sender, EventArgs e)
        {
            dtDataeRezervimit.Text = DateTime.Now.ToShortDateString();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                Rezervimi newRezervim = new Rezervimi();
                int fushaid = int.Parse(cmbFushat.SelectedValue.ToString());
                int klientiid = int.Parse(cmbKlientat.SelectedValue.ToString());
                DateTime dt = Convert.ToDateTime(dtDataeRezervimit.Value);
                DateTime dtF = Convert.ToDateTime(dtFillimiRezervimit.Value);
                DateTime dtM = Convert.ToDateTime(dtMbarimiRezervimit.Value);
                if (dtF.Date >= DateTime.Now && dtM.Date >= DateTime.Now)
                {
                    if (dtM.Hour > dtF.Hour)
                    {
                        newRezervim.User = Form1.useri;
                        Fusha fusha = new Fusha();
                        fusha.FushaID = fushaid;
                        newRezervim.Fusha = fusha;

                        newRezervim.Klienti = new Klienti();
                        newRezervim.Klienti.KlientiID = klientiid;
                        newRezervim.DataERezervimit = DateTime.Now;
                        newRezervim.FillimiRezervimit = dtF;
                        newRezervim.MbarimiRezervimit = dtM;

                        if (BussinessRezervimi.CheckReservation(newRezervim) == true)
                        {
                            MessageBox.Show("U shtua nje rezervim i ri");
                            BussinessRezervimi.InsertRezervim(newRezervim);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ekziston rezervim ne kete kohe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data e mbarimit duhet të jete më e madhe se data e fillimit");
                    }
                }
                else
                {
                    MessageBox.Show("Gabim në datë");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ne kete forme duhet te zgjedhni fushen dhe klientin per Rezervim" +
            "\nPoashtu duhet qe te zgjedhni kohen e rezervimt dhe kohezgjatjen e rezervimit" +
            "\nData e Rezervimit mirret koha dhe data tanishme" +
            "\nKujdes ne data duhet qe te caktoni oren duke klikuar ne kontrolle dhe te caktoni me tastiere oren",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
