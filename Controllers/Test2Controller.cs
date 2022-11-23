using Microsoft.AspNetCore.Mvc;
using TestCustomApi.Model;
using Microsoft.AspNetCore.Components.Routing;
using System.Reflection.Metadata.Ecma335;

namespace TestCustomApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Test2Controller : Controller
    {

        [Route("[action]")]
        public string ViewName() => "testcontroller";
        [HttpGet("all")]
        //[Route("all")]
        public ActionResult<List<TestModel>> GetTestDetail()
        {
            //var result= 
           
            return new List<TestModel>()
                {
                    //"test1", "test2"
                        new TestModel() { id = 1, name = "xxxxx", productId = 29543},
                        new TestModel() { id = 2, name = "yyyyy", productId = 12345},
                        new TestModel() { id = 3, name = "zzzzz", productId = 98765},
                        new TestModel() { id = 4, name = "qqqqq", productId = 21530}
                };//result;
        }

        [HttpGet]
        public IActionResult  GetTestData()
        {
            var result = new List<TestModel>()
                {
                    //"test1", "test2"
                        new TestModel() { id = 1, name = "xxxxx", productId = 29543}
                        //new TestModel() { id = 2, name = "yyyyy", productId = 12345},
                        //new TestModel() { id = 3, name = "zzzzz", productId = 98765},
                        //new TestModel() { id = 4, name = "qqqqq", productId = 21530}
                };

            return Ok(result);
        }



        [Route("{id}")]
        public IActionResult GetTestDetail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return Ok(new List<TestModel>() {
                //new TestModel() { Id = 1, Name = "xxxxx", ProductId = 29543},
                //new TestModel() { Id = 2, Name = "yyyyy", ProductId = 12345},
                //new TestModel() { Id = 3, Name = "zzzzz", ProductId = 98765},
                //new TestModel() { Id = 4, Name = "qqqqq", ProductId = 21530}
                }
            );
                        
        }                   
    }
}
