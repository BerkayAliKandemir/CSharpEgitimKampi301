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
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void frmStatistic_Load(object sender, EventArgs e)
        {
            lblocation.Text = db.Location.Count().ToString();
            // Kapasite toplamını hesaplayarak label'a atama
           lblCapacitySum.Text = db.Location.Sum(x => x.Capacity).ToString();
            

              // Rehber sayısını hesaplayarak label'a atama
              lblGuideCount.Text = db.Guide.Count().ToString();

              // Ortalama kapasiteyi hesaplayarak label'a atama
              lblAvgCapacity.Text = db.Location.Average(x => (double)x.Capacity).ToString("F2");

              // Ortalama fiyatı hesaplayarak label'a atama
            
          
            lblAvgLocationPrice.Text = db.Location
                .Average(x => (double)x.Price) // Price'ı double'a dönüştür
                .ToString("N0", new System.Globalization.CultureInfo("tr-TR")) // Türkçe formatlama
                + " ₺";


            // En yüksek LocationId değerini alma
            int lastCountryId = db.Location.Max(x => x.LocationId);//tik

              // Son ülkeye ait ülke adını label'a atama
              lblLastCountryName.Text = db.Location
                  .Where(x => x.LocationId == lastCountryId)
                  .Select(y => y.Country)
                  .FirstOrDefault();// tik 

              // Kapadokya şehrine ait ortalama kapasiteyi label'a atama
              lblCappadociaCapacity.Text = db.Location
                  .Where(x => x.City == "Kapadokya")
                  .Select(y => y.Capacity)
                  .FirstOrDefault().ToString();//tik

              // Türkiye'ye ait ortalama kapasiteyi label'a atama
              lblTurkeyCapacityAvg.Text = db.Location
                  .Where(x => x.Country == "Turkiye")
                  .Average(y => (double)y.Capacity)
                  .ToString("F2");//tik

              // Roma Turistik'e ait rehber bilgilerini alma
                 var romeGuideId = db.Location
                      .Where(x => x.City == "Roma")
                      .Select(y => y.GuideId)
                      .FirstOrDefault();
              

                 lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId)
                .Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            
        
                 // Maksimum kapasiteyi alma
                 var maxCapacity = db.Location.Max(x => x.Capacity); //tik

                 // Maksimum kapasiteye sahip konuma ait ülke bilgisini alma
                 lblMaxCapacityLocation.Text = db.Location
                     .Where(x => x.Capacity == maxCapacity)
                     .Select(y => y.City)
                     .FirstOrDefault()
                     .ToString();// tik

                 // Maksimum fiyatı bulma
                 var maxPrice = db.Location.Max(x => x.Price);

                 // Maksimum fiyat bilgisine sahip konum bilgilerini alma
                 lblMaxPriceLocation.Text = db.Location
                     .Where(x => x.Price == maxPrice)
                     .Select(y => y.City)
                     .FirstOrDefault()
                     .ToString();
            

            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar")
                .Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTurkiyeCapacityAvg_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
