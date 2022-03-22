using backend.BE;
using Microsoft.AspNetCore.Mvc;
namespace backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class FrontEndController : ControllerBase
    {
        private IPeriodicElement PeriodicElement { get; set; }

        public FrontEndController(IPeriodicElement periodicElement)
        {
            PeriodicElement = periodicElement;
        }


        [Route("FrontEnd")]
        [HttpGet]
        public IActionResult FrontEnd()
        {
            var data = PeriodicElement.GetAll();
            return Ok(data);
        }
    }
}
