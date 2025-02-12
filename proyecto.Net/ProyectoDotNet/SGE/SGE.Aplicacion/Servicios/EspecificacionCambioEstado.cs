﻿namespace SGE.Aplicacion;

public class EspecificacionCambioEstado
{
    public EstadoExpediente DeterminarNuevoEstado(EtiquetaTramite etiquetaUltimoTramite, EstadoExpediente estadoActual)
    {
        // Lógica para determinar el nuevo estado basado en la etiqueta del último trámite
        switch (etiquetaUltimoTramite)
        {
            case EtiquetaTramite.PaseAEstudio:
                return EstadoExpediente.ParaResolver;

            case EtiquetaTramite.Resolucion:
                return EstadoExpediente.ConResolucion;

            case EtiquetaTramite.PaseAlArchivo:
                return EstadoExpediente.Finalizado;
                
            default:
                return estadoActual;
        }
    }
}