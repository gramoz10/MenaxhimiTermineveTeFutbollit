using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using EntityLayer;

namespace Projekti_TI1_MenaxhimiTermineveTeFutbollit
{
    public partial class EditUserForm : Form
    {
        private int userid;
        User user;
        public EditUserForm(int id)
        {
            InitializeComponent();
            userid = id;
            Show();
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtEmri.Text) || String.IsNullOrEmpty(txtMbiemri.Text) || String.IsNullOrEmpty(txtPassword.Text)
                       || String.IsNullOrEmpty(txtAdresa.Text) || String.IsNullOrEmpty(txtNrKontaktues.Text) || String.IsNullOrEmpty(dtDataLindjes.Text))
                {
                    MessageBox.Show("Mbushini të gjitha hapsirat e kerkuara");
                }
                else
                {
                    user.Emri = txtEmri.Text;
                    user.Mbiemri = txtMbiemri.Text;
                    user.Password = txtPassword.Text;
                    user.Adresa = txtAdresa.Text;
                    user.NrKontaktues = txtNrKontaktues.Text;
                    user.DataLindjes = Convert.ToDateTime(dtDataLindjes.Text);

                    BussinessUser.EditUser(userid, user);
                    MessageBox.Show("Useri u editua me sukses");
                    this.Close();
                }
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
                user = BussinessUser.GetUserById(userid);
                txtEmri.Text = user.Emri;
                txtMbiemri.Text = user.Mbiemri;
                txtPassword.Text = user.Password;
                txtAdresa.Text = user.Adresa;
                txtNrKontaktues.Text = user.NrKontaktues;
                dtDataLindjes.Text = user.DataLindjes.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Useri editohet ai qe eshte i loguar\n"+
            "Ne kete forme duhet te editoni emrin,mbiemrin,password,adresen,daten e lindjes dhe numrin kontaktues per Userin\n" +
            "Email nuk mund ta editoni shkaku qe vlen per LogIn\n" +
            "As Rolin nuk mund ta editoni\n" +
            "Kujdes forma nuk duhet te kete hapsira te zbrasta",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
