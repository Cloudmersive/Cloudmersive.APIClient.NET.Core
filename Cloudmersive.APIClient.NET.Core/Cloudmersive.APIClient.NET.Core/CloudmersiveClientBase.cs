using System;
using System.Collections.Generic;
using System.Text;

namespace Cloudmersive.APIClient.NET.Core
{
    public abstract class CloudmersiveClientBase
    {


        protected string Apikey;

        public long GetApikeyUsage()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Apikey", Apikey);
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";



                var response = client.DownloadString("https://api.cloudmersive.com/nlp/apikeyusage/" + Apikey);

                return System.Convert.ToInt64(response);
            }
        }

        public void LoadApikeyFromConfig()
        {
            // Try web.config

            System.Configuration.Configuration rootWebConfig1 =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(null);

            System.Configuration.KeyValueConfigurationElement customSetting =
                    rootWebConfig1.AppSettings.Settings["CloudmersiveApikey"];

            if (customSetting != null)
            {
                Apikey = customSetting.Value;
            }
            else
            {
                // No web config, try App.config

                string apikeySettingValue = ConfigurationManager.AppSettings["CloudmersiveApikey"];

                if (apikeySettingValue != null)
                {
                    Apikey = apikeySettingValue;
                }
            }
        }




    }
}
