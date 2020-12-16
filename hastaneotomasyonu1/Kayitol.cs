using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace hastaneotomasyonu1
{
    public partial class kayitformu : Form
    {
        public kayitformu()
        {
            InitializeComponent();
        }

        private void kayitformu_Load(object sender, EventArgs e)
        {
            hastaDogumDate.Format = DateTimePickerFormat.Short;
            hastaDogumDate.CustomFormat = "d/M/yyyy";
            hastaDogumDate.Value = DateTime.Now;
        }

        private void kayitol_Click(object sender, EventArgs e)
        {
            hataKontrol.Clear();
            string tcNo = "", comboBox = "", txtAd = "", txtSoyad = "", txtDgmyeri = "", hastadogumdate = "", txtAnneadi = "", txtBabaadi = "", txtIl = "", txtIlçe = "", txtAdress = "", male_Female = "", hastaTel = "", txtEposta = "", txtKilo = "", txtBoy = "", egitim_Durumu = "girilmedi", gelisSebebi = "", kronikRahatsizlik = "";

            if (tcno.Text.Length == 11)
            {
                tcNo = tcno.Text;
            }
            else
            {
                hataKontrol.SetError(tcno, "tc no Geçersizdir.");
            }

            if (comboBox1.SelectedItem == null)
            {
                hataKontrol.SetError(comboBox1, "Lütfen sigorta türünü seçiniz.");
            }
            else
            {
                comboBox = comboBox1.Text;
            }

            if (string.IsNullOrWhiteSpace(txtad.Text))
            {
                hataKontrol.SetError(txtad, "Lütfen hasta adını giriniz...");

            }
            else
            {
                txtAd = txtad.Text;
            }

            if (string.IsNullOrWhiteSpace(txtsoyad.Text))
            {
                hataKontrol.SetError(txtsoyad, "Lütfen hasta soyadını giriniz...");
            }
            else
            {
                txtSoyad = txtsoyad.Text;
            }

            DateTime today = DateTime.Today.Date;
            if (hastaDogumDate.Value > today)
            {
                hataKontrol.SetError(hastaDogumDate, "Lütfen hasta doğum tarihini giriniz...");
            }
            else
            {
                hastadogumdate = hastaDogumDate.Value.ToString();
            }

            if (string.IsNullOrWhiteSpace(txtdgmyeri.Text))
            {
                hataKontrol.SetError(txtdgmyeri, "Lütfen hasta doğum yerini giriniz...");

            }
            else
            {
                txtDgmyeri = txtdgmyeri.Text;
            }

            if (string.IsNullOrWhiteSpace(txtanneadi.Text))
            {
                hataKontrol.SetError(txtanneadi, "Lütfen hasta anne adını giriniz...");
            }
            else
            {
                txtAnneadi = txtanneadi.Text;
            }

            if (string.IsNullOrWhiteSpace(txtbabaadi.Text))
            {
                hataKontrol.SetError(txtbabaadi, "Lütfen hasta baba adını giriniz...");
            }
            else
            {
                txtBabaadi = txtbabaadi.Text;
            }

            if (string.IsNullOrWhiteSpace(txtil.Text))
            {
                hataKontrol.SetError(txtil, "Lütfen hasta il bilgisini giriniz...");
            }
            else
            {
                txtIl = txtil.Text;
            }

            if (string.IsNullOrWhiteSpace(txtilçe.Text))
            {
                hataKontrol.SetError(txtilçe, "Lütfen hasta ilçe bilgisini giriniz...");
            }
            else
            {
                txtIlçe = txtilçe.Text;
            }

            if (string.IsNullOrWhiteSpace(txtadress.Text))
            {
                hataKontrol.SetError(txtadress, "Lütfen hasta adres bilgisini giriniz...");
            }
            else
            {
                txtAdress = txtadress.Text;
            }

            if (kız.Checked == true)
            {
                male_Female = kız.Text;
            }
            else if (erkek.Checked == true)
            {
                male_Female = erkek.Text;
            }
            else
            {
                hataKontrol.SetError(male_female, "Lütfen hasta cinsiyet bilgisini giriniz...");
            }

            if (hastatel.Text.Length == 10)
            {
                hataKontrol.SetError(hastatel, "Lütfen hasta telefon bilgisini giriniz...");
            }
            else
            {
                hastaTel = hastatel.Text;
            }

            if (string.IsNullOrWhiteSpace(txteposta.Text))
            {
                hataKontrol.SetError(txteposta, "Lütfen hasta e posta bilgisini giriniz...");
            }
            else
            {
                txtEposta = txteposta.Text;
            }

            if (string.IsNullOrWhiteSpace(txtkilo.Text))
            {
                hataKontrol.SetError(txtkilo, "Lütfen hasta kilo bilgisini giriniz...");
            }
            else
            {
                txtKilo = txtkilo.Text;
            }


            if (string.IsNullOrWhiteSpace(txtboy.Text))
            {
                hataKontrol.SetError(txtboy, "Lütfen hasta boy bilgisini giriniz...");
            }
            else
            {
                txtBoy = txtboy.Text;
            }


            foreach (string s in egitimDurumu.CheckedItems)
            {
                egitim_Durumu = s;
            }
            for (int i = 0; i < egitimDurumu.Items.Count; i++)
            {
                egitimDurumu.SetItemChecked(i, false);
            }




            if (string.IsNullOrWhiteSpace(txtgelisebep.Text))
            {
                hataKontrol.SetError(txtgelisebep, "Lütfen hasta geliş sebebini giriniz...");
            }
            else
            {
                gelisSebebi = txtgelisebep.Text;
            }


            if (string.IsNullOrWhiteSpace(txtkronik.Text))
            {
                hataKontrol.SetError(txtkronik, "Lütfen hasta geliş sebebini giriniz...");
            }
            else
            {
                kronikRahatsizlik = txtkronik.Text;
            }


            listBox1.Items.Add(tcNo + " " + comboBox + " " + txtAd + " " + txtSoyad + " " + hastadogumdate + " " + txtDgmyeri + " " + txtAnneadi + " " + txtBabaadi + " " + txtIl + " " + txtIlçe + " " + txtAdress + " " + male_Female + " " + hastaTel + " " + txtEposta + " " + txtKilo + " " + txtBoy + " " + egitim_Durumu + " " + gelisSebebi + " " + kronikRahatsizlik);


        }
        private void guncelle_Click(object sender, EventArgs e)
        {
            tcno.Text = "";
            comboBox1.Text = "Sigorta Türünü Seçiniz";
            txtad.Text = "";
            txtsoyad.Text = "";
            hastaDogumDate.Value = DateTime.Now;
            txtdgmyeri.Text = "";
            txtanneadi.Text = "";
            txtbabaadi.Text = "";
            txtil.Text = "";
            txtilçe.Text = "";
            txtadress.Text = "";
            hastatel.Text = "";
            txteposta.Text = "";
            txtkilo.Text = "";
            txtboy.Text = "";
            txtgelisebep.Text = "";
            txtkronik.Text = "";

            foreach (RadioButton r in male_female.Controls.OfType<RadioButton>())
            {
                r.Checked = false;
            }

            foreach (int i in egitimDurumu.CheckedIndices)

            {
                egitimDurumu.SetItemCheckState(i, CheckState.Unchecked);
            }


        }

        private void sil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void adres_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void il_Click(object sender, EventArgs e)
        {

        }

        private void telefon_Click(object sender, EventArgs e)
        {

        }

        private void txtadress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtil_TextChanged(object sender, EventArgs e)
        {

        }

        private void ilce_Click(object sender, EventArgs e)
        {

        }

        private void cinsiyet_Click(object sender, EventArgs e)
        {

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kilo_Click(object sender, EventArgs e)
        {

        }

       
    }
}
