using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Dolznost;

namespace ClassLibrary1
{
    public class Dolznost
    {
        /// <summary>
        /// Класс Должность
        /// Вариант 10
        /// Сделал Ли Михаил
        /// </summary>
        private string nazvanie;
        private double oklad;
        private string podraz;

        public Dolznost(string nazvanie, double oklad, string podraz)
        {
            this.nazvanie = nazvanie;
            this.oklad = oklad;
            this.podraz = podraz;
        }

        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }

        public double Oklad
        {
            get { return oklad; }
            set { oklad = value; }
        }
        public string Podrazdel
        {
            get { return podraz; }
            set { podraz = value; }
        }
    }
}
