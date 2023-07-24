
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = null;
            try
            {
                baglanti = new SqlConnection("Data Source = DESKTOP-50GLTKQ\\SQLEXPRESS; Initial Catalog =OrnekUygulama; Integrated Security = True");
                baglanti.Open();

                SqlCommand Sqlkomut = new SqlCommand("SELECT marka,model,donanim,motor,yakit,vites,fiyat,websitesi FROM ArabaFiyatlarý", baglanti);
                SqlDataReader R = Sqlkomut.ExecuteReader();


                while (R.Read())
                {
                    string marka = R[0].ToString();
                    string model = R[1].ToString();
                    string donanim = R[2].ToString();
                    string motor = R[3].ToString();
                    string yakýt = R[4].ToString();
                    string vites = R[5].ToString();
                    string fiyat = R[6].ToString();
                    string websitesi = R[7].ToString();
                    richTextBox1.Text = richTextBox1.Text + marka + " " + model + " " + donanim + " " + motor + " " + yakýt + " " + vites + " " + fiyat + " " + websitesi;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("sql querry sýrasýnda hata olustu." + ex.ToString());

            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }
    }
}