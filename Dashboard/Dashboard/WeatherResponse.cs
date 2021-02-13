﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    class WeatherResponse //Парсинг JSON
    {
        public Coord coord { get; set; }
        public Weather[] weather { get; set; }

        public string based { get; set; }

        public Main main { get; set; }

        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }

        public long dt { get; set; }
        public Sys sys { get; set; }

        public int timezone { get; set; }
        public long id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}
