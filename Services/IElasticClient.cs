using Nest;

namespace DotNetAndElastic.Services
{
    public interface IElasticClient
    {
        ElasticClient GetClient();
    }
}
