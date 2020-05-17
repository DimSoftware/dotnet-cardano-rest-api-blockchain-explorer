using Cardano.Explorer.Rest.Api.Models;
using Cardano.Explorer.Rest.Api.Models.Common;
using Cardano.Models.Common;

namespace Cardano.Explorer.Rest.Api.Common
{
    public static class ResponseExtensions
    {
        public static Response<Right<TModel>> Merge<TModel, TData>(this Response<Right<TData>> response)
            where TModel : PolytypeBase<TData>, new()
        {
            return new Response<Right<TModel>>
            {
                Content = new Right<TModel>
                {
                    Result = new TModel
                    {
                        Data = response.Content.Result
                    },
                },
                HttpResponseModel = response.HttpResponseModel
            };
        }
    }
}
