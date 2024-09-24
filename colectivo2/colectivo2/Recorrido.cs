using System.Collections;
using System.Windows.Forms;

namespace colectivo2
{
    internal class Recorrido
    {
        int horaInicioRecorrido;
        int horaFinRecorrido;
        int cantAsiento;
        int cantPasajerosTranspotados;
        int cantTotalPasajerosTransportados;
        int cantTotalParadasRealizadas;
        int tiempoTotalDeDemoras;
        ArrayList listaDeParadasRealizadas;
        bool estadoDelRecorrido;


        //PROPIEDADES
        public bool EstadoDelRecorrido { get { return estadoDelRecorrido; } }
        public int CantAsiento { get { return cantAsiento; } }
        public int CantidadPasajerosTransportados { get { return cantPasajerosTranspotados ; } }
        public int CantTotalParadasRealizadas { get { return  cantTotalParadasRealizadas ; } }
        public int TiempoTotalDeDemoras { get { return tiempoTotalDeDemoras ; } }   



        //  CONTRUCTOR
        public Recorrido(int horaInicio, int cantAsiento)
        {
            horaInicioRecorrido = horaInicio;
            this.cantAsiento = cantAsiento;
            listaDeParadasRealizadas = new ArrayList();
        }


        //  METODOS
        public bool DesiendenPasajerosT(int cantPasajero)
        {
            
                if(cantPasajero > (cantPasajerosTranspotados - cantAsiento))
                {
                    cantPasajerosTranspotados -= cantPasajero;
                    return true;
                }

                return false;
          
        }
        public bool AsiendenPasajeros(int cantPasajero)
        {
            if(cantPasajero< (cantPasajerosTranspotados - cantAsiento))
            {
                cantPasajerosTranspotados += cantPasajero;
                return true;
            }

            return false;
        }


        public int TiempoTotalDelRecorrido() 
        {
            int tRecorrido;
            tRecorrido = horaFinRecorrido - horaInicioRecorrido; 
            return tRecorrido;
        }

       

        public void CargarParada() { }

        public void FinalizarRecorrido() { }



    }
}