using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using EntityLayer;

namespace Projekti_TI1_MenaxhimiTermineveTeFutbollit
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            cmbTipi.DataSource = BussinessTipiUser.GetAllTipiUser();
            cmbTipi.ValueMember = "TipiID";
            cmbTipi.DisplayMember = "Pershkrimi";
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                string emri = txtEmri.Text;
                string mbiemri = txtMbiemri.Text;
                string email = txtEmail.Text;
                string adresa = txtAdresa.Text;
                string nrkontaktues = txtNrKontaktues.Text;
                string password = txtPassword.Text;
                DateTime dt = Convert.ToDateTime(dtDataLindjes.Text);
                string tipi = cmbTipi.SelectedValue.ToString();
                string pershkrimi = cmbTipi.Text;

                if (String.IsNullOrEmpty(emri) || String.IsNullOrEmpty(mbiemri) || String.IsNullOrEmpty(email)
                    || String.IsNullOrEmpty(adresa) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password)
                    || String.IsNullOrEmpty(dt.ToString()) || String.IsNullOrEmpty(tipi) || String.IsNullOrEmpty(pershkrimi))
                {
                    MessageBox.Show("Duhet te mbushen te gjitha hapsirat e kerkuara");
                }
                else
                {
                    string emailRegex = email;
                    Regex regex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z]+.[a-zA-Z0-9]+$");
                    Match match = regex.Match(emailRegex);
                    if (!match.Success)
                    {
                        MessageBox.Show("Email nuk eshte valide");
                    }
                    else
                    {
                        User newUser = new User()
                        {
                            Emri = emri,
                            Mbiemri = mbiemri,
                            Email = email,
                            Password = password,
                            NrKontaktues = nrkontaktues,
                            DataLindjes = dt,
                            Adresa = adresa,
                            TipiUser = new TipiUser()
                            {
                                TipiID = int.Parse(tipi),
                                Pershkrimi = pershkrimi
                            }
                        };

                        BussinessUser.InsertUser(newUser);
                        MessageBox.Show("U shtua user i ri");
                        this.Close();
                    }
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
            "Ne kete forme duhet te shtypni emrin,mbiemrin,email,password,adresen,daten e lindjes dhe numrin kontaktues per Userin\n" +
            "Poashtu duhet te zgjedhni rolin e Userit\n"+
            "Kujdes forma nuk duhet te kete hapsira te zbrasta",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
