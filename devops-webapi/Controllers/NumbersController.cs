using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace devops_webapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {

        // GET numbers
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new[] { "One", "Two", "Three", "Four", "Five" };
        }

        // GET numbers/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            string value;
            switch (id)
            {
                case 1:
                    value = "One";
                    break;
                case 2:
                    value = "Two";
                    break;
                case 3:
                    value = "Three";
                    break;
                case 4:
                    value = "Four";
                    break;
                case 5:
                    value = "Five";
                    break;
                default:
                    value = "No Valid ID";
                    break;
            }

            return value;
        }

    }
}
