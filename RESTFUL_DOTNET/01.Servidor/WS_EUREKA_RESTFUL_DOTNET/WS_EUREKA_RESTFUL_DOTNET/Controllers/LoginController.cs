using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WS_EUREKA_RESTFUL_DOTNET.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public ActionResult Login()
        {
            try
            {
                using (var reader = new System.IO.StreamReader(Request.InputStream))
                {
                    var requestBody = reader.ReadToEnd();
                    var loginRequest = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginRequest>(requestBody);

                    if ((loginRequest.Username == "admin" && loginRequest.Password == "admin") || (loginRequest.Username == "monster" && loginRequest.Password == "774e993500f4027acfd72b7a7ee564b76ae43cf7c4c943ed0e0f364cca16b6ec"))
                    {
                        return Json(new { success = true });
                    }
                    else
                    {
                        return Json(new { success = false, message = "Invalid username or password" });
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}