using SimulacionTP1.Modelo;

namespace SimulacionTP1.Presentacion
{
    public interface IFrmPruebaBondad
    {
        int GetCantidadNumeros();
        int GetCantidadIntervalos();
        void MostrarSerieAleatoria(string[] serie);
        void MostrarHistograma(ConteoFrecuencia[] conteoFrecuencias, int frecuenciaEsperada);
        void MostrarProcedimiento(string[][] procedimiento);
        void MostrarInformacion(string mensaje, string titulo);
        void MostrarError(string mensaje);
    }
}
