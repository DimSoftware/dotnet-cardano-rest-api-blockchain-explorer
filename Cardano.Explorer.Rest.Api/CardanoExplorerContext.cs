using Cardano.Core;
using Cardano.Explorer.Rest.Api.Implementation;
using System;

namespace Cardano.Explorer.Rest.Api
{
	public sealed class CardanoExplorerContext
	{
		private const string defaultUrl = "http://localhost:8100/";

		public CardanoExplorerContext(string cardanoNodeUrl = defaultUrl)
		{
			if (!CardanoNode.IsValidUrl(cardanoNodeUrl))
			{
				throw new UriFormatException(ErrorMessages.BaseUrlIsNotValid);
			}

			new CardanoNode(new Uri(cardanoNodeUrl));

			this.AddressesRequests = new AddressesRequests();
			this.BlocksRequests = new BlocksRequests();
			this.EpochsRequests = new EpochsRequests();
			this.GenesisRequests = new GenesisRequests();
			this.HttpBridgeRequests = new HttpBridgeRequests();
			this.TransactionsRequests = new TransactionsRequests();
		}

		public AddressesRequests AddressesRequests { get; }
		public BlocksRequests BlocksRequests { get; }
		public EpochsRequests EpochsRequests { get; }
		public GenesisRequests GenesisRequests { get; }
		public HttpBridgeRequests HttpBridgeRequests { get; }
		public TransactionsRequests TransactionsRequests { get; }
	}
}
