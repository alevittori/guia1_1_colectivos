using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectivo2
{
    internal class Parada
    {
        int cantDesienden;
        int cantAsienden;
        int tiempoDemora;
        int horaLlegadaParada;
        int horaSalidaParada;


        //PROPIEDADES
        public int CantDesienden { get { return cantDesienden; }  }
        public int CantAsienden { get { return cantAsienden; }  }
        public int TiempoDemora { get { return tiempoDemora; }  }
        public int HoraLlegadaParada { get { return horaLlegadaParada; }}
        public int HoraSalidaParada { get { return horaSalidaParada; } }


        //constructor

        public Parada(int cantDesienden, int cantAsienden, int horaLlegadaParada, int horaSalidaParada)
        {
            this.cantDesienden = cantDesienden;
            this.cantAsienden = cantAsienden;
            
            this.horaLlegadaParada = horaLlegadaParada;
            this.horaSalidaParada = horaSalidaParada;

            this.tiempoDemora = horaSalidaParada - horaLlegadaParada;
        }
    }
}
