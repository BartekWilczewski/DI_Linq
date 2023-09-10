
namespace WebApplication1.Services
{
    public class GuidWrapper2 : IGuidWrapper2
    {
        private readonly IGuidService _guidService;
        public GuidWrapper2(IGuidService service)
        {
            _guidService = service;
        }

        public string GetGuid()
        {
            return _guidService.Get();
        }
    }
}
