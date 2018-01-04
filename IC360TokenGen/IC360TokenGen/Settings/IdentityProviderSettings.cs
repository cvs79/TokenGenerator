using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IC360TokenGen.Settings
{
    public class IdentityProviderSettings
    {
        public List<OpenIdSettings> Settings { get; set; }
    }

    public class OpenIdSettings
    {
        public string Authority { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Scope { get; set; }
        public string Provider { get; set; }
        public string CallbackPath { get; set; }
        public string LogoutUrl { get; set; }

    }
}
