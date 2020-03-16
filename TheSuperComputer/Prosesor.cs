using System;
using System.Collections.Generic;
using System.Text;

namespace TheSuperComputer
{
    class Prosesor
    {
        private String series;
        private int core;
        private int cache;

        public Prosesor()
        {

        }
        public void setSeries(String series)
        {
            this.series = series;
        }
        public String getSeries()
        {
            return this.series;
        }
        public void setCore(int core)
        {
            this.core = core;
        }
        public int getCore()
        {
            return this.core;
        }
        public void setCache(int cache)
        {
            this.cache = cache;
        }
        public int getCache()
        {
            return this.cache;
        }
        public override string ToString()
        {
            return $"Prosesor series:{this.series}; Prosesor core: {this.core}; Prosesor cache: {this.cache}";
        }
    }
}