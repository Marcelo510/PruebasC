using AppWebCore31.Models;
using AppWebCore31.Negocio.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSGenograma;

namespace AppWebCore31.Negocio.Servicios
{
    public class GenoServicio : IGeno
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GenoServicio(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        

        public Task<WSGenograma.ObtenerIntegrantesResponse> ObtenerGeno()
        {
            Task<WSGenograma.ObtenerIntegrantesResponse> response;

            try
            {
                //ANSESLog.Info(typeof(EmpleadoService), "Llamando al servicio EmpleadoUnidadOrganicaWS: ObtenerEmpleadoCuil");
                WebService1SoapClient SoapClient = new BaseServicio(_httpContextAccessor).GetClientConnection();
                //SoapClient.Endpoint.EndpointBehaviors.Add(new InspectorBehavior(_httpContextAccessor));
                response = SoapClient.ObtenerIntegrantesAsync();

                
                
            }
            catch (Exception ex)
            {
                //ANSESLog.Error(typeof(EmpleadoService), ex.Message, ex);
                throw new Exception(ex.Message);
            }

            return response;
        }
    }
}
