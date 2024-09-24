using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectivo2
{
    internal class Colectivo
    {
        int numDeUnidad;
        int cantAsientosUnidad;
        Recorrido unRecorrido;
        ArrayList listaRecorridosRealizados;


        public Colectivo(int nUnidad, int cantAstientos)
        {
            numDeUnidad = nUnidad;
            cantAsientosUnidad = cantAstientos;
            listaRecorridosRealizados = new ArrayList();
        }

        public void IniciarRecorrido() { }

        public void FinalizarRecorrido() { }

        public void CargarParada() { }

        public void Informe() { }
    }
}
