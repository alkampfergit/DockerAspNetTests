namespace TestFs.Controllers
{
    public class GetRequest
    {
        public string Path { get; set; }
    }

    public class SetRequest
    {
        public string Path { get; set; }

        public string Content { get; set; }

    }
}
