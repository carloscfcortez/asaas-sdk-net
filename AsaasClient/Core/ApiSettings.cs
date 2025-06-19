using System;

namespace AsaasClient.Core
{
    public class ApiSettings
    {
        public string AccessToken { get; }
        public AsaasEnvironment AsaasEnvironment { get; }
        public TimeSpan TimeOut { get; set; }

        public string ApplicationName { get; set; } = "AsaasClient";

        public ApiSettings(
            string accessToken, AsaasEnvironment asaasEnvironment, string applicationName)
        {
            AccessToken = accessToken;
            AsaasEnvironment = asaasEnvironment;
            ApplicationName = applicationName ?? "AsaasClient";
            TimeOut = TimeSpan.FromSeconds(30);
        }
    }
}
