using System;
using System.Collections.Generic;
using System.Text;

namespace lab_17
{
    class usedcars
    {




        public double usedPrice { get; set; }

        public double usedMileage { get; set; }
        public int usedYear { get; set; }
        public string usedModel { get; set; }
        public string usedMake { get; set; }


        public usedcars(int usedyear, string usedmake, string usedmodel, double usedprice, double usedmileage)
        {
            this.usedYear = usedyear;
            this.usedMake = usedmake;
            this.usedModel = usedmodel;
            this.usedPrice = usedprice;
            this.usedMileage = usedmileage;
        }

    }
}
