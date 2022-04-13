using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            if (txt_Ad.Text == "" || Txt_Soyad.Text == "" || Txt_Email.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurunuz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Kayıt Olma İşlemi Başarılı");
                Personel p = new Personel();
                p.Ad = txt_Ad.Text;
                p.Soyad = Txt_Soyad.Text;
                p.Email = Txt_Email.Text;
                p.Sifre = txt_sifre.Text;
                p.PersonelID = Program.personel.PersonelID;
                db.Personel.Add(p);
                db.SaveChanges();
                this.Close();
            }
    }
}
