using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_counter_for_uni
{
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
