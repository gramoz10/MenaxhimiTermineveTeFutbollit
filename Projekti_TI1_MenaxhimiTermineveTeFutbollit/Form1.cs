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

namespace Projekti_TI1_MenaxhimiTermineveTeFutbollit
{
    public partial class Form1 : Form
    {
        public static User useri = new User();
        int userid;
        int rezervimiid;
        int fushaid;
        int klientiid;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowColumns();
            ShowRezervimet();
            ShowFushat();
            ShowKlientat();
            ShowUserat();
            try
            {
                if (useri.TipiUser.Pershkrimi != "Pronar")
                {
                    ribbonTab2.Enabled = false;
                }
                else
                {
                    ribbonTab2.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tabRezervimet_Click(object sender, EventArgs e)
        {
            GV_Rezervimet.ClearSelection();
            // GV_Rezervimet.DataSource = BussinessLayer.BussinessRezervimi.GetAllRezervimet();
            GV_Rezervimet.Visible = true;
            fushatgv.Visible = false;
            Usersgv.Visible = false;
            klientatgv.Visible = false;
        }

        private void tabUsers_Click(object sender, EventArgs e)
        {
            //Usersgv.DataSource = BussinessLayer.BussinessUser.GetAllUsers();
            Usersgv.Visible = true;
            fushatgv.Visible = false;
            GV_Rezervimet.Visible = false;
            klientatgv.Visible = false;
        }

        void ShowColumns()
        {
            string[] cols1 = new string[] { "RezervimiID", "User", "Klienti", "Fusha", "DataERezervimit", "FillimiRezervimit", "MbarimiRezervimit", "Pagesa" };

            for (int i = 0; i < cols1.Length; i++)
            {
                GV_Rezervimet.Columns.Add(cols1[i]);
            }

            string[] cols2 = new string[] { "FushaID", "Fusha e mbuluar", "Bari artificial", "Gjatesia", "Gjeresia", "Cmimi i fushes" };

            for (int i = 0; i < cols2.Length; i++)
            {
                fushatgv.Columns.Add(cols2[i]);
            }


            string[] cols3 = new string[] { "KlientiID", "Emri", "Mbiemri", "Nr. Kontaktues" };

            for (int i = 0; i < cols3.Length; i++)
            {
                klientatgv.Columns.Add(cols3[i]);
            }

            string[] cols4 = new string[] { "UserID", "Emri", "Mbiemri", "Email", "Tipi i Userit", "Nr. Kontaktues", "Data e lindjes", "Adresa" };

            for (int i = 0; i < cols4.Length; i++)
            {
                Usersgv.Columns.Add(cols4[i]);
            }
        }

        void ShowRezervimet()
        {
            var rezervimet = BussinessLayer.BussinessRezervimi.GetAllRezervimet();

            if (rezervimet != null)
            {
                for (int i = 0; i < rezervimet.Count; i++)
                {
                    if (rezervimet[i].IsActive == true)
                    {
                        GV_Rezervimet.Rows.Add(rezervimet[i].RezervimiID,
                                               rezervimet[i].User.Emri + " " + rezervimet[i].User.Mbiemri,
                                               rezervimet[i].Klienti.Emri + " " + rezervimet[i].Klienti.Mbiemri,
                                               rezervimet[i].Fusha.FushaID,
                                               rezervimet[i].DataERezervimit.ToString(),
                                               rezervimet[i].FillimiRezervimit.ToString(),
                                               rezervimet[i].MbarimiRezervimit.ToString(),
                                               rezervimet[i].Pagesa.ToString() + "€"
                                                );
                    }
                }
            }
        }

        void ShowFushat()
        {
            var fushat = BussinessLayer.BussinessFusha.GetAllFushat();

            if (fushat != null)
            {
                for (int i = 0; i < fushat.Count; i++)
                {
                    if (fushat[i].IsActive == true)
                    {
                        fushatgv.Rows.Add(fushat[i].FushaID,
                                               fushat[i].FushaEMbuluar == true ? "PO" : "JO",
                                               fushat[i].BariArtificial == true ? "PO" : "JO",
                                               fushat[i].Gjatesia,
                                               fushat[i].Gjeresia,
                                               fushat[i].CmimiFushes.ToString() + "€"
                                                );
                    }
                }
            }
        }

        void ShowKlientat()
        {
            var klientat = BussinessLayer.BussinessKlienti.GetAllKlientat();

            for (int i = 0; i < klientat.Count; i++)
            {
                if (klientat[i].isActive == true)
                {
                    klientatgv.Rows.Add(klientat[i].KlientiID,
                                           klientat[i].Emri,
                                           klientat[i].Mbiemri,
                                           klientat[i].NrKontaktues
                                            );
                }
            }
        }

        void ShowUserat()
        {
            var userat = BussinessLayer.BussinessUser.GetAllUsers();

            for (int i = 0; i < userat.Count; i++)
            {
                if (userat[i].IsActive == true)
                {
                    Usersgv.Rows.Add(userat[i].UserID,
                                           userat[i].Emri,
                                           userat[i].Mbiemri,
                                           userat[i].Email,
                                           userat[i].TipiUser.Pershkrimi,
                                           userat[i].NrKontaktues,
                                           userat[i].DataLindjes,
                                           userat[i].Adresa
                                            );
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm f = new AddUserForm();
            f.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deshiron te fshini kete user", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                userid = Usersgv.CurrentCell.RowIndex;
                BussinessLayer.BussinessUser.Delete(int.Parse(Usersgv.Rows[userid].Cells[0].Value.ToString()));
                Usersgv.Visible = true;
                MessageBox.Show("Useri u largua nga lista");
            }
        }

        private void ribbonTab3_Click(object sender, EventArgs e)
        {
            //klientatgv.DataSource = BussinessLayer.BussinessKlienti.GetAllKlientat();
            klientatgv.Visible = true;
            Usersgv.Visible = false;
            GV_Rezervimet.Visible = false;
            fushatgv.Visible = false;
        }

        private void ribbonTab4_Click(object sender, EventArgs e)
        {
            fushatgv.Visible = true;
            //fushatgv.DataSource = BussinessLayer.BussinessFusha.GetAllFushat();
            klientatgv.Visible = false;
            Usersgv.Visible = false;
            GV_Rezervimet.Visible = false;
        }

        private void btnAddKlient_Click(object sender, EventArgs e)
        {
            AddKlient k = new AddKlient();
            k.ShowDialog();
        }

        private void btnRefreshUser_Click(object sender, EventArgs e)
        {
            Usersgv.Rows.Clear();
            ShowUserat();
        }

        private void btnDeleteKlient_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deshiron te fshini kete klient", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    klientiid = klientatgv.CurrentCell.RowIndex;
                    int id = int.Parse(klientatgv.Rows[klientiid].Cells[0].Value.ToString());
                    BussinessLayer.BussinessKlienti.DeleteKlient(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshKlient_Click(object sender, EventArgs e)
        {
            klientatgv.Rows.Clear();
            ShowKlientat();
        }

        private void btnAddFusha_Click(object sender, EventArgs e)
        {
            AddFushaForm f = new AddFushaForm();
            f.ShowDialog();
        }

        private void btnDeleteFusha_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deshiron te fshini kete fushe", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    fushaid = fushatgv.CurrentCell.RowIndex;
                    int id = int.Parse(fushatgv.Rows[fushaid].Cells[0].Value.ToString());
                    BussinessLayer.BussinessFusha.DeleteFusha(id);
                    MessageBox.Show("Fusha u fshi me sukses");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshFushat_Click(object sender, EventArgs e)
        {
            fushatgv.Rows.Clear();
            ShowFushat();
        }

        private void btnEditFusha_Click(object sender, EventArgs e)
        {
            fushaid = fushatgv.CurrentCell.RowIndex;
            int id = int.Parse(fushatgv.Rows[fushaid].Cells[0].Value.ToString());

            EditFushaForm f = new EditFushaForm(id);
            f.ShowDialog();
        }

        private void btnEditLoggedUser_Click(object sender, EventArgs e)
        {
            EditUserForm f = new EditUserForm(useri.UserID);
            f.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRezervim_Click(object sender, EventArgs e)
        {
            AddRezervimForm f = new AddRezervimForm();
            f.ShowDialog();
            btnRefreshRezervimet.PerformClick();
        }

        private void btnRefreshRezervimet_Click(object sender, EventArgs e)
        {
            GV_Rezervimet.Rows.Clear();
            ShowRezervimet();
        }

        private void btnEditoRezervim_Click(object sender, EventArgs e)
        {
            rezervimiid = GV_Rezervimet.CurrentCell.RowIndex;

            DateTime endingDate = Convert.ToDateTime(GV_Rezervimet.Rows[rezervimiid].Cells[6].Value);

            if (endingDate > DateTime.Now)
            {
                int id = int.Parse(GV_Rezervimet.Rows[rezervimiid].Cells[0].Value.ToString());
                EditRezervimForm f = new EditRezervimForm(id);
                f.ShowDialog();
                btnRefreshRezervimet.PerformClick();
            }
            else
            {
                MessageBox.Show("Ka perfundu");
            }

        }

        private void btnFshijRezervim_Click(object sender, EventArgs e)
        {
            rezervimiid = GV_Rezervimet.CurrentCell.RowIndex;
            int id = int.Parse(GV_Rezervimet.Rows[rezervimiid].Cells[0].Value.ToString());

            DialogResult result = MessageBox.Show("Deshiron te fshini kete rezervim", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                BussinessLayer.BussinessRezervimi.DeleteRezervim(id);
                btnRefreshRezervimet.PerformClick();
            }
        }

        private void btnRezervimetHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ne kete forme shfaqen rezervimet qe jane bere ne fusha\n" +
            "Poashtu jane edhe butonat qe mund te shtosh,editosh,fshish dhe ti rifreskoj te dhenat per rezervime\n" +
            "Per te fshire rezervim duhet te selektoni rezervimin ne tabele pastaj te klikoni butonin Delete\n" +
            "Ne pjesen me te larte eshte butoni Sign Out qe mundeson te shkyqeni nga aplikacioni dhe butoni per te edituar te dhenat e userit te loguar",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFushatHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ne kete forme shfaqen fushat qe jane ne dispozicion\n" +
            "Poashtu jane edhe butonat qe mund te shtosh,editosh,fshish dhe ti rifreskoj te dhenat per fushat\n" +
            "Per te fshire fushe duhet te selektoni fushen ne tabele pastaj te klikoni butonin Delete",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radRibbonBarGroup12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ne kete forme shfaqen userat qe jane ne dispozicion\n" +
            "Poashtu jane edhe butonat qe mund te shtosh,editosh,fshish dhe ti rifreskoj te dhenat per userat\n" +
            "Per te fshire user duhet te selektoni userin ne tabele pastaj te klikoni butonin Delete",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKlientatHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ne kete forme shfaqen klientat qe jane ne dispozicion\n" +
            "Poashtu jane edhe butonat qe mund te shtosh,fshish dhe ti rifreskoj te dhenat per klientat\n" +
            "Per te fshire klient duhet te selektoni userin ne tabele pastaj te klikoni butonin Delete",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
