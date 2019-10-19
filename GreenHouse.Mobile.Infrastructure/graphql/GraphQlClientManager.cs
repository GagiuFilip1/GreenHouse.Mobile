using System;
using System.Threading.Tasks;
using GraphQL.Client.Http;
using GraphQL.Common.Request;

namespace GreenHouse.Mobile.Infrastructure.graphql
{
    public class GraphQlClientManager
    {
        private const string GraphQlEndpoint = "http://192.168.0.35:5000/graphql";
        private readonly GraphQLHttpClient m_client;

        public GraphQlClientManager()
        {
            m_client = new GraphQLHttpClient(GraphQlEndpoint);
        }

        public async Task<TK> SendMutationAsync<TK>(string schemaName,string mutationName, GraphQLRequest request) where TK : class
        {
            var response = await m_client.SendMutationAsync(request);
            response.Data = response.Data[schemaName];
            var result = response.GetDataFieldAs<TK>(mutationName);
            return result;
        }
    }
}