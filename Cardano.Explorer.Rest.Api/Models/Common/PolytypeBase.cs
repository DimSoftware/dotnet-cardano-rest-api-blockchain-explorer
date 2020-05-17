namespace Cardano.Explorer.Rest.Api.Models.Common
{
    public abstract class PolytypeBase<TData>
    {
        public virtual TData Data { set { } }
    }
}
