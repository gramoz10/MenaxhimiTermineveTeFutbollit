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

namespace Projekti_TI1_MenaxhimiTermineveTeFutbollit
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mbushini te gjitha hapsirat e kerkuara");
            }
            else
            {
                Regex regex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z]+.[a-zA-Z0-9]+$");
                Match match = regex.Match(email);
                if (!match.Success)
                {
                    MessageBox.Show("Email nuk eshte valide");
                }
                else
                {
                    if (BussinessLayer.BussinessUser.LogInUser(email, password) != null)
                    {
                        Form1.useri = BussinessLayer.BussinessUser.LogInUser(email, password);
                        Form1 f = new Form1();
                        f.Show();
                        txtEmail.Text = "";
                        txtPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ky account nuk ekziston");
                    }
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ne kete forme kerkohet te shtypet email dhe passwordi\n" +
            "Ne fushen e email kerkohet te jete valide",
            "Ndihmese",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
