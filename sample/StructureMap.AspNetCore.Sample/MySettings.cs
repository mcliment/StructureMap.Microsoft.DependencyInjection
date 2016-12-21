using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace StructureMap.AspNetCore.Sample
{
    public class MySettings
    {
        public string Foo { get; set; }
    }

    public class MySettingsWrapper : IMySettingsWrapper
    {
        private readonly MySettings _settings;

        public MySettingsWrapper(IOptions<MySettings> settings)
        {
            _settings = settings.Value;
        }

        public MySettings Get()
        {
            return _settings;
        }
    }

    public interface IMySettingsWrapper
    {
        MySettings Get();
    }
}
