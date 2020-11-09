using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace StajBasvurusu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BasvuruKayıt_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Stajer.accdb");
            OleDbDataAdapter adapt = new OleDbDataAdapter();
            OleDbCommand komut = new OleDbCommand();
            string ekle = "INSERT INTO Stajerler(Okno, AdSo, Bolum, StajTur, isAd, isTel, isPost, Faal)"+
                "VALUES('"+OkNo.Text+"','"+AdSo.Text+"','"+Bolum.SelectedItem+"','"+StajTur.SelectedItem
                +"','"+isAd.Text+"','"+isTel.Text+"','"+isPost.Text+"','"+Faal.Text+"')";            
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ekle;
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Staj kaydınız başarıyla tamamlanmıştır.");
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
