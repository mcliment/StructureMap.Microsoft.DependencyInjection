using Microsoft.AspNetCore.Mvc;

namespace StructureMap.AspNetCore.Sample.Controllers
{
    public class GoodController : Controller
    {
        private readonly MySettings _settings;

        public GoodController(IMySettingsWrapper wrapper)
        {
            _settings = wrapper.Get();
        }

        public IActionResult Index()
        {
            return Json(_settings);
        }
    }
}
