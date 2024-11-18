using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {

        /* field variable property arasında farklar
         * eğer bir değişken direkt sınıfın içine tanımlanırsa field olarak karşılar
         * eğer o değişkenin yapısı get set değerlerini alırsa property olur
         * metot içine tanımlanırsa değişken(variable) olur
         * 
         * int x; --> field 
         * int x {get; set;} --> property
         * public sayi()
         * {
         *      int x; --> variable
         * }
        */

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
