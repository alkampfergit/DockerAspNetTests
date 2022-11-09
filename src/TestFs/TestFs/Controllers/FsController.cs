using Microsoft.AspNetCore.Mvc;

namespace TestFs.Controllers
{
    [ApiController]
    [Route("fs")]
    public class FsController : ControllerBase
    {
        [HttpPost()]
        [Route("get")]
        public object Get(GetRequest request)
        {
            var path = request.Path;
            return Dir(path);
        }

        [HttpPost]
        [Route("set-content")]
        public object stocazzo(SetRequest request)
        {
            var path = Path.GetDirectoryName(request.Path);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            System.IO.File.WriteAllText(request.Path, request.Content);
            return Dir(path);
        }

        private static object Dir(string path)
        {
            if (!Directory.Exists(path))
            {
                return new { Message = $"Directory {path} does not exists" };
            }

            var files = Directory.GetFiles(path);
            return new { 
                Files = files,
                CurrentDir = AppDomain.CurrentDomain.BaseDirectory, 
            };
        }

    }
}