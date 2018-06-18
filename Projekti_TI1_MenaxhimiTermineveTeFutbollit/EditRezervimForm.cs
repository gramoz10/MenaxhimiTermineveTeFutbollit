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
    public partial class EditRezervimForm : Form
    {
        private int rezervimiid;
        Rezervimi rezervimi;
        public EditRezervimForm(int rezervimiID)
        {
            rezervimiid = rezervimiID;
            InitializeComponent();
            Show();
        }

        void Show()
        {
            try
            {
                rezervimi = BussinessRezervimi.GetAllRezervimetByID(rezervimiid);
                lblShowR.Text += rezervimi.RezervimiID.ToString();
                dtMbarimiRezervimit.Text = rezervimi.MbarimiRezervimit.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            try
            {
                rezervimi.MbarimiRezervimit = Convert.ToDateTime(dtMbarimiRezervimit.Value);

                BussinessRezervimi.EditRezervim(rezervimi);
                MessageBox.Show("Rezervimi u editua");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ne kete forme duhet te editoni kohezgjatjen e rezervimit\n" +
            "Rezervimit i editohet vetem kohezgjatja e jo fusha\n" +
            "Per te edituar vetem klikoni kohen ne kontrolle edhe shtypni me tastiere\n" +
            "Pagesa per rezervimin e edituar kalkulohet ne Databaze",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
