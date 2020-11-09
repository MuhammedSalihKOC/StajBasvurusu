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

namespace StajBasvurusu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Giris_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Stajer.accdb");
            baglan.Open();
            OleDbCommand kom = new OleDbCommand("select* from Stajerler where OkNo = "+No.Text, baglan);
            OleDbDataReader dr = kom.ExecuteReader();            
            while (dr.Read())
            {
                AdSo.Text = dr["AdSo"].ToString();
                OkNo.Text = dr["OkNo"].ToString();
                Bolum.Text = dr["Bolum"].ToString();
                StajTur.Text = dr["StajTur"].ToString();
                isAd.Text = dr["isAd"].ToString();
                isTel.Text = dr["isTel"].ToString();
                isPost.Text = dr["isPost"].ToString();
                Faal.Text = dr["Faal"].ToString();
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
