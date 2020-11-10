using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDemoAPI.Services
{
    public interface IMailService
    {
        void Sendmail();
    }

    public class MailService : IMailService
    {
        private readonly IConfiguration _config;

        public MailService( IConfiguration config)
        {
            _config = config ?? throw new NullReferenceException();
        }
        public void Sendmail( )

        {
            Debug.WriteLine($"{_config["MailSettings:From"]} sending mail to {_config["MailSettings:To"]} ");

        }
    }
}
