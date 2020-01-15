using Microsoft.AspNetCore.Mvc;

namespace dockerdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ActionResult<string[]> Values()
        {
            string[] values = { "Value1", "Value2", "Value3" };
            return values;
        }
    }
}