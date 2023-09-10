namespace WebApplication1.Services
{
    public class GuidService : IGuidService
    {
        private readonly string _guid;

        public GuidService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string Get()
        {
            return _guid;
        }
    }
}
