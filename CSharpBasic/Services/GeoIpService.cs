using CSharpBasic.Interfaces;

namespace CSharpBasic.Services
{
    public class GeoIpService: IGeoIpService
    {
        public object GetData()
        {
            return new {country="Taiwan"};
        }
    }
}