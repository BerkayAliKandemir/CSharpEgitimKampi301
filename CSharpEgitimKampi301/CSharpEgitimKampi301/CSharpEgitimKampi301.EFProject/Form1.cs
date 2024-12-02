using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            // fazlalık
            
           

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            // listele butonu 

            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;

            // Guide guide = new Guide();
            //guide.GuideName = txtName.Text;
            //guide.GuideSurname = txtSurname.Text;
            //db.Guide.Add(guide);
            //db.SaveChanges();
            //MessageBox.Show("Rehber Başarıyla Güncellendi.");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // ekle butonu
            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellendi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // sil butonu 

            int id = int.Parse(textID.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // güncelle butonu
            int id = int.Parse(textID.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            // id ye gore getir butonu 

            int id = int.Parse(textID.Text);
            var values = db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
