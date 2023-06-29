using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistryApp.BLL.Managers;
using RegistryApp.BLL.Security;

namespace RegistryApp.Read.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            ReadManager readManager = new ReadManager();
            var encryptedText = readManager.GetValueFromRegistry();

            DencryptData decryptText = new DencryptData();
            string result = decryptText.Decrypt(encryptedText);

            return Ok(result);
        }
    }
}
