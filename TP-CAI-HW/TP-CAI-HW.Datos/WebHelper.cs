﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace TP_CAI_HW.Datos
{
    public static class WebHelper
    {
  
        static WebClient client;
        static string rutaBase;

        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = "https://cai-api.azurewebsites.net/swagger/index.html/api/v1/VentaHardware/";
            client.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }


        public static string Get(string url)
        {
            string uri = rutaBase + url;
            string responseString = client.DownloadString(uri);
            return responseString;
        }

        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;
            try
            {
                var response = client.UploadValues(uri, parametros);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
            catch (Exception)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }
        public static string Put(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, "PUT", parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }

        public static string Delete(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, "DELETE", parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }
        }

    }
}
