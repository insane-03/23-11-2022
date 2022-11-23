using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Text;


namespace TestCustomApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CustomController : ControllerBase
    {
        //[Route("api/add")]
        public String Add()
        {
            var val = "from custom add controller";
            return val;
        }
        //[Route("api/sub")]
        public String Sub()
        {
            var val = "from custom sub controller";
            return val;
        }
        //[Route("api/addint")]
        public int Addint(int a,int b)
        {
            var val = a + b;
            return val;
        }
    }
}
