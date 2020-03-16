using System;
using System.Collections.Generic;
using System.Text;

namespace TheSuperComputer
{
    class Print
    {
        private String brand;
        private String series;
        private int ppm;
        
        public Print(String brand,String series,int ppm)
        {
            this.brand = brand;
            this.series = series;
            this.ppm = ppm;
        }
        public String getBrand()
        {
            return this.brand;
        }
        public String getSeries()
        {
            return this.series;
        }
        public int getPpm()
        {
            return this.ppm;
        }
        public override string ToString()
        {
            return $"Print brand : {this.brand}; Print series : {this.series}; Print paper per minutes (ppm) : {this.ppm}";
        }

    }
}
