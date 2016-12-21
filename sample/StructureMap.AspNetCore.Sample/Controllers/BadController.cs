using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace StructureMap.AspNetCore.Sample.Controllers
{
    public class BadController : Controller
    {
        private readonly MySettings _settings;

        public BadController(IOptions<MySettings> settings)
        {
            _settings = settings.Value;
        }

        public IActionResult Index()
        {
            return Json(_settings);
        }
    }
}