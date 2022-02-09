using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcij_Brkovi
{
    public partial class Form1 : Form
    {
        List<Osoba> osobe = new List<Osoba>();
            public Form1()
            {
                InitializeComponent();
            }

            private void btnUnesi_Click(object sender, EventArgs e)
            {
            try
            {
                Osoba osoba = new Osoba(txtbIme.Text, txtbPrezime.Text, combSpol.Text, txtbGodina.Text);

                osobe.Add(osoba);

                txtbIme.Clear();
                txtbPrezime.Clear();
                txtbGodina.Clear();

                MessageBox.Show("Uspješan unos!\r\n", "Obavijest",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {

                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            

            rtbIspis.Text = "Ime" + "\tPrezime" + "\tSpol" + "\tGodište "+"\tDodatak"+"\n";

            string dodatak;
            foreach (Osoba osoba in osobe)
            {
                if (osoba.Spol == "M")
                {
                    dodatak = "Ima brkove";
                    rtbIspis.AppendText(osoba.ToString()+dodatak+"\n");
                }
                else
                {
                    dodatak = "Nema brkove";
                    rtbIspis.AppendText(osoba.ToString()  + dodatak+"\n");
                }
            }



        }

        private void btnIspiši_Click(object sender, EventArgs e)
        {
            rtbIspis.Text = "Ime" + "\tPrezime" + "\tSpol"+"\tGodište"+"\n";

            foreach(Osoba osoba in osobe)
            {
                rtbIspis.AppendText(osoba.ToString() + "\r\n");

            }
        }
    }
    }

