﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using System.Web.Http.SelfHost;
using TwilioEmulator;
using TwilioEmulator.Properties;
using Twilio;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TwilioEmulator.Offices;
using TwilioEmulator.Phones;


namespace TwilioEmulator.Code
{
    public class SystemController : IDisposable
    {
        private static HttpSelfHostServer server = (HttpSelfHostServer)null;

        #region Static 
        private static readonly Lazy<SystemController> _instance = new Lazy<SystemController>((Func<SystemController>)(() => new SystemController()));
        private  readonly Lazy<Office> _office = new Lazy<Office>((Func<Office>)(() => new Office()));

        public static bool ConsoleMode { get; set; }

        public ILogger Logger { get; set; }

        public static SystemController Instance
        {
            get
            {
                return SystemController._instance.Value;
            }
        }

        public   Office Office
        {
            get
            {
                return _office.Value;
            }
        }

       

        #endregion

        public MainForm theForm { get; set; }

        public IPhoneManager PhoneManager { get; set; }

        public int ActivePort { get; set; }

        private static int _waitInterval = 1000;

        public static int WaitInterval
        {
            get { return _waitInterval; }
            set { _waitInterval = value; }
        }
        

        private void StartWebServer()
        {
            string port = Settings.Default.Port;
            HttpSelfHostConfiguration configuration = new HttpSelfHostConfiguration("http://localhost:" + port);

            string ModifyTemplate1 = "2010-04-01/Accounts/{sid}/{controller}/{id}.json";
            string ModifyTemplate2 = "2010-04-01/Accounts/{sid}/{controller}/{id}";
            object modifydefaults = (object)new
            {
                action = "Modify"
            };

            string routeTemplate1 = "2010-04-01/Accounts/{sid}/{controller}.json";
            string routeTemplate2 = "2010-04-01/Accounts/{sid}/{controller}";


            HttpRouteCollectionExtensions.MapHttpRoute(configuration.Routes, "ModifyDefault", ModifyTemplate1, modifydefaults);
            HttpRouteCollectionExtensions.MapHttpRoute(configuration.Routes, "ModifyDirect", ModifyTemplate2, modifydefaults);
            HttpRouteCollectionExtensions.MapHttpRoute(configuration.Routes, "Default", routeTemplate1);
            HttpRouteCollectionExtensions.MapHttpRoute(configuration.Routes, "Direct", routeTemplate2);
            
            JsonMediaTypeFormatter jsonFormatter = configuration.Formatters.JsonFormatter;
            JsonSerializerSettings jSettings = new Newtonsoft.Json.JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };
            jSettings.Converters.Add(new TwilioDateTimeConvertor());
            jsonFormatter.SerializerSettings = jSettings;
            
            
            HttpSelfHostServer httpSelfHostServer = new HttpSelfHostServer(configuration);
            try
            {
                httpSelfHostServer.OpenAsync().Wait();
            }
            catch (AggregateException ex)
            {
                if (ex.InnerException.Message.Contains("Your process does not have access rights to this namespace"))
                    throw new Exception("You don't have rights to open this port - Try running as administrator or giving permission via NETSTAT", (Exception)ex);
                else
                    throw ex;
            }
            this.ActivePort = int.Parse(port);
        }

        public void StartUp()
        {
            this.StartWebServer();
            Office.Startup();
             
        }

        public void Dispose()
        {
            SystemController.server.Dispose();
        }

       

        
    }

    public class TwilioDateTimeConvertor : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return DateTime.Parse(reader.Value.ToString());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime)value).ToString("ddd, dd MMM yyyy HH:mm:ss '+0000'"));
        }
    }
}