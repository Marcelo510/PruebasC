using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebCore31.Core
{
    public static class ApplicationSettings
    {
        public static string WebApiUrl { get; set; }
        public static string WebApiUrlEnviarCorreoAnses { get; set; }

        public static string WebApiUrlEnviarCorreo { get; set; }

        public static string MailTo { get; set; }

        public static string Subject { get; set; }

        public static string AuthUrl { get; set; }


        public static string WS_Geno { get; set; }

        public static void ApplicationConfig()
        {
            WebApiUrl = Environment.GetEnvironmentVariable("WEB_API_BASE_URL_MAIL");
            WebApiUrlEnviarCorreo = Environment.GetEnvironmentVariable("WEB_API_ENVIAR_CORREO");
            WebApiUrlEnviarCorreoAnses = Environment.GetEnvironmentVariable("WEB_API_ENVIAR_CORREO_ANSES");
            MailTo = Environment.GetEnvironmentVariable("MAIL_TO");
            Subject = Environment.GetEnvironmentVariable("SUBJECT");


            //AuthUrl = Environment.GetEnvironmentVariable("AuthPath").ToString();

            WS_Geno = Environment.GetEnvironmentVariable("WS_Geno").ToString();

        }
    }
}
