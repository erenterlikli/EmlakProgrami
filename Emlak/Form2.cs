using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Emlak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=EREN\\SQLEXPRESS;Integrated Security=True");
        private void Goster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Emlakci.dbo.daire", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["satkir"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                listView1.Items.Add(ekle);
                


            }
            baglan.Close();
            textBox1.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox2.Text = " ";
            comboBox3.Text = " ";
            textBox3.Text = " ";
            comboBox4.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Menekşe Sitesi")
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Gül Sitesi")
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Yellow;
                button4.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Papatya Sitesi") 
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Lale Sitesi") 
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Yellow;
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Goster();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Insert Into Emlakci.dbo.daire(id,site,blok,no,oda,metre,satkir,fiyat,adsoyad,telefon,notlar) Values('"+textBox1.Text.ToString()+"','"+comboBox1.Text.ToString()+"','"+comboBox2.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+comboBox3.Text.ToString()+"','"+textBox3.Text.ToString()+"','"+comboBox4.Text.ToString()+"','"+textBox4.Text.ToString()+"','"+textBox5.Text.ToString()+"','"+textBox6.Text.ToString()+"','"+textBox7.Text.ToString()+"')",baglan);
            komut2.ExecuteNonQuery();
            baglan.Close();
            Goster();
            textBox1.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox2.Text = " ";
            comboBox3.Text = " ";
            textBox3.Text = " ";
            comboBox4.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut3 = new SqlCommand("Delete from Emlakci.dbo.daire where id=("+id+")",baglan);
            komut3.ExecuteNonQuery();
            baglan.Close();
            Goster();
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text=listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[10].Text;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut4 = new SqlCommand("Update Emlakci.dbo.daire set id='" + textBox1.Text.ToString() + "',site='" + comboBox1.Text.ToString() + "',blok='" + comboBox2.Text.ToString() + "',no='" + textBox2.Text.ToString() + "',oda='" + comboBox3.Text.ToString() + "',metre='" + textBox3.Text.ToString() + "',satkir='" + comboBox4.Text.ToString() + "',fiyat='" + textBox4.Text.ToString() + "',adsoyad='" + textBox5.Text.ToString() + "',telefon='" + textBox6.Text.ToString() + "',notlar='" + textBox7.Text.ToString() + "' where id= " + id + " ", baglan);
            komut4.ExecuteNonQuery();
            baglan.Close();
            Goster();
        }
    }
}
