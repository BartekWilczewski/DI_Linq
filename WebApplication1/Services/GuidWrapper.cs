
namespace WebApplication1.Services
{
    public class GuidWrapper : IGuidWrapper
    {
        private readonly IGuidService _guidService;
        public GuidWrapper(IGuidService service)
        {
            _guidService = service;
        }

        public string GetGuid()
        {
            return _guidService.Get();
        }
    }
}
