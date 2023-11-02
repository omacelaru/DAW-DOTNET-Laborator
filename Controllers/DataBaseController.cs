using DAW_DOTNET_Laborator.Data;
using Microsoft.AspNetCore.Mvc;

namespace DAW_DOTNET_Laborator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataBaseController : ControllerBase
    {
        private readonly StudentContext _studentContext;

        public DataBaseController(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

    }
}
