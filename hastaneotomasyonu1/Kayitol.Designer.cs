
namespace hastaneotomasyonu1
{
    partial class kayitformu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayitformu));
            this.TcKmlk = new System.Windows.Forms.Label();
            this.Ad1 = new System.Windows.Forms.Label();
            this.Dogumtarihi = new System.Windows.Forms.Label();
            this.Soyad1 = new System.Windows.Forms.Label();
            this.dogumyeri = new System.Windows.Forms.Label();
            this.babaadi = new System.Windows.Forms.Label();
            this.anneadi = new System.Windows.Forms.Label();
            this.il = new System.Windows.Forms.Label();
            this.ilce = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.txtbabaadi = new System.Windows.Forms.TextBox();
            this.txtanneadi = new System.Windows.Forms.TextBox();
            this.txtdgmyeri = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtilçe = new System.Windows.Forms.TextBox();
            this.txtil = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.Label();
            this.sigorta = new System.Windows.Forms.Label();
            this.cinsiyet = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.eposta = new System.Windows.Forms.Label();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.hastaDogumDate = new System.Windows.Forms.DateTimePicker();
            this.hastatel = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kayitol = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.tcno = new System.Windows.Forms.MaskedTextBox();
            this.egitimdüz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kronikhas = new System.Windows.Forms.Label();
            this.kız = new System.Windows.Forms.RadioButton();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.boy = new System.Windows.Forms.Label();
            this.kilo = new System.Windows.Forms.Label();
            this.txtboy = new System.Windows.Forms.MaskedTextBox();
            this.txtkilo = new System.Windows.Forms.MaskedTextBox();
            this.gelisebep = new System.Windows.Forms.Label();
            this.txtgelisebep = new System.Windows.Forms.TextBox();
            this.egitimDurumu = new System.Windows.Forms.CheckedListBox();
            this.txtkronik = new System.Windows.Forms.TextBox();
            this.hataKontrol = new System.Windows.Forms.ErrorProvider(this.components);
            this.male_female = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hataKontrol)).BeginInit();
            this.male_female.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcKmlk
            // 
            this.TcKmlk.AutoSize = true;
            this.TcKmlk.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcKmlk.Location = new System.Drawing.Point(13, 10);
            this.TcKmlk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TcKmlk.Name = "TcKmlk";
            this.TcKmlk.Size = new System.Drawing.Size(136, 27);
            this.TcKmlk.TabIndex = 0;
            this.TcKmlk.Text = "TC. Kimlik No :";
            // 
            // Ad1
            // 
            this.Ad1.AutoSize = true;
            this.Ad1.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad1.Location = new System.Drawing.Point(16, 58);
            this.Ad1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ad1.Name = "Ad1";
            this.Ad1.Size = new System.Drawing.Size(44, 27);
            this.Ad1.TabIndex = 1;
            this.Ad1.Text = "Ad :";
            // 
            // Dogumtarihi
            // 
            this.Dogumtarihi.AutoSize = true;
            this.Dogumtarihi.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dogumtarihi.Location = new System.Drawing.Point(16, 98);
            this.Dogumtarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dogumtarihi.Name = "Dogumtarihi";
            this.Dogumtarihi.Size = new System.Drawing.Size(131, 27);
            this.Dogumtarihi.TabIndex = 2;
            this.Dogumtarihi.Text = "Doğum Tarihi :";
            // 
            // Soyad1
            // 
            this.Soyad1.AutoSize = true;
            this.Soyad1.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyad1.Location = new System.Drawing.Point(469, 55);
            this.Soyad1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Soyad1.Name = "Soyad1";
            this.Soyad1.Size = new System.Drawing.Size(68, 27);
            this.Soyad1.TabIndex = 3;
            this.Soyad1.Text = "Soyad :";
            // 
            // dogumyeri
            // 
            this.dogumyeri.AutoSize = true;
            this.dogumyeri.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumyeri.Location = new System.Drawing.Point(469, 101);
            this.dogumyeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dogumyeri.Name = "dogumyeri";
            this.dogumyeri.Size = new System.Drawing.Size(115, 27);
            this.dogumyeri.TabIndex = 4;
            this.dogumyeri.Text = "Doğum Yeri :";
            // 
            // babaadi
            // 
            this.babaadi.AutoSize = true;
            this.babaadi.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.babaadi.Location = new System.Drawing.Point(469, 153);
            this.babaadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.babaadi.Name = "babaadi";
            this.babaadi.Size = new System.Drawing.Size(94, 27);
            this.babaadi.TabIndex = 5;
            this.babaadi.Text = "Baba Adı :";
            // 
            // anneadi
            // 
            this.anneadi.AutoSize = true;
            this.anneadi.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anneadi.Location = new System.Drawing.Point(16, 150);
            this.anneadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.anneadi.Name = "anneadi";
            this.anneadi.Size = new System.Drawing.Size(97, 27);
            this.anneadi.TabIndex = 6;
            this.anneadi.Text = "Anne Adı :";
            // 
            // il
            // 
            this.il.AutoSize = true;
            this.il.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.il.Location = new System.Drawing.Point(16, 199);
            this.il.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(33, 27);
            this.il.TabIndex = 7;
            this.il.Text = "İl :";
            this.il.Click += new System.EventHandler(this.il_Click);
            // 
            // ilce
            // 
            this.ilce.AutoSize = true;
            this.ilce.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilce.Location = new System.Drawing.Point(469, 197);
            this.ilce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ilce.Name = "ilce";
            this.ilce.Size = new System.Drawing.Size(49, 27);
            this.ilce.TabIndex = 8;
            this.ilce.Text = "İlçe :";
            this.ilce.Click += new System.EventHandler(this.ilce_Click);
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres.Location = new System.Drawing.Point(16, 262);
            this.adres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(67, 27);
            this.adres.TabIndex = 9;
            this.adres.Text = "Adres :";
            this.adres.Click += new System.EventHandler(this.adres_Click);
            // 
            // txtbabaadi
            // 
            this.txtbabaadi.Location = new System.Drawing.Point(623, 153);
            this.txtbabaadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtbabaadi.Multiline = true;
            this.txtbabaadi.Name = "txtbabaadi";
            this.txtbabaadi.Size = new System.Drawing.Size(229, 26);
            this.txtbabaadi.TabIndex = 11;
            // 
            // txtanneadi
            // 
            this.txtanneadi.Location = new System.Drawing.Point(197, 153);
            this.txtanneadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtanneadi.Multiline = true;
            this.txtanneadi.Name = "txtanneadi";
            this.txtanneadi.Size = new System.Drawing.Size(229, 26);
            this.txtanneadi.TabIndex = 12;
            // 
            // txtdgmyeri
            // 
            this.txtdgmyeri.Location = new System.Drawing.Point(623, 101);
            this.txtdgmyeri.Margin = new System.Windows.Forms.Padding(4);
            this.txtdgmyeri.Multiline = true;
            this.txtdgmyeri.Name = "txtdgmyeri";
            this.txtdgmyeri.Size = new System.Drawing.Size(229, 26);
            this.txtdgmyeri.TabIndex = 13;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(623, 58);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoyad.Multiline = true;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(229, 26);
            this.txtsoyad.TabIndex = 15;
            this.txtsoyad.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(197, 58);
            this.txtad.Margin = new System.Windows.Forms.Padding(4);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(229, 26);
            this.txtad.TabIndex = 16;
            // 
            // txtilçe
            // 
            this.txtilçe.Location = new System.Drawing.Point(625, 199);
            this.txtilçe.Margin = new System.Windows.Forms.Padding(4);
            this.txtilçe.Multiline = true;
            this.txtilçe.Name = "txtilçe";
            this.txtilçe.Size = new System.Drawing.Size(229, 26);
            this.txtilçe.TabIndex = 17;
            // 
            // txtil
            // 
            this.txtil.Location = new System.Drawing.Point(197, 199);
            this.txtil.Margin = new System.Windows.Forms.Padding(4);
            this.txtil.Multiline = true;
            this.txtil.Name = "txtil";
            this.txtil.Size = new System.Drawing.Size(229, 26);
            this.txtil.TabIndex = 18;
            this.txtil.TextChanged += new System.EventHandler(this.txtil_TextChanged);
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(197, 258);
            this.txtadress.Margin = new System.Windows.Forms.Padding(4);
            this.txtadress.Multiline = true;
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(229, 105);
            this.txtadress.TabIndex = 19;
            this.txtadress.TextChanged += new System.EventHandler(this.txtadress_TextChanged);
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon.Location = new System.Drawing.Point(469, 325);
            this.telefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(78, 27);
            this.telefon.TabIndex = 20;
            this.telefon.Text = "Telefon :";
            this.telefon.Click += new System.EventHandler(this.telefon_Click);
            // 
            // sigorta
            // 
            this.sigorta.AutoSize = true;
            this.sigorta.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sigorta.Location = new System.Drawing.Point(469, 10);
            this.sigorta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sigorta.Name = "sigorta";
            this.sigorta.Size = new System.Drawing.Size(78, 27);
            this.sigorta.TabIndex = 21;
            this.sigorta.Text = "Sigorta :";
            // 
            // cinsiyet
            // 
            this.cinsiyet.AutoSize = true;
            this.cinsiyet.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiyet.Location = new System.Drawing.Point(469, 262);
            this.cinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(86, 27);
            this.cinsiyet.TabIndex = 22;
            this.cinsiyet.Text = "Cinsiyet :";
            this.cinsiyet.Click += new System.EventHandler(this.cinsiyet_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SSK",
            "Özel Sağlık Sigortası",
            "Bağkur",
            "Sigortasız"});
            this.comboBox1.Location = new System.Drawing.Point(620, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 26);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "Sigorta Türünü Seçiniz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // eposta
            // 
            this.eposta.AutoSize = true;
            this.eposta.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eposta.Location = new System.Drawing.Point(13, 394);
            this.eposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(80, 27);
            this.eposta.TabIndex = 27;
            this.eposta.Text = " E-Posta:";
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(197, 398);
            this.txteposta.Margin = new System.Windows.Forms.Padding(4);
            this.txteposta.Multiline = true;
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(229, 26);
            this.txteposta.TabIndex = 29;
            // 
            // hastaDogumDate
            // 
            this.hastaDogumDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDogumDate.Location = new System.Drawing.Point(197, 103);
            this.hastaDogumDate.Margin = new System.Windows.Forms.Padding(4);
            this.hastaDogumDate.Name = "hastaDogumDate";
            this.hastaDogumDate.Size = new System.Drawing.Size(229, 22);
            this.hastaDogumDate.TabIndex = 32;
            this.hastaDogumDate.Value = new System.DateTime(2020, 12, 15, 0, 0, 0, 0);
            this.hastaDogumDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // hastatel
            // 
            this.hastatel.Location = new System.Drawing.Point(625, 327);
            this.hastatel.Margin = new System.Windows.Forms.Padding(4);
            this.hastatel.Mask = "(999) 000-0000";
            this.hastatel.Name = "hastatel";
            this.hastatel.Size = new System.Drawing.Size(229, 22);
            this.hastatel.TabIndex = 35;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 752);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(871, 132);
            this.listBox1.TabIndex = 36;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // kayitol
            // 
            this.kayitol.BackColor = System.Drawing.Color.Silver;
            this.kayitol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitol.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitol.Location = new System.Drawing.Point(474, 686);
            this.kayitol.Margin = new System.Windows.Forms.Padding(4);
            this.kayitol.Name = "kayitol";
            this.kayitol.Size = new System.Drawing.Size(115, 28);
            this.kayitol.TabIndex = 37;
            this.kayitol.Text = "KAYIT OL";
            this.kayitol.UseVisualStyleBackColor = false;
            this.kayitol.Click += new System.EventHandler(this.kayitol_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.Silver;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.Location = new System.Drawing.Point(622, 686);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(117, 28);
            this.guncelle.TabIndex = 38;
            this.guncelle.Text = "TEMİZLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Silver;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(773, 686);
            this.sil.Margin = new System.Windows.Forms.Padding(4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(112, 28);
            this.sil.TabIndex = 39;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // tcno
            // 
            this.tcno.Location = new System.Drawing.Point(197, 11);
            this.tcno.Margin = new System.Windows.Forms.Padding(4);
            this.tcno.Mask = "00000000000";
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(229, 22);
            this.tcno.TabIndex = 40;
            // 
            // egitimdüz
            // 
            this.egitimdüz.AutoSize = true;
            this.egitimdüz.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.egitimdüz.Location = new System.Drawing.Point(469, 398);
            this.egitimdüz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.egitimdüz.Name = "egitimdüz";
            this.egitimdüz.Size = new System.Drawing.Size(133, 27);
            this.egitimdüz.TabIndex = 41;
            this.egitimdüz.Text = "Eğitim Düzeyi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(927, 463);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 42;
            // 
            // kronikhas
            // 
            this.kronikhas.AutoSize = true;
            this.kronikhas.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kronikhas.Location = new System.Drawing.Point(434, 564);
            this.kronikhas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kronikhas.Name = "kronikhas";
            this.kronikhas.Size = new System.Drawing.Size(171, 27);
            this.kronikhas.TabIndex = 43;
            this.kronikhas.Text = "Kronik Hastalıklar :";
            // 
            // kız
            // 
            this.kız.AutoSize = true;
            this.kız.Location = new System.Drawing.Point(7, 30);
            this.kız.Margin = new System.Windows.Forms.Padding(4);
            this.kız.Name = "kız";
            this.kız.Size = new System.Drawing.Size(50, 21);
            this.kız.TabIndex = 46;
            this.kız.TabStop = true;
            this.kız.Text = "KIZ";
            this.kız.UseVisualStyleBackColor = true;
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Location = new System.Drawing.Point(142, 30);
            this.erkek.Margin = new System.Windows.Forms.Padding(4);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(75, 21);
            this.erkek.TabIndex = 47;
            this.erkek.TabStop = true;
            this.erkek.Text = "ERKEK";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // boy
            // 
            this.boy.AutoSize = true;
            this.boy.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boy.Location = new System.Drawing.Point(16, 496);
            this.boy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boy.Name = "boy";
            this.boy.Size = new System.Drawing.Size(52, 27);
            this.boy.TabIndex = 48;
            this.boy.Text = "Boy :";
            this.boy.Click += new System.EventHandler(this.label1_Click);
            // 
            // kilo
            // 
            this.kilo.AutoSize = true;
            this.kilo.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kilo.Location = new System.Drawing.Point(16, 446);
            this.kilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kilo.Name = "kilo";
            this.kilo.Size = new System.Drawing.Size(55, 27);
            this.kilo.TabIndex = 49;
            this.kilo.Text = "Kilo :";
            this.kilo.Click += new System.EventHandler(this.kilo_Click);
            // 
            // txtboy
            // 
            this.txtboy.Location = new System.Drawing.Point(197, 496);
            this.txtboy.Margin = new System.Windows.Forms.Padding(4);
            this.txtboy.Mask = "000";
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(229, 22);
            this.txtboy.TabIndex = 50;
            // 
            // txtkilo
            // 
            this.txtkilo.Location = new System.Drawing.Point(197, 450);
            this.txtkilo.Margin = new System.Windows.Forms.Padding(4);
            this.txtkilo.Mask = "000";
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(229, 22);
            this.txtkilo.TabIndex = 51;
            // 
            // gelisebep
            // 
            this.gelisebep.AutoSize = true;
            this.gelisebep.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelisebep.Location = new System.Drawing.Point(16, 562);
            this.gelisebep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gelisebep.Name = "gelisebep";
            this.gelisebep.Size = new System.Drawing.Size(140, 54);
            this.gelisebep.TabIndex = 52;
            this.gelisebep.Text = "Hastaneye Geliş \r\nSebebi :";
            // 
            // txtgelisebep
            // 
            this.txtgelisebep.Location = new System.Drawing.Point(197, 564);
            this.txtgelisebep.Margin = new System.Windows.Forms.Padding(4);
            this.txtgelisebep.Multiline = true;
            this.txtgelisebep.Name = "txtgelisebep";
            this.txtgelisebep.Size = new System.Drawing.Size(229, 80);
            this.txtgelisebep.TabIndex = 53;
            // 
            // egitimDurumu
            // 
            this.egitimDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.egitimDurumu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.egitimDurumu.ForeColor = System.Drawing.Color.Black;
            this.egitimDurumu.FormattingEnabled = true;
            this.egitimDurumu.Items.AddRange(new object[] {
            "YOK",
            "İLKOKUL",
            "ORTAOKUL",
            "LİSE",
            "ÖNLİSANS",
            "LİSANS ",
            "YÜKSEK LİSANS",
            "DOKTORA "});
            this.egitimDurumu.Location = new System.Drawing.Point(625, 404);
            this.egitimDurumu.Margin = new System.Windows.Forms.Padding(4);
            this.egitimDurumu.Name = "egitimDurumu";
            this.egitimDurumu.Size = new System.Drawing.Size(253, 153);
            this.egitimDurumu.TabIndex = 55;
            this.egitimDurumu.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // txtkronik
            // 
            this.txtkronik.Location = new System.Drawing.Point(621, 564);
            this.txtkronik.Margin = new System.Windows.Forms.Padding(4);
            this.txtkronik.Multiline = true;
            this.txtkronik.Name = "txtkronik";
            this.txtkronik.Size = new System.Drawing.Size(229, 26);
            this.txtkronik.TabIndex = 56;
            this.txtkronik.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // hataKontrol
            // 
            this.hataKontrol.ContainerControl = this;
            // 
            // male_female
            // 
            this.male_female.Controls.Add(this.kız);
            this.male_female.Controls.Add(this.erkek);
            this.male_female.Location = new System.Drawing.Point(623, 232);
            this.male_female.Name = "male_female";
            this.male_female.Size = new System.Drawing.Size(231, 71);
            this.male_female.TabIndex = 57;
            this.male_female.TabStop = false;
            // 
            // kayitformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(932, 935);
            this.Controls.Add(this.male_female);
            this.Controls.Add(this.txtkronik);
            this.Controls.Add(this.egitimDurumu);
            this.Controls.Add(this.txtgelisebep);
            this.Controls.Add(this.gelisebep);
            this.Controls.Add(this.txtkilo);
            this.Controls.Add(this.txtboy);
            this.Controls.Add(this.kilo);
            this.Controls.Add(this.boy);
            this.Controls.Add(this.kronikhas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.egitimdüz);
            this.Controls.Add(this.tcno);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.kayitol);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.hastatel);
            this.Controls.Add(this.hastaDogumDate);
            this.Controls.Add(this.txteposta);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.sigorta);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.txtadress);
            this.Controls.Add(this.txtil);
            this.Controls.Add(this.txtilçe);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtdgmyeri);
            this.Controls.Add(this.txtanneadi);
            this.Controls.Add(this.txtbabaadi);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.ilce);
            this.Controls.Add(this.il);
            this.Controls.Add(this.anneadi);
            this.Controls.Add(this.babaadi);
            this.Controls.Add(this.dogumyeri);
            this.Controls.Add(this.Soyad1);
            this.Controls.Add(this.Dogumtarihi);
            this.Controls.Add(this.Ad1);
            this.Controls.Add(this.TcKmlk);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kayitformu";
            this.Text = "Hasta Kayıt Formu";
            this.Load += new System.EventHandler(this.kayitformu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hataKontrol)).EndInit();
            this.male_female.ResumeLayout(false);
            this.male_female.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TcKmlk;
        private System.Windows.Forms.Label Ad1;
        private System.Windows.Forms.Label Dogumtarihi;
        private System.Windows.Forms.Label Soyad1;
        private System.Windows.Forms.Label dogumyeri;
        private System.Windows.Forms.Label babaadi;
        private System.Windows.Forms.Label anneadi;
        private System.Windows.Forms.Label il;
        private System.Windows.Forms.Label ilce;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.TextBox txtbabaadi;
        private System.Windows.Forms.TextBox txtanneadi;
        private System.Windows.Forms.TextBox txtdgmyeri;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtilçe;
        private System.Windows.Forms.TextBox txtil;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.Label sigorta;
        private System.Windows.Forms.Label cinsiyet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label eposta;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.MaskedTextBox hastatel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button kayitol;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.MaskedTextBox tcno;
        private System.Windows.Forms.Label egitimdüz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kronikhas;
        private System.Windows.Forms.RadioButton kız;
        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.Label boy;
        private System.Windows.Forms.Label kilo;
        private System.Windows.Forms.MaskedTextBox txtboy;
        private System.Windows.Forms.MaskedTextBox txtkilo;
        private System.Windows.Forms.Label gelisebep;
        private System.Windows.Forms.TextBox txtgelisebep;
        private System.Windows.Forms.CheckedListBox egitimDurumu;
        private System.Windows.Forms.TextBox txtkronik;
        private System.Windows.Forms.ErrorProvider hataKontrol;
        private System.Windows.Forms.GroupBox male_female;
        private System.Windows.Forms.DateTimePicker hastaDogumDate;
    }
}

