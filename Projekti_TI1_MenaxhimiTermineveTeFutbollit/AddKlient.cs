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
    public partial class AddKlient : Form
    {
        public AddKlient()
        {
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            string emri = txtEmri.Text;
            string mbiemri = txtMbiemri.Text;
            string nrkontaktues = txtNrkontaktues.Text;

            if (String.IsNullOrEmpty(emri) || String.IsNullOrEmpty(mbiemri) || String.IsNullOrEmpty(nrkontaktues))
            {
                MessageBox.Show("Mbushini te gjitha hapsirat e kerkuara");
            }
            else
            {
                Klienti newKlient = new Klienti()
                {
                    Emri = emri,
                    Mbiemri = mbiemri,
                    NrKontaktues = nrkontaktues
                };
                BussinessKlienti.InsertKlient(newKlient);
                MessageBox.Show("U shtua nje klient i ri");
                this.Close();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ne kete forme duhet te shtypni emrin,mbiemrin dhe numrin kontaktues per klientin\nKujdes forma nuk duhet te kete hapsira te zbrasta",
            "Ndihmese",
            MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

