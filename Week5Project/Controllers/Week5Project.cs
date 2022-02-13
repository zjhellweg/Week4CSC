using Microsoft.AspNetCore.Mvc;

namespace Week5Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Week4 : ControllerBase
    {
        [HttpPost(Name = "Week4")]
        public ActionResult<List<Doge>> Post([FromBody] List<Doge> input)
        {
            foreach(Doge doge in input)
            {
                System.Console.WriteLine(doge.Name);
            }

            //retuning input
            System.Diagnostics.Debug.WriteLine(input[0]);
            return Accepted(input);
        }

    };
    
}

public class Doge
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}