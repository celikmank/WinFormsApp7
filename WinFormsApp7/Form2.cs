using System.Data.SqlClient;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        SqlConnection Sqlbaglanti = new SqlConnection("Data Source = DESKTOP-50GLTKQ\\SQLEXPRESS; Initial Catalog =OrnekUygulama; Integrated Security = True");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sqlbaglanti.Open();
                String sqlcumlesı = "INSERT INTO MusteriBilgileri VALUES ('" + textBox1.Text + "', '" +
                                                                             textBox2.Text + "', '" +
                                                                             textBox3.Text + "', '" +
                                                                             textBox4.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(sqlcumlesı, Sqlbaglanti);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Musteri bilgileri kaydedilmiştir.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Veritabananında hata oluştu lutfen daha sonra tekrar deneyın");
            }
            finally
            {
                if (Sqlbaglanti != null)
                    Sqlbaglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Sqlbaglanti.Open();
                SqlCommand sqlcommand = new SqlCommand("UPDATE MusteriBilgileri SET " +
                   "Ad= '" + textBox2.Text + "',Soyad= '" + textBox3.Text +
                   "', Adres= '" + textBox4.Text + "' WHERE MusteriıD = " + textBox1.Text, Sqlbaglanti);
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("Kayıt basarıyla Guncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı guncellenırken bır hata olustu sonra tekrar deneyın " + ex.ToString());
            }
            finally
            {
                if (Sqlbaglanti != null)
                    Sqlbaglanti.Close();
            }
        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Sqlbaglanti.Open();
                SqlCommand sqlcommand = new SqlCommand("DELETE FROM MusteriBilgileri WHERE MusteriıD= "+textBox5.Text,Sqlbaglanti);
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("Kayıt basarıyla silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("kayıt silinirken bır hata olustu sonra tekrar deneyın " + ex.ToString());
            }
            finally
            {
                if (Sqlbaglanti != null)
                    Sqlbaglanti.Close();
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
