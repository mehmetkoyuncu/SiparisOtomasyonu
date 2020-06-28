using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFCSiparisOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        string SecilmisMenu;
        int TTutar;
        string AdSoyadd;
        
        private void btnTamamla_Click(object sender, EventArgs e)
        {
            string AdSoyad = txtAdSoyad.Text;
           
            string TelefonNo = this.txtNumara.Text;
           
            string Adres = txtAdres.Text;


            string SeciliMenu=null;

            if (this.cmbMenu.SelectedItem==null)
            {
                MessageBox.Show("Menü Seçimi Yapılmadı");
            }
            else
            {
                SeciliMenu = this.cmbMenu.SelectedItem.ToString();
            }
          


            int adet = Convert.ToInt32(this.numericUpDown1.Value);
           


            MenuClass menu = new MenuClass();
            Boy boy = new Boy();
                int Tutar=0;

                    if (SeciliMenu == "King Burger")
                    {
                        int KingM = menu.KingBurgerGetir();
                        Tutar = Tutar + KingM;

                    }
                    else if (SeciliMenu == "Whooper")
                    {
                        int Whooper = menu.WhooperGetir();
                        Tutar = Tutar + Whooper;
                    }
                    else if (SeciliMenu == "Double Burger")
                    {
                        int DoubleBurger = menu.DoubleBurgerGetir();
                        Tutar = Tutar + DoubleBurger;
                    }
                    else if (SeciliMenu == "Fish Royale")
                    {
                        int FishRoyale = menu.FishRoyaleGetir();
                        Tutar = Tutar + FishRoyale;
                    }
                    else if (SeciliMenu == "Chicken Royale")
                    {
                        int ChickenRoyale = menu.ChickenRoyaleGetir();
                        Tutar = Tutar + ChickenRoyale;
                    }
         
          

               


                if(this.radioBig.Checked==true)
                {
                    int BigBoy = boy.BuyukGetir();
                    Tutar = Tutar + BigBoy;
                }
                else if(radiKing.Checked==true)
                {
                    int KingBoy = boy.KingGetir();
                    Tutar = Tutar + KingBoy;
                }
                if(chckBarbekü.Checked==true)
                {
                    Tutar = Tutar + 1;
                }
                if (chckHardal.Checked == true)
                {
                    Tutar = Tutar + 1;
                }
                if (chckRanch.Checked == true)
                {
                    Tutar = Tutar + 1;
                }
                if (chckSMayonez.Checked == true)
                {
                    Tutar = Tutar + 1;
                }
               Tutar = Tutar * adet;

            SecilmisMenu = SeciliMenu ;
            TTutar = Tutar;
            AdSoyadd = AdSoyad;

           

               lblToplamTutar.Text = Tutar.ToString()+" "+"TL";
             lblFisAdSoyad.Text = txtAdSoyad.Text;

            List<string> gonder = new List<string>();
            gonder.Add(AdSoyad);
            gonder.Add(SeciliMenu);

          
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chckKurye.Checked = true;
           
        }

        private void chckKurye_CheckedChanged(object sender, EventArgs e)
        {
           
            if (this.chckKurye.Checked == false)
            {
                txtNumara.Enabled = false;
                txtAdres.Enabled = false;

                this.txtNumara.BackColor = Color.Gray;
                this.txtAdres.BackColor = Color.Gray;
            }
            else
            {
                txtNumara.Enabled = true;
                txtAdres.Enabled = true;
                this.txtNumara.BackColor = Color.White;
                this.txtAdres.BackColor = Color.White;
            }
           
        }

       


        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if(lblFisAdSoyad.Text=="")
            {
                MessageBox.Show("Ad Soyad Bilgisi Girilmedi");
            }
            if(lblToplamTutar.Text=="")
            {
                MessageBox.Show("Tutar Bilgisi Sonuçlanmadı");
            }
            
            lstSiparis.Items.Add("Ad Soyad : " + AdSoyadd + " " +" "+ "Sipariş : "
                + SecilmisMenu + " "+" " + "Tutar : " + TTutar.ToString()+" "+" " +"Durum :  Hazırlanıyor");
            lstSiparis.SelectedItem = lstSiparis.Items[0];


          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstSiparis.Items.Remove(lstSiparis.SelectedItem);
        }
    }
}
