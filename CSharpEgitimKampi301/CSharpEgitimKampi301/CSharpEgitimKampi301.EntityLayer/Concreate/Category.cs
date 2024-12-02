using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concreate
{
   public class Category
    {

        public int CategoryId { get; set; }
        // code first yaklaşımı içerisinde sınıf adınca sonuna ıd ekleyerek 
        // bunun birincil anahtar oldugu ve otomatık artan oldugu bildirilir. abcID olmaz mesela

        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }



        /*int x;// class icinde direk tanımlanırsa field
        public int MyProperty { get; set; }// class icinde get set ile tanımlanırsa property
        void test() { int z; }// metot icinde tanımlanırsa degisken z yani
  */
    }
}
