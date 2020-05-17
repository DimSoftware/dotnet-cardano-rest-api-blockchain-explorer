namespace Cardano.Core.Nomenclatures
{
	public class NetworkEnum
	{
		protected readonly string Value;

		public static readonly NetworkEnum Testnet = new NetworkEnum("testnet");
		public static readonly NetworkEnum Mainnet = new NetworkEnum("mainnet");

		protected NetworkEnum(string value)
		{
			Value = value;
		}

		public string GetValue()
			=> Value;
	}
}
