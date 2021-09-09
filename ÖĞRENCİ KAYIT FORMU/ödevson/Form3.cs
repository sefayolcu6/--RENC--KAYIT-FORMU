using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödevson
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection bag = new OleDbConnection
                ("Provider = Microsoft.Ace.Oledb.12.0;Data source=data.accdb");
            try
            {
                bag.Open();
                MessageBox.Show("Bağlantı Açıldı");
                bag.Close();
                MessageBox.Show("Bağlantı Kapandı");





            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }



        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)
                08)//harf tuşlarını kilitle del tuşu hariç
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)
08 && e.KeyChar != (char)32)//rakam tuşlarını kilitle del tuşu, boşluk tuşu hariç
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
