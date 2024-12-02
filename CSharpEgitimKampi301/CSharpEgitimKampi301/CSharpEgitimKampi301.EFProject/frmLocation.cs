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
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            //listele
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            // form locationu 
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            Location location = new Location();
            //location.Capacity = byte.Parse(nudCapacity.Value.ToString());

            try
            {
                if (nudCapacity.Value < byte.MinValue || nudCapacity.Value > byte.MaxValue)
                {
                    MessageBox.Show("Kapasite değeri 0 ile 255 arasında olmalıdır.");
                    return;
                }

                location.City = txtCity.Text;
                location.Country = txtCountry.Text;
                location.Price = decimal.Parse(txtPrice.Text);
                location.DayNight = txtDayNight.Text;
                location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
                db.Location.Add(location);
                db.SaveChanges();
                MessageBox.Show("Ekleme işlemi başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //silme 
            int id = int.Parse(textId.Text);
            var deletedVaue = db.Location.Find(id);
            db.SaveChanges();
            MessageBox.Show("silme islemi basarili");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // guncelle 
            int id = int.Parse(textId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.City = txtCity.Text;
            updatedValue.Country = txtCountry.Text;
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Guncelleme basarılı");
        }
    }
}
