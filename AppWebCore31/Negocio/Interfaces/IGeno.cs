using AppWebCore31.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSGenograma;

namespace AppWebCore31.Negocio.Interfaces
{
    public interface IGeno
    {
        Task<ObtenerIntegrantesResponse> ObtenerGeno();
    }
}
