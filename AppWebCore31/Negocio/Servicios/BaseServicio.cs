using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSGenograma;
using System.ServiceModel;
using AppWebCore31.Core;

namespace AppWebCore31.Negocio.Servicios
{
    public class BaseServicio
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BaseServicio(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public WebService1SoapClient GetClientConnection()
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(ApplicationSettings.WS_Geno));
            var WsSoapClient = new WebService1SoapClient(binding, endpoint);
            //WsSoapClient.Endpoint.EndpointBehaviors.Add(new InspectorBehavior(_httpContextAccessor));
            return WsSoapClient;
        }
    }
}
