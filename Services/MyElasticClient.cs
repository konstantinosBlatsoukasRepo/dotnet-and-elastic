using Nest;

namespace DotNetAndElastic.Services
{
    public class MyElasticClient : IElasticClient
    {
        private readonly ElasticClient _elasticClient;

        public MyElasticClient()
        {
            _elasticClient = new ElasticClient();
        }
        public ElasticClient GetClient() => _elasticClient;

    }
}
