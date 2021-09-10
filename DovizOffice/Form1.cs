using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace DovizOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void guncelle()
        {
            string bugun = "https://tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDolarAlis.Text = dolaralis;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDolarSatis.Text = dolarsatis;
            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroAlis.Text = euroalis;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroSatis.Text = eurosatis;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dovizOfficeDataSet.TblKasa' table. You can move, or remove it, as needed.
            this.tblKasaTableAdapter.Fill(this.dovizOfficeDataSet.TblKasa);
            guncelle();
            timer1.Start();
            
        }
SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DovizOffice;Integrated Security=True");
        private void BtnDolarAlis_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarAlis.Text;

            

        }

        private void BtnDolarSatis_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarSatis.Text;
        }

        private void BtnEuroAlis_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroAlis.Text;
        }

        private void BtnEuroSatis_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroSatis.Text;
        }

        void clear()
        {
            
            TxtKur.Text = "";
            TxtTutar.Text = "";
            TxtMiktar.Text = "";
        }
        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            guncelle();
            baglanti.Open();
            //dolar alış
            if(TxtKur.Text==label2.Text)
            {
                SqlCommand komut = new SqlCommand("update TblKasa set Miktar=Miktar+@p1 where ID=2", baglanti);
                SqlCommand komut2 = new SqlCommand("update TblKasa set Miktar=Miktar-@p2 where ID=1", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@p2", Convert.ToDecimal(TxtTutar.Text));
                komut2.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                MessageBox.Show("işlem tamamlandı");
                
            }
            //dolar satış
            if(TxtKur.Text==label3.Text)
            {
                SqlCommand komut1 = new SqlCommand("update TblKasa set Miktar=Miktar-@p3 where ID=2", baglanti);
                SqlCommand komut3 = new SqlCommand("update TblKasa set Miktar=Miktar+@p4 where ID=1", baglanti);
                komut1.Parameters.AddWithValue("@p3", TxtMiktar.Text);
                komut3.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtTutar.Text));
                komut1.ExecuteNonQuery();
                komut3.ExecuteNonQuery();
                MessageBox.Show("işlem tamamlandı");
            }
            //euro alış
            if (TxtKur.Text == label5.Text)
            {
                SqlCommand komut4 = new SqlCommand("update TblKasa set Miktar=Miktar+@p5 where ID=3", baglanti);
                SqlCommand komut5 = new SqlCommand("update TblKasa set Miktar=Miktar-@p6 where ID=1", baglanti);
                komut4.Parameters.AddWithValue("@p5", TxtMiktar.Text);
                komut5.Parameters.AddWithValue("@p6", Convert.ToDecimal(TxtTutar.Text));
                komut5.ExecuteNonQuery();
                komut4.ExecuteNonQuery();
                MessageBox.Show("işlem tamamlandı");
            }
            //euro satış
            if (TxtKur.Text == label7.Text)
            {
                SqlCommand komut6 = new SqlCommand("update TblKasa set Miktar=Miktar-@p7 where ID=3", baglanti);
                SqlCommand komut7 = new SqlCommand("update TblKasa set Miktar=Miktar+@p8 where ID=1", baglanti);
                komut6.Parameters.AddWithValue("@p7", TxtMiktar.Text);
                komut7.Parameters.AddWithValue("@p8", Convert.ToDecimal(TxtTutar.Text));
                komut7.ExecuteNonQuery();
                komut6.ExecuteNonQuery();
                MessageBox.Show("işlem tamamlandı");
            }
            baglanti.Close();
            this.tblKasaTableAdapter.Fill(this.dovizOfficeDataSet.TblKasa);



        }

        private void TxtKur_TextChanged(object sender, EventArgs e)
        {
            TxtKur.Text = TxtKur.Text.Replace(".",",");
            
        }

        

        private void TxtMiktar_TextChanged(object sender, EventArgs e)
        {
            
            if (TxtKur.Text.Trim()!="")
            {

                if (TxtMiktar.Text.Trim() != "")
                {
                    double miktar, tutar;
                    double kur;

                    kur = Convert.ToDouble(TxtKur.Text);

                    miktar = Convert.ToDouble(TxtMiktar.Text);
                    tutar = kur * miktar;
                    TxtTutar.Text = Convert.ToString(Convert.ToDecimal(tutar));
                }


                
            }



            else { MessageBox.Show("Lütfen Kuru Seçiniz"); }





        }

        private void TxtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void LblDolarAlis_TextChanged(object sender, EventArgs e)
        {
            label2.Text = LblDolarAlis.Text.Replace(".", ",");
        }

        private void LblDolarSatis_TextChanged(object sender, EventArgs e)
        {
            label3.Text = LblDolarSatis.Text.Replace(".", ",");
        }

        private void LblEuroAlis_TextChanged(object sender, EventArgs e)
        {
            label5.Text = LblEuroAlis.Text.Replace(".", ",");
        }

        private void LblEuroSatis_TextChanged(object sender, EventArgs e)
        {
            label7.Text = LblEuroSatis.Text.Replace(".", ",");
        }

        private void TxtTutar_TextChanged(object sender, EventArgs e)
        {
            if (TxtKur.Text != "")
            {
                if (TxtTutar.Text.Trim() != "")
                {
                    double kur, miktar, tutar;
                    kur = Convert.ToDouble(TxtKur.Text);
                    tutar = Convert.ToDouble(TxtTutar.Text);
                    miktar = tutar / kur;
                    TxtMiktar.Text = Convert.ToString(Convert.ToDecimal(miktar));
                }
            }
            else { MessageBox.Show("Lütfen Kuru Seçiniz"); }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            guncelle();
            
        }
    }
}
