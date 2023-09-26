using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entiteti
{
    public class Karta : Entitet<Guid>
    {

        public Karta(Guid id, string mestoPolaska, string mestoDolaska, DateTime vremePolaska, string tipKarte) : base(id)
        {
            MestoPolaska = mestoPolaska;
            MestoDolaska = mestoDolaska;
            VremePolaska = vremePolaska;
            TipKarte = tipKarte;
        }

       private Karta() { }



        public string MestoPolaska { get; set; }
        public string MestoDolaska { get; set; }
        public DateTime VremePolaska { get; set; }

        public string TipKarte { get; set; }

    }

}
