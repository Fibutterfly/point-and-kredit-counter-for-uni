using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_counter_for_uni
{
    class alairas
    {
        public string Text { get; set; }
        public bool Value { get; set; }
    }
    class add_max
    {
        public string Típus_név { get; set; }
        private int Típus_id { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public add_max(object cb_selected, string max, string min)
        {
            point_types pt = (point_types)cb_selected;
            Típus_név = pt.PT_name;
            Típus_id = pt.PT_SK;
            Max = int.Parse(max);
            Min = int.Parse(min);
            
        }
    }
    class subject_chooser
    {
        public string Tárgy_név { get; set; }
        public string Uni { get; set; }
        public string Tárgy_kód { get; set; }
        public string Elégséges { get; set; }
        public string Közepes { get; set; }
        public string Jó { get; set; }
        public string Jeles { get; set; }
        public string Aláírásos { get; set; }
    }
    class sum_by_types
    {
        public int Pont_id { get; set; }
        public string Pont_nev { get; set; }
        public int? Max { get; set; }
        public int? Min { get; set; }
        public double? Pont { get; set; }

    }
    class summarized
    {
        public string Tárgy_név { get; set; }
        public string Év { get; set; }
        public string Egyetem { get; set; }
        public double? Pont { get; set; }


        public int? kettes { get; set; }
        public int? harom { get; set; }
        public int? negy { get; set; }
        public int? öt { get; set; }
        public int Jegy { get; set; }
        
        public summarized()
        {

        }

        public void CalcJegy()
        {
            
            
            
            if (Pont < kettes)
            {
                Jegy = 1;
            }
            else if (kettes <= Jegy && Jegy < harom)
            {
                Jegy = 2;
            }
            else if (harom <= Jegy && Jegy < negy)
            {
                Jegy = 3;
            }
            else if (negy <= Jegy && Jegy < öt)
            {
                Jegy = 4;
            }
            else if (öt <= Jegy)
            {
                Jegy = 5;
            }
            //könnyebb így észre venni a hibát
            else
            {

                Jegy = 404;
            }
        }
    }
}
